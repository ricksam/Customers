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
  public partial class dsLNC_LANC_CARTOES : DefaultDataSource<LNC_LANC_CARTOES>
  {
    public dsLNC_LANC_CARTOES(Connection cnn)
      : base(cnn)
    { }

    public LNC_LANC_CARTOES Get(int id)
    {
      return Get("select * from LNC_LANC_CARTOES where LNC_CODIGO = " + id.ToString());
    }

    public bool Save(LNC_LANC_CARTOES Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "LNC_LANC_CARTOES";

      if (Tab.LNC_DATA_PGTO != DateTime.MinValue)
      { this.sb.AddField("LNC_DATA_PGTO", Tab.LNC_DATA_PGTO, enmFieldType.Date); }
      else
      { this.sb.AddField("LNC_DATA_PGTO", null); }

      if (Tab.LNC_CRT_CODIGO != 0)
      { this.sb.AddField("LNC_CRT_CODIGO", Tab.LNC_CRT_CODIGO); }
      else
      { this.sb.AddField("LNC_CRT_CODIGO", null); }

      if (Tab.LNC_CCN_CODIGO != 0)
      { this.sb.AddField("LNC_CCN_CODIGO", Tab.LNC_CCN_CODIGO); }
      else
      { this.sb.AddField("LNC_CCN_CODIGO", null); }

      this.sb.AddField("LNC_EMISSAO", Tab.LNC_EMISSAO, enmFieldType.Date);
      this.sb.AddField("LNC_VENCIMENTO", Tab.LNC_VENCIMENTO, enmFieldType.Date);      
      this.sb.AddField("LNC_VALOR", Tab.LNC_VALOR);
      this.sb.AddField("LNC_VALOR_TAXA", Tab.LNC_VALOR_TAXA);
      this.sb.AddField("LNC_VALOR_RECEBER", Tab.LNC_VALOR_RECEBER);

      bool Gravou = false;
      if (Tab.LNC_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.LNC_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where LNC_CODIGO = " + Tab.LNC_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int LNC_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "LNC_LANC_CARTOES";
      return this.cnn.Exec(this.sb.getDelete("where LNC_CODIGO = " + LNC_CODIGO));
    }
  }
}
