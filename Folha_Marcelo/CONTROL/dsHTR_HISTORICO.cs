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
  public partial class dsHTR_HISTORICO : DefaultDataSource<HTR_HISTORICO>
  {
    public dsHTR_HISTORICO(Connection cnn)
      : base(cnn)
    { }

    public HTR_HISTORICO Get(int id)
    {
      return Get("select * from HTR_HISTORICO where HTR_CODIGO = " + id.ToString());
    }

    public bool Save(HTR_HISTORICO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "HTR_HISTORICO";
      this.sb.AddField("HTR_EMP_CODIGO", Tab.HTR_EMP_CODIGO);
      this.sb.AddField("HTR_CLB_CODIGO", Tab.HTR_CLB_CODIGO);
      this.sb.AddField("HTR_OCR_CODIGO", Tab.HTR_OCR_CODIGO);
      this.sb.AddField("HTR_DATA", Tab.HTR_DATA, enmFieldType.DateTime);
      this.sb.AddField("HTR_OBSERVACAO", Tab.HTR_OBSERVACAO, 100);

      bool Gravou = false;
      if (Tab.HTR_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.HTR_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where HTR_CODIGO = " + Tab.HTR_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int HTR_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "HTR_HISTORICO";
      return this.cnn.Exec(this.sb.getDelete("where HTR_CODIGO = " + HTR_CODIGO));
    }
  }
}
