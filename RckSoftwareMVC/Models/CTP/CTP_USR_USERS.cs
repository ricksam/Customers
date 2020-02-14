using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace RckSoftwareMVC
{
  public partial class CTP_USR_USERS : DefaultEntity
  {
    public int USR_CODIGO { get; set; }
    public string USR_NOME { get; set; }
    public string USR_KEY { get; set; }
    public bool USR_INATIVO { get; set; }
  }

  public partial class dsCTP_USR_USERS : DefaultDataSource<CTP_USR_USERS>
  {
    public dsCTP_USR_USERS(Connection cnn)
      : base(cnn)
    { }

    public CTP_USR_USERS Get(int id)
    {
      return Get("select * from CTP_USR_USERS where USR_CODIGO = " + id.ToString());
    }

    public CTP_USR_USERS[] GetList_Ativos()
    {
      return GetList("select * from CTP_USR_USERS where USR_INATIVO = 0 or USR_INATIVO is null ", 0);
    }

    public CTP_USR_USERS[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");

      return GetList(
        @"SELECT * FROM CTP_USR_USERS
         WHERE 
           USR_NOME LIKE {0} 
           or USR_KEY LIKE {0} 
           or USR_INATIVO LIKE {0} 
         ", 200);
    }

    public override LockedField[] GetLockedFields(CTP_USR_USERS Tab)
    {
      return base.GetLockedFields(Tab);
    }

    public bool Save(CTP_USR_USERS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CTP_USR_USERS";
      this.sb.AddField("USR_NOME", Tab.USR_NOME, 60);
      this.sb.AddField("USR_KEY", Tab.USR_KEY, 40);
      this.sb.AddField("USR_INATIVO", Tab.USR_INATIVO);

      bool Gravou = false;
      if (Tab.USR_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.USR_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where USR_CODIGO = " + Tab.USR_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int USR_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CTP_USR_USERS";
      return this.cnn.Exec(this.sb.getDelete("where USR_CODIGO = " + USR_CODIGO));
    }
  }
}
