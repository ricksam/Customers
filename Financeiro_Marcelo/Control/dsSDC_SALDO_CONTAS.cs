using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class dsSDC_SALDO_CONTAS : DefaultDataSource<SDC_SALDO_CONTAS>
  {
    public dsSDC_SALDO_CONTAS(Connection cnn)
      : base(cnn)
    { }

    public SDC_SALDO_CONTAS Get(int id)
    {
      return Get("select * from SDC_SALDO_CONTAS where SDC_CODIGO = " + id.ToString());
    }

    public bool Save(SDC_SALDO_CONTAS Tab)
    {
      //bool StartInTransaction = this.cnn.InTransaction();

      //if (!StartInTransaction)
      //{ this.cnn.BeginTransaction(); }

      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "SDC_SALDO_CONTAS";

      if (Tab.SDC_ANTERIOR_CODIGO != 0)
      { this.sb.AddField("SDC_ANTERIOR_CODIGO", Tab.SDC_ANTERIOR_CODIGO); }

      this.sb.AddField("SDC_CCN_CODIGO", Tab.SDC_CCN_CODIGO);
      this.sb.AddField("SDC_DATA", Tab.SDC_DATA, enmFieldType.DateTime);
      this.sb.AddField("SDC_OPERACAO", Tab.SDC_OPERACAO, 60);
      this.sb.AddField("SDC_VALOR_LANCADO", Tab.SDC_VALOR_LANCADO);
      this.sb.AddField("SDC_SALDO_ATUAL", Tab.SDC_SALDO_ATUAL);
      this.sb.AddField("SDC_TIPO", Tab.SDC_TIPO);

      bool Gravou = false;
      if (Tab.SDC_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.SDC_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where SDC_CODIGO = " + Tab.SDC_CODIGO)); }

      //if (!StartInTransaction)
      //{ this.cnn.CommitTransaction(); }

      return Gravou;
    }

    public bool Remove(int SDC_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "SDC_SALDO_CONTAS";
      return this.cnn.Exec(this.sb.getDelete("where SDC_CODIGO = " + SDC_CODIGO));
    }
  }
}
