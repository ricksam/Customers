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
  public partial class dsVDA_VENDA : DefaultDataSource<VDA_VENDA>
  {
    public dsVDA_VENDA(Connection cnn)
      : base(cnn)
    { }

    public VDA_VENDA Get(int id)
    {
      return Get("select * from VDA_VENDA where VDA_CODIGO = " + id.ToString());
    }

    public bool Save(VDA_VENDA Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "VDA_VENDA";
      this.sb.AddField("VDA_FRM_CODIGO", Tab.VDA_FRM_CODIGO);
      this.sb.AddField("VDA_CNPJ", Tab.VDA_CNPJ, 20);
      this.sb.AddField("VDA_EMPRESA", Tab.VDA_EMPRESA, 60);
      this.sb.AddField("VDA_EMISSAO", Tab.VDA_EMISSAO, enmFieldType.Date);
      this.sb.AddField("VDA_INICIO", Tab.VDA_INICIO, 8);
      this.sb.AddField("VDA_COD_OPERADOR", Tab.VDA_COD_OPERADOR);
      this.sb.AddField("VDA_OPERADOR", Tab.VDA_OPERADOR, 60);
      this.sb.AddField("VDA_CUPONS", Tab.VDA_CUPONS);
      this.sb.AddField("VDA_TOTAL", Tab.VDA_TOTAL);

      bool Gravou = false;
      if (Tab.VDA_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.VDA_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where VDA_CODIGO = " + Tab.VDA_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int VDA_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "VDA_VENDA";
      return this.cnn.Exec(this.sb.getDelete("where VDA_CODIGO = " + VDA_CODIGO));
    }
  }
}
