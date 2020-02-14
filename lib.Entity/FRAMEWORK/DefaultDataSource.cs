using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using lib.Class;

namespace lib.Entity
{
  public abstract class DefaultDataSource<T> where T : DefaultEntity
  {
    public DefaultDataSource(DbBase DbBase)
    {
      this.cnv = new lib.Class.Conversion();
      this.DbBase = DbBase;
    }

    protected DbBase DbBase { get; set; }
    protected DbConnection DbConnection { get { return DbBase.DbConnection; } }    
    protected virtual void OnFillItem<T>(T Tab) { }
    //protected virtual void OnFillItem(T Tab) { }
    protected lib.Class.Conversion cnv { get; set; }
    
    public void FillObject(DataTable dt, int Row, object Obj)
    {
      lib.Class.Reflection oa = new lib.Class.Reflection(Obj);
      for (int i = 0; i < dt.Columns.Count; i++)
      {
        string ColName = dt.Columns[i].ColumnName;
        oa.SetAttibute(ColName, dt.Rows[Row][ColName].ToString());
      }
    }

    public void FillObject(DataRow dr, object Obj)
    {
      lib.Class.Reflection oa = new lib.Class.Reflection(Obj);
      for (int i = 0; i < dr.Table.Columns.Count; i++)
      {
        string ColName = dr.Table.Columns[i].ColumnName;
        oa.SetAttibute(ColName, dr[ColName].ToString());
      }
    }
    
    protected string DbQuoted(string s) 
    {
      return DbBase.DbQuoted(s);
    }

    protected T Get(string Sql, System.Data.Common.DbTransaction transaction = null)
    {
      T[] lst = List<T>(Sql, transaction);
      if (lst.Length != 0)
      { return lst[0]; }
      else
      { return Activator.CreateInstance<T>(); }
    }
    
    protected T Get<T>(string Sql,System.Data.Common.DbTransaction transaction = null)
    {
      T[] lst = List<T>(Sql, transaction);
      if (lst.Length != 0)
      { return lst[0]; }
      else
      { return Activator.CreateInstance<T>(); }
    }
    
    /*protected T[] List(string Sql,System.Data.Common.DbTransaction transaction = null)
    {
      DataTable dt = DbBase.DbGetDataTable(Sql, transaction);
      T[] lst = new T[dt.Rows.Count];
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        T Tab = Activator.CreateInstance<T>();
        FillObject(dt, i, Tab);
        OnFillItem(Tab);
        lst[i] = Tab;
      }
      return lst;
    }*/

    protected T[] List(string Sql, System.Data.Common.DbTransaction transaction = null)
    {
      DataTable dt = DbBase.DbGetDataTable(Sql, transaction);
      T[] lst = new T[dt.Rows.Count];
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        T Tab = Activator.CreateInstance<T>();
        FillObject(dt, i, Tab);
        OnFillItem<T>(Tab);
        lst[i] = Tab;
      }
      return lst;
    }

