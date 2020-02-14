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
  public partial class dsCPG_CONTAS_PAGAR : DefaultDataSource<CPG_CONTAS_PAGAR>
  {
    public dsCPG_CONTAS_PAGAR(Connection cnn)
      : base(cnn)
    { }

    public CPG_CONTAS_PAGAR Get(int id)
    {
      return Get("select * from CPG_CONTAS_PAGAR where CPG_CODIGO = " + id.ToString());
    }
    
    public bool Save(CPG_CONTAS_PAGAR Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CPG_CONTAS_PAGAR";

      if (Tab.CPG_BCN_CODIGO != 0)
      { this.sb.AddField("CPG_BCN_CODIGO", Tab.CPG_BCN_CODIGO); }

      if (Tab.CPG_FRN_CODIGO != 0)
      { this.sb.AddField("CPG_FRN_CODIGO", Tab.CPG_FRN_CODIGO); }

      this.sb.AddField("CPG_FIN_CODIGO", Tab.CPG_FIN_CODIGO);
      this.sb.AddField("CPG_EMP_CODIGO", Tab.CPG_EMP_CODIGO);
      this.sb.AddField("CPG_DOCUMENTO", Tab.CPG_DOCUMENTO, 20);
      this.sb.AddField("CPG_VENCIMENTO", Tab.CPG_VENCIMENTO, enmFieldType.Date);
      this.sb.AddField("CPG_SEL", Tab.CPG_SEL);
      this.sb.AddField("CPG_OFICIAL", Tab.CPG_OFICIAL);

      bool Gravou = false;
      if (Tab.CPG_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.CPG_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where CPG_CODIGO = " + Tab.CPG_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int CPG_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CPG_CONTAS_PAGAR";
      return this.cnn.Exec(this.sb.getDelete("where CPG_CODIGO = " + CPG_CODIGO));
    }
  }
}
