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
  public partial class dsUSU_USUARIOS : DefaultDataSource<USU_USUARIOS>
  {
    public dsUSU_USUARIOS(Connection cnn)
      : base(cnn)
    { }

    public USU_USUARIOS Get(int id)
    {
      return Get("select * from USU_USUARIOS where USU_CODIGO = " + id.ToString());
    }
    
    public bool Save(USU_USUARIOS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "USU_USUARIOS";
      this.sb.AddField("USU_NOME", Tab.USU_NOME, 60);
      this.sb.AddField("USU_SENHA", Tab.USU_SENHA, 100);
      this.sb.AddField("USU_ADMIN", Tab.USU_ADMIN, -1);

      bool Gravou = false;
      if (Tab.USU_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.USU_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where USU_CODIGO = " + Tab.USU_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int USU_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "USU_USUARIOS";
      return this.cnn.Exec(this.sb.getDelete("where USU_CODIGO = " + USU_CODIGO));
    }
  }
}
