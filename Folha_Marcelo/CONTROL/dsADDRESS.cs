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
  public partial class dsADDRESS : DefaultDataSource<ADDRESS>
  {
    public dsADDRESS(Connection cnn)
      : base(cnn)
    { }

    public ADDRESS Get(int id)
    {
      return Get("select * from ADDRESS where ID = " + id.ToString());
    }

    public ADDRESS[] GetList_FromZIPCODE(string ZIPCODE) 
    {
      cnn.QueryParam.Add(ZIPCODE);
      return GetList("SELECT * FROM ADDRESS WHERE ZIPCODE = {0}", 0);
    }

    public bool Save(ADDRESS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "ADDRESS";
      this.sb.AddField("ZIPCODE", Tab.ZIPCODE, 8);
      this.sb.AddField("NAME", Tab.NAME, 100);
      this.sb.AddField("NEIGHBORHOOD", Tab.NEIGHBORHOOD, 100);
      this.sb.AddField("CITY", Tab.CITY, 100);
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
      this.sb.Table = "ADDRESS";
      return this.cnn.Exec(this.sb.getDelete("where ID = " + ID));
    }
  }
}
