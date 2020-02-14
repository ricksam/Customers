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
      this.sb.Table = "FIN_FINANCEIRO";

      if (Tab.FIN_FRM_CODIGO != 0)
      { this.sb.AddField("FIN_FRM_CODIGO", Tab.FIN_FRM_CODIGO); }

      if (Tab.FIN_DATA_PGTO != DateTime.MinValue)
      { this.sb.AddField("FIN_DATA_PGTO", Tab.FIN_DATA_PGTO, enmFieldType.Date); }

      this.sb.AddField("FIN_CAT_CODIGO", Tab.FIN_CAT_CODIGO);
      this.sb.AddField("FIN_PLN_CODIGO", Tab.FIN_PLN_CODIGO);
      this.sb.AddField("FIN_EMP_CODIGO", Tab.FIN_EMP_CODIGO);
      this.sb.AddField("FIN_DESCRICAO", Tab.FIN_DESCRICAO, 200);
      this.sb.AddField("FIN_VALOR", Tab.FIN_VALOR);
      this.sb.AddField("FIN_VALOR_NOTA", Tab.FIN_VALOR_NOTA);
      this.sb.AddField("FIN_DATA", Tab.FIN_DATA, enmFieldType.Date);
      this.sb.AddField("FIN_EMISSAO", Tab.FIN_EMISSAO, enmFieldType.Date);            
      this.sb.AddField("FIN_HORA", Tab.FIN_HORA, 5);

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