    protected T[] List<T>(string Sql, System.Data.Common.DbTransaction transaction = null)
    {
      DataTable dt = DbBase.DbGetDataTable(Sql, transaction);
      T[] lst = new T[dt.Rows.Count];
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        T Tab = Activator.CreateInstance<T>();
        FillObject(dt, i, Tab);
        OnFillItem<T>(Tab);
        lst[i] = Tab;
      }
      return lst;
    }
    
    public T[] List(System.Data.Common.DbTransaction transaction = null)
    {
      return List<T>(string.Format("select * from {0} {1}", typeof(T).Name, DbBase.DbWithNolock), transaction);
    }
    
    private string GetDbValue(Reflection r, string fieldName, bool IsSelect)
    {
      string value = "";
      Type tp = r.GetAttributeType(fieldName);

      if (tp == typeof(string))
      {
        if (IsSelect)
        { value = string.Format("{0}", DbQuoted("%" + r.GetAttribute(fieldName).ToString() + "%")); }
        else
        { value = string.Format("{0}", DbQuoted(r.GetAttribute(fieldName).ToString())); }
      }
      else if (tp == typeof(DateTime))
      { value = string.Format("'{0}'", cnv.ToDateTime(r.GetAttribute(fieldName)).ToString("yyyy-MM-dd HH:mm:ss")); }
      else if (tp == typeof(bool))
      { value = Convert.ToBoolean(r.GetAttribute(fieldName)) ? "1" : "0"; }
      else if (tp == typeof(decimal) || tp == typeof(double) || tp == typeof(float))
      { value = cnv.ToDecimal(r.GetAttribute(fieldName)).ToString("0.00").Replace(",", "."); }
      else if (tp == typeof(int) || tp == typeof(long))
      { value = r.GetAttribute(fieldName).ToString(); }
      else
      { value = r.GetAttribute(fieldName).ToString(); }
      return value;
    }
    
    private string Condition(T values)
    {
      if (values == null)
      { return ""; }

      lib.Class.Reflection r = new lib.Class.Reflection(values);
      string where = "";
      string[] atr = r.GetAttributes(true);

      for (int i = 0; i < atr.Length; i++)
      {
        Type tp = r.GetAttributeType(atr[i]);
        string signal = (tp == typeof(string) ? "like" : "=");
        string value = GetDbValue(r, atr[i], true);
        where += string.Format("{0} {1} {2}", atr[i], signal, value) + (i == (atr.Length - 1) ? " " : " and ");
      }

      return string.Format("where {0}", where);
    }
    
    public T GetFirstOrDefault(T Conditions, System.Data.Common.DbTransaction transaction = null)
    {
      T[] list = Select(Conditions, transaction);
      if (list.Length != 0)
      { return list[0]; }
      else
      { return Activator.CreateInstance<T>(); }
    }
    
    public T[] Select(T Conditions, System.Data.Common.DbTransaction transaction = null)
    {
      return List<T>(string.Format("{0} select * from {1} {2} {3}", DbBase.DbFormatDate, typeof(T).Name, DbBase.DbWithNolock, Condition(Conditions)), transaction);
    }

    private bool ShoudOmitField(string[] OmitFields, string Field) 
    {
      if (OmitFields == null)
      { return false; }

      for (int i = 0; i < OmitFields.Length; i++)
      {
        if (Field == OmitFields[i])
        { return true; }
      }

      return false;
    }

    public void Insert(T entity, DbTransaction Transaction = null, bool OmitDefaultFields = true, string[] OmitFields = null)
    {
      Reflection r = new Reflection(entity);
      string[] atr = r.GetAttributes(OmitDefaultFields);

      if (atr.Length == 0)
      { return; }

      string fields = "";
      for (int i = 0; i < atr.Length; i++)
      {
        if (!ShoudOmitField(OmitFields, atr[i]))
        { fields += string.Format("{0}{1}", atr[i], i != (atr.Length - 1) ? "," : ""); }
      }

      string values = "";
      for (int i = 0; i < atr.Length; i++)
      {
        if (!ShoudOmitField(OmitFields, atr[i]))
        { values += string.Format("{0}{1}", GetDbValue(r, atr[i], false), i != (atr.Length - 1) ? "," : ""); }
      }

      DbBase.DbExecute(
        string.Format("{0} insert into {1} ({2}) values ({3});", DbBase.DbFormatDate, typeof(T).Name, fields, values),
        Transaction);
    }

    private bool IsInCondition(string FieldName, string[] FieldsCondition)
    {
      if (FieldsCondition == null || FieldsCondition.Length == 0)
      { return false; }

      for (int i = 0; i < FieldsCondition.Length; i++)
      {
        if (FieldName == FieldsCondition[i])
        { return true; }
      }
      return false;
    }

    public void Update(T entity, T Conditions, DbTransaction Transaction = null, bool OmitDefaultFields = false)
    {
      Reflection r = new Reflection(entity);
      string[] atr = r.GetAttributes(OmitDefaultFields);

      if (atr.Length == 0)
      { return; }

      string[] FieldsConditions = new string[] { };
      if (Conditions != null)
      { FieldsConditions = (new Reflection(Conditions)).GetAttributes(true); }

      string fields_values = "";
      for (int i = 0; i < atr.Length; i++)
      {
        if (!IsInCondition(atr[i], FieldsConditions))
        {
          if (!r.IsDefaultValue(atr[i]))
          { fields_values += string.Format("{0}={1}{2}", atr[i], GetDbValue(r, atr[i], false), i != (atr.Length - 1) ? "," : ""); }
          else
          {
            Type tp = r.GetAttributeType(atr[i]);

            if (
              tp == typeof(byte) || tp == typeof(sbyte) || tp == typeof(bool) ||
              tp == typeof(int) || tp == typeof(uint) || tp == typeof(long) || tp == typeof(ulong) ||
              tp == typeof(double) || tp == typeof(float) || tp == typeof(decimal))
            { fields_values += string.Format("{0}= 0", atr[i]); }
            else
            { fields_values += string.Format("{0}= null", atr[i]); }

            fields_values += i != (atr.Length - 1) ? "," : "";
          }
        }
      }

      if (!string.IsNullOrEmpty(fields_values) && fields_values[fields_values.Length - 1] == ',')
      {
          fields_values = fields_values.Remove(fields_values.Length - 1, 1);
      }

      DbBase.DbExecute(
        string.Format("{0} update {1} set {2} {3}", DbBase.DbFormatDate, typeof(T).Name, fields_values, Condition(Conditions)),
        Transaction);
    }
    
    public void RemoveAllData(DbTransaction Transaction = null)
    {
      DbBase.DbExecute(string.Format("delete from {0}", typeof(T).Name), Transaction);
    }
    
    public int Count(DbTransaction Transaction = null)
    {
      try
      {
        return Convert.ToInt32(DbBase.DbGetValue(string.Format( "SELECT COUNT(*) FROM {0} {1}", typeof(T).Name, DbBase.DbWithNolock), Transaction));
      }
      catch { return 0; }
    }
    
    public void Remove(T Conditions, DbTransaction Transaction = null)
    {
      DbBase.DbExecute(string.Format("{0} delete from {1} {2}", DbBase.DbFormatDate, typeof(T).Name, Condition(Conditions)), Transaction);
    }
    
    protected string SetMaxLength(string s, int l)
    {
      if (string.IsNullOrEmpty(s))
      { return ""; }

      if (s.Length > l)
      { s = s.Substring(0, l); }

      return s;
    }

    public Conversion ReturnLastID(System.Data.Common.DbTransaction transaction)
    {
      return DbBase.ReturnLastID(transaction);
    }

    public virtual LockedField[] CheckField(T Fields)
    { return new LockedField[] { }; }
  }
}
