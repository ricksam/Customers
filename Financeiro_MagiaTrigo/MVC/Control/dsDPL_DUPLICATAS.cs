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
  public partial class dsDPL_DUPLICATAS : DefaultDataSource<DPL_DUPLICATAS>
  {
    public dsDPL_DUPLICATAS(Connection cnn)
      : base(cnn)
    { }

    public DPL_DUPLICATAS Get(int id)
    {
      return Get("select * from DPL_DUPLICATAS where DPL_CODIGO = " + id.ToString());
    }

    public bool Save(DPL_DUPLICATAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "DPL_DUPLICATAS";
      this.sb.AddField("DPL_NOT_CODIGO", Tab.DPL_NOT_CODIGO);
      this.sb.AddField("DPL_FIN_CODIGO", Tab.DPL_FIN_CODIGO);

      bool Gravou = false;
      if (Tab.DPL_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.DPL_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where DPL_CODIGO = " + Tab.DPL_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int DPL_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "DPL_DUPLICATAS";
      return this.cnn.Exec(this.sb.getDelete("where DPL_CODIGO = " + DPL_CODIGO));
    }
  }
}
