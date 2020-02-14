﻿using System;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;


namespace lib.Entity
{
  /// <summary>
  /// Funções em comum para todo tipo de banco de dados
  /// </summary>
  public abstract class DbBase
  {
    public DbBase(string ConnectionString)
    {
      cnv = new Conversion();
      this.ConnectionString = ConnectionString;
    }

    public int ExecutedCommands { get; set; }
    protected object ObjLock = new object();
    public Conversion cnv { get; set; }
    public string DbReturnLastID { get; set; }
    public string DbFormatDate { get; set; }
    public string DbWithNolock { get; set; }
    public string ConnectionString { get; set; }
    public DbConnection DbConnection { get; set; }
    protected abstract void DbCreateConnection();
    public abstract DbDataAdapter DbCreateDataAdapter(string sql);
    public abstract DbDataAdapter DbCreateDataAdapter(DbCommand cmd);
    public string LastSQL { get; set; }
    private bool IsOpen { get { return DbConnection != null && DbConnection.State == ConnectionState.Open; } }

    #region public string DbQuoted(string s)
    public string DbQuoted(string s)
    {
      if (!string.IsNullOrEmpty(s))
      { return string.Format("'{0}'", s.Replace("'", "''")); }
      else
      { return "''"; }
    }
    #endregion

    public string DbVarchar(string s, int size) 
    {
      if (string.IsNullOrEmpty(s) || s.Length <= size)
      { return s; }

      return s.Substring(0, size);
    }

    public Conversion DbGet(string sql, DbTransaction Transaction = null) 
    {
      return new Conversion(DbGetValue(sql, Transaction));
    }

    #region public object DbGetValue(string sql, DbTransaction Transaction = null)
    /// <summary>
    /// Função que retorna um valor simples do banco de dados 
    /// </summary>
    public object DbGetValue(string sql, DbTransaction Transaction = null)
    {
      while (Transaction == null && IsOpen)
      { System.Threading.Thread.Sleep(20); }

      LastSQL = sql;

      lock (ObjLock)
      {
        DbDataReader dataReader = null;
        DbCommand cmd = null;

        try
        {
          if (Transaction == null)
          { DbConnection.Open(); }

          cmd = DbConnection.CreateCommand();
          cmd.CommandText = sql;

          if (Transaction != null)
          { cmd.Transaction = Transaction; }

          dataReader = cmd.ExecuteReader();

          if (dataReader.HasRows)
          {
            dataReader.Read();
            return dataReader.GetValue(0);
          }
        }
        catch (Exception ex)
        { throw new Exception(string.Format("Não foi possível executar a sql de consulta!\nSQL:{0}", sql), ex); }
        finally
        {
          if (dataReader != null)
          {
            dataReader.Close();
            dataReader.Dispose();
            dataReader = null;
          }

          if (cmd != null)
          {
            cmd.Dispose();
            cmd = null;
          }

          if (Transaction == null)
          { DbConnection.Close(); }
        }
        return null;
      }
    }
    #endregion

    #region public DataTable DbGetDataTable(DbConnection Conexao, string sql)
    /// <summary>
    /// Função que retorna um DataTable com um conjunto de dados do banco
    /// </summary>
    public DataTable DbGetDataTable(string sql, System.Data.Common.DbTransaction Transaction = null)
    {
      while (Transaction == null && IsOpen)
      { System.Threading.Thread.Sleep(20); }

      LastSQL = sql;

      lock (ObjLock)
      {
        DbDataAdapter da = null;

        try
        {
          DbCommand cmd = DbConnection.CreateCommand();
          cmd.CommandText = sql;
          cmd.Transaction = Transaction;
          da = DbCreateDataAdapter(cmd);
          
          DataTable tb = new DataTable();
          da.Fill(tb);
          return tb;
        }
        catch (Exception ex)
        {          
          throw new Exception("Erro ao executar a sql : " + sql, ex);
        }
        finally
       {
          if (da != null)
          {
            da.Dispose();
            da = null;
          }
        }
      }
    }
    #endregion

