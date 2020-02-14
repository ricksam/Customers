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
  public partial class dsALT_ALERTAS : DefaultDataSource<ALT_ALERTAS>
  {
    public dsALT_ALERTAS(Connection cnn)
      : base(cnn)
    { }

    public ALT_ALERTAS Get(int id)
    {
      return Get("select * from ALT_ALERTAS where ALT_CODIGO = " + id.ToString());
    }

    public bool Save(ALT_ALERTAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "ALT_ALERTAS";
      this.sb.AddField("ALT_EMP_CODIGO", Tab.ALT_EMP_CODIGO);
      this.sb.AddField("ALT_CLB_CODIGO", Tab.ALT_CLB_CODIGO);
      this.sb.AddField("ALT_HTR_CODIGO", Tab.ALT_HTR_CODIGO);
      this.sb.AddField("ALT_OCR_CODIGO", Tab.ALT_OCR_CODIGO);
      this.sb.AddField("ALT_DATA", Tab.ALT_DATA, enmFieldType.Date);
      this.sb.AddField("ALT_DATA_FINAL", Tab.ALT_DATA_FINAL, enmFieldType.Date);
      this.sb.AddField("ALT_MENSAGEM", Tab.ALT_MENSAGEM, 100);
      this.sb.AddField("ALT_INATIVO",Tab.ALT_INATIVO);

      bool Gravou = false;
      if (Tab.ALT_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.ALT_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where ALT_CODIGO = " + Tab.ALT_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int ALT_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "ALT_ALERTAS";
      return this.cnn.Exec(this.sb.getDelete("where ALT_CODIGO = " + ALT_CODIGO));
    }
  }
}
