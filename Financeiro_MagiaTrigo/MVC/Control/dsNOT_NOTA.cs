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
  public partial class dsNOT_NOTA : DefaultDataSource<NOT_NOTA>
  {
    public dsNOT_NOTA(Connection cnn)
      : base(cnn)
    { }

    public NOT_NOTA Get(int id)
    {
      return Get("select * from NOT_NOTA where NOT_CODIGO = " + id.ToString());
    }

    public bool Save(NOT_NOTA Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "NOT_NOTA";
      this.sb.AddField("NOT_OPR_CODIGO", Tab.NOT_OPR_CODIGO);
      this.sb.AddField("NOT_DOCUMENTO", Tab.NOT_DOCUMENTO);
      this.sb.AddField("NOT_ENTRADA", Tab.NOT_ENTRADA, enmFieldType.Date);
      this.sb.AddField("NOT_EMISSAO", Tab.NOT_EMISSAO, enmFieldType.Date);

      bool Gravou = false;
      if (Tab.NOT_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.NOT_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where NOT_CODIGO = " + Tab.NOT_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int NOT_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "NOT_NOTA";
      return this.cnn.Exec(this.sb.getDelete("where NOT_CODIGO = " + NOT_CODIGO));
    }
  }
}