    #region public bool DbExecute(string sql, DbTransaction Transaction = null, bool IsLogTable = false)
    /// <summary>
    /// Função que executa uma instrução SQL no banco de dados
    /// </summary>
    public bool DbExecute(string sql, DbTransaction Transaction = null, bool IsLogTable = false)
    {
      while (Transaction == null && IsOpen)
      { System.Threading.Thread.Sleep(20); }

      LastSQL = sql;

      lock (ObjLock)
      {
        DbCommand cmd = null;

        try
        {
          if (Transaction == null && DbConnection.State != ConnectionState.Open)
          { DbConnection.Open(); }

          cmd = DbConnection.CreateCommand();
          cmd.CommandText = sql;

          if (Transaction != null)
          { cmd.Transaction = Transaction; }

          ExecutedCommands = cmd.ExecuteNonQuery();
          return true;
        }
        catch (Exception ex)
        {
          if (!IsLogTable)
          { throw new Exception(string.Format("Não foi possível gravar a aaTag no banco de dados.\nSQL:{0}", sql), ex); }
          return false;
        }
        finally
        {
          if (cmd != null)
          {
            cmd.Dispose();
            cmd = null;
          }

          if (Transaction == null)
          { DbConnection.Close(); }
        }
      }
    }
    #endregion

    #region public int ReturnLastID(System.Data.Common.DbTransaction transaction)
    public Conversion ReturnLastID(System.Data.Common.DbTransaction transaction)
    {
      return DbGet(DbReturnLastID, transaction);
    }
    #endregion

    public DataTable GetSchema(string CollectionName)
    {
      bool CnnOpen = this.DbConnection != null && this.DbConnection.State == ConnectionState.Open;

      try
      {
        if (!CnnOpen)
        { this.DbConnection.Open(); }

        DataTable dt = null;

        //if (CollectionName == "Views" && dbType == enmConnection.Odbc)
        //{ return new DataTable(); }

        dt = this.DbConnection.GetSchema();

        if (string.IsNullOrEmpty(CollectionName))
        { return dt; }

        bool PossuiCollectionName = false;
        for (int i = 0; i < dt.Rows.Count; i++)
        {
          if (dt.Rows[i][0].ToString() == CollectionName)
          {
            PossuiCollectionName = true;
            break;
          }
        }

        if (PossuiCollectionName)
        {
          dt = this.DbConnection.GetSchema(CollectionName);
        }
        else
        { dt = new DataTable(); }

        //if (dt.Rows.Count == 0 && CollectionName.ToUpper()=="TABLES" && dbType == enmConnection.MySql)
        //{ dt = GetDataTable("show tables"); }

        return dt;
      }
      catch { return null; }
      finally
      {
        if (!CnnOpen)
        { this.DbConnection.Close(); }
      }
    }

    public string[] GetTables()
    {
      List<string> lst = new List<string>();
           
      try
      {
        System.Data.DataTable dt = this.GetSchema("Tables");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
          string Table_Name = dt.Rows[i]["TABLE_NAME"].ToString().ToUpper().Trim();
          if (Table_Name.IndexOf("$") == -1)
          { lst.Add(Table_Name); }
        }
      }
      catch { }

      return lst.ToArray();
    }

    public string[] GetViews()
    {
      List<string> lst = new List<string>();

      try
      {
        System.Data.DataTable dt = this.GetSchema("Views");

        string SearchField = "";
        for (int i = 0; i < dt.Columns.Count; i++)
        {
          if (dt.Columns[i].ColumnName == "VIEW_NAME")
          {
            SearchField = "VIEW_NAME";
            break;
          }

          if (dt.Columns[i].ColumnName == "TABLE_NAME")
          {
            SearchField = "TABLE_NAME";
            break;
          }
        }

        if (!string.IsNullOrEmpty(SearchField))
        {
          for (int i = 0; i < dt.Rows.Count; i++)
          {
            string Table_Name = dt.Rows[i]["TABLE_NAME"].ToString().ToUpper().Trim();
            if (Table_Name.IndexOf("$") == -1)
            { lst.Add(Table_Name); }
          }
        }
      }
      catch { }

      return lst.ToArray();
    }
  }
}
