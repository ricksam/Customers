﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lib.Entity
{
  public class Odbc : DbBase
  {
    public Odbc(string ConnectionString)
      : base(ConnectionString)
    {
      DbCreateConnection();
    }

    protected override void DbCreateConnection()
    {
      try
      {
        this.DbFormatDate = "";
        this.DbConnection = new System.Data.Odbc.OdbcConnection(ConnectionString);
      }
      catch (Exception ex)
      { throw new Exception("Erro ao criar a conexão com o driver Odbc", ex); }
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(string sql)
    {
      return new System.Data.Odbc.OdbcDataAdapter(sql, (System.Data.Odbc.OdbcConnection)this.DbConnection);
    }

    public override System.Data.Common.DbDataAdapter DbCreateDataAdapter(System.Data.Common.DbCommand cmd)
    {
      return new System.Data.Odbc.OdbcDataAdapter((System.Data.Odbc.OdbcCommand)cmd);
    }

  }
}
