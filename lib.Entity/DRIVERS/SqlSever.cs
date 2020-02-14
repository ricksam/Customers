using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lib.Entity
{
  public class SqlServer : DbBase
  {
    public SqlServer(string ConnectionString)
      : base(ConnectionString)
    {
      DbCreateConnection();
    }

    protected override void DbCreateConnection()
    {
      try
      {
        this.DbFormatDate = "set dateformat ymd";
        this.DbReturnLastID = "select @@identity";
        this.DbWithNolock = "WITH(NOLOCK)";
        //this.DbWithNolock = "";
        this.DbConnection = new System.Data.SqlClient.SqlConnection(ConnectionString);
      }
      catch (Exception ex)
      { throw new Exception("Erro ao criar a conexão com o SQL Server", ex); }
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(string sql)
    {
      return new System.Data.SqlClient.SqlDataAdapter(sql, (System.Data.SqlClient.SqlConnection)this.DbConnection);
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(System.Data.Common.DbCommand cmd)
    {
      return new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)cmd);
    }

  }
}