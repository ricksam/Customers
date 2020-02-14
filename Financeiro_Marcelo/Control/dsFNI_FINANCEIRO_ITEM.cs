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
  public partial class dsFNI_FINANCEIRO_ITEM : DefaultDataSource<FNI_FINANCEIRO_ITEM>
  {
    public dsFNI_FINANCEIRO_ITEM(Connection cnn)
      : base(cnn)
    { }

    public FNI_FINANCEIRO_ITEM Get(int id)
    {
      return Get("select * from FNI_FINANCEIRO_ITEM where FNI_CODIGO = " + id.ToString());
    }

    public bool Save(FNI_FINANCEIRO_ITEM Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "FNI_FINANCEIRO_ITEM";
      this.sb.AddField("FNI_FIN_CODIGO", Tab.FNI_FIN_CODIGO);
      this.sb.AddField("FNI_DESCRICAO", Tab.FNI_DESCRICAO, 60);
      this.sb.AddField("FNI_QTDE", Tab.FNI_QTDE);
      this.sb.AddField("FNI_VALOR_TOTAL", Tab.FNI_VALOR_TOTAL);
      this.sb.AddField("FNI_VALOR_UNITARIO", Tab.FNI_VALOR_UNITARIO);
      this.sb.AddField("FNI_EXPRESSAO", Tab.FNI_EXPRESSAO, 60);

      bool Gravou = false;
      if (Tab.FNI_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.FNI_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where FNI_CODIGO = " + Tab.FNI_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int FNI_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "FNI_FINANCEIRO_ITEM";
      return this.cnn.Exec(this.sb.getDelete("where FNI_CODIGO = " + FNI_CODIGO));
    }
  }
}
