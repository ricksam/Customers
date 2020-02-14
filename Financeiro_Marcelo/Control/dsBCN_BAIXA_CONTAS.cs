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
  public partial class dsBCN_BAIXA_CONTAS : DefaultDataSource<BCN_BAIXA_CONTAS>
  {
    public dsBCN_BAIXA_CONTAS(Connection cnn)
      : base(cnn)
    { }

    public BCN_BAIXA_CONTAS Get(int id)
    {
      return Get("select * from BCN_BAIXA_CONTAS where BCN_CODIGO = " + id.ToString());
    }
    
    public bool Save(BCN_BAIXA_CONTAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "BCN_BAIXA_CONTAS";

      if (Tab.BCN_CCN_CODIGO != 0)
      { this.sb.AddField("BCN_CCN_CODIGO", Tab.BCN_CCN_CODIGO); }

      this.sb.AddField("BCN_EMP_CODIGO", Tab.BCN_EMP_CODIGO);
      this.sb.AddField("BCN_NUMERO_CHEQUE", Tab.BCN_NUMERO_CHEQUE, 20);
      this.sb.AddField("BCN_VALOR", Tab.BCN_VALOR);
      this.sb.AddField("BCN_DATA_PGTO", Tab.BCN_DATA_PGTO, enmFieldType.Date);
      this.sb.AddField("BCN_COMPENSADO", Tab.BCN_COMPENSADO);
      this.sb.AddField("BCN_TIPO_CHEQUE", Tab.BCN_TIPO_CHEQUE);
      this.sb.AddField("BCN_DESCRICAO", Tab.BCN_DESCRICAO, 200);

      if (Tab.BCN_COMPENSADO)
      { this.sb.AddField("BCN_DATA_COMPENSACAO", Tab.BCN_DATA_COMPENSACAO, enmFieldType.Date); }

      bool Gravou = false;
      if (Tab.BCN_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.BCN_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where BCN_CODIGO = " + Tab.BCN_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int BCN_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "BCN_BAIXA_CONTAS";
      return this.cnn.Exec(this.sb.getDelete("where BCN_CODIGO = " + BCN_CODIGO));
    }
  }
}
