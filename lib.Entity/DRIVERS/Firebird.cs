using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace lib.Entity
{
  public class Firebird : DbBase
  {
    public Firebird(string ConnectionString)
      : base(ConnectionString)
    {
      DbCreateConnection();
    }

    protected override void DbCreateConnection()
    {
      try
      {
        this.DbFormatDate = "";
        this.DbConnection = new FbConnection(ConnectionString);
      }
      catch (Exception ex)
      { throw new Exception("Erro ao criar a conexão com o driver Fb", ex); }
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(string sql)
    {
      return new FbDataAdapter(sql, (FbConnection)this.DbConnection);
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(System.Data.Common.DbCommand cmd)
    {
      return new FbDataAdapter((FbCommand)cmd);
    }

  }
}
