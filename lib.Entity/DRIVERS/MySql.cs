using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace lib.Entity
{
  public class MySQL : DbBase
  {
    public MySQL(string ConnectionString)
      : base(ConnectionString)
    {
      //DbCreateConnection();
      //DbReturnLastID = "select last_insert_id()";

      DbCreateConnection();
    }

    protected override void DbCreateConnection()
    {
      try
      {
        this.DbFormatDate = "";
        this.DbReturnLastID = "select last_insert_id()";
        this.DbWithNolock = "";

        this.DbConnection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
      }
      catch (Exception ex)
      { throw new Exception("Erro ao criar a conexão com o SQL Server", ex); }
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(string sql)
    {
      return new MySql.Data.MySqlClient.MySqlDataAdapter(sql, (MySql.Data.MySqlClient.MySqlConnection)this.DbConnection);
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(System.Data.Common.DbCommand cmd)
    {
      return new MySql.Data.MySqlClient.MySqlDataAdapter((MySql.Data.MySqlClient.MySqlCommand)cmd);
    }
  }
}