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
  public partial class dsTAL_TALAO_CHEQUE : DefaultDataSource<TAL_TALAO_CHEQUE>
  {
    public dsTAL_TALAO_CHEQUE(Connection cnn)
      : base(cnn)
    { }

    public TAL_TALAO_CHEQUE Get(int id)
    {
      return Get("select * from TAL_TALAO_CHEQUE where TAL_CODIGO = " + id.ToString());
    }

    public bool Save(TAL_TALAO_CHEQUE Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "TAL_TALAO_CHEQUE";
      this.sb.AddField("TAL_EMP_CODIGO", Tab.TAL_EMP_CODIGO);
      this.sb.AddField("TAL_CCN_CODIGO", Tab.TAL_CCN_CODIGO);
      this.sb.AddField("TAL_INICIO", Tab.TAL_INICIO);
      this.sb.AddField("TAL_FIM", Tab.TAL_FIM);
      this.sb.AddField("TAL_ATUAL", Tab.TAL_ATUAL);

      bool Gravou = false;
      if (Tab.TAL_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.TAL_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where TAL_CODIGO = " + Tab.TAL_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int TAL_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "TAL_TALAO_CHEQUE";
      return this.cnn.Exec(this.sb.getDelete("where TAL_CODIGO = " + TAL_CODIGO));
    }
  }
}
