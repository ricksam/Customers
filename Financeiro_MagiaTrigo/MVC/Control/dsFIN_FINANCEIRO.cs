using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class dsFIN_FINANCEIRO : DefaultDataSource<FIN_FINANCEIRO>
  {
    public dsFIN_FINANCEIRO(Connection cnn)
      : base(cnn)
    { }

    public FIN_FINANCEIRO Get(int id)
    {
      return Get("select * from FIN_FINANCEIRO where FIN_CODIGO = " + id.ToString());
    }

    public bool Save(FIN_FINANCEIRO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();

      if (Tab.FIN_DTPGTO != DateTime.MinValue)
      { this.sb.AddField("FIN_DTPGTO", Tab.FIN_DTPGTO, enmFieldType.Date); }
      else
      { this.sb.AddField("FIN_DTPGTO", null); }

      if (Tab.FIN_CON_CODIGO != 0)
      { this.sb.AddField("FIN_CON_CODIGO", Tab.FIN_CON_CODIGO); }

      this.sb.Table = "FIN_FINANCEIRO";
      this.sb.AddField("FIN_PLN_CODIGO", Tab.FIN_PLN_CODIGO);
      this.sb.AddField("FIN_DOCUMENTO", Tab.FIN_DOCUMENTO, 20);
      this.sb.AddField("FIN_DESCRICAO", Tab.FIN_DESCRICAO, 60);
      this.sb.AddField("FIN_EMISSAO", Tab.FIN_EMISSAO, enmFieldType.Date);
      this.sb.AddField("FIN_VENCIMENTO", Tab.FIN_VENCIMENTO, enmFieldType.Date);
      this.sb.AddField("FIN_VALOR", Tab.FIN_VALOR);

      bool Gravou = false;
      if (Tab.FIN_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.FIN_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where FIN_CODIGO = " + Tab.FIN_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int FIN_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "FIN_FINANCEIRO";
      return this.cnn.Exec(this.sb.getDelete("where FIN_CODIGO = " + FIN_CODIGO));
    }
  }
}
