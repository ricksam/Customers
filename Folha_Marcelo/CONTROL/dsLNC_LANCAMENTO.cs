using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class dsLNC_LANCAMENTO : DefaultDataSource<LNC_LANCAMENTO>
  {
    public dsLNC_LANCAMENTO(Connection cnn)
      : base(cnn)
    { }

    public LNC_LANCAMENTO Get(int id)
    {
      return Get("select * from LNC_LANCAMENTO where LNC_CODIGO = " + id.ToString());
    }

    public bool Save(LNC_LANCAMENTO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "LNC_LANCAMENTO";
      this.sb.AddField("LNC_OPR_CODIGO", Tab.LNC_OPR_CODIGO);
      this.sb.AddField("LNC_CLB_CODIGO", Tab.LNC_CLB_CODIGO);
      this.sb.AddField("LNC_EMP_CODIGO", Tab.LNC_EMP_CODIGO);
      this.sb.AddField("LNC_MES", Tab.LNC_MES);
      this.sb.AddField("LNC_ANO", Tab.LNC_ANO);
      this.sb.AddField("LNC_REFERENCIA", Tab.LNC_REFERENCIA);
      this.sb.AddField("LNC_VALOR", Tab.LNC_VALOR);

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
      this.sb.Table = "LNC_LANCAMENTO";
      return this.cnn.Exec(this.sb.getDelete("where LNC_CODIGO = " + LNC_CODIGO));
    }
  }
}
