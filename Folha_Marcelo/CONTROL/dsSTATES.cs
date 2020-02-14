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
  public partial class dsSTATES : DefaultDataSource<STATES>
  {
    public dsSTATES(Connection cnn)
      : base(cnn)
    { }

    public STATES Get(int id)
    {
      return Get("select * from STATES where ID = " + id.ToString());
    }

    public bool Save(STATES Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "STATES";
      this.sb.AddField("STATE", Tab.STATE, 2);

      bool Gravou = false;
      if (Tab.ID == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.ID = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where ID = " + Tab.ID)); }

      return Gravou;
    }

    public bool Remove(int ID)
    {
      this.sb.Clear();
      this.sb.Table = "STATES";
      return this.cnn.Exec(this.sb.getDelete("where ID = " + ID));
    }
  }
}
