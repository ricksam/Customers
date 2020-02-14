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
  public partial class dsPLN_PLANO_CONTAS : DefaultDataSource<PLN_PLANO_CONTAS>
  {
    public dsPLN_PLANO_CONTAS(Connection cnn)
      : base(cnn)
    { }

    public PLN_PLANO_CONTAS Get(int id)
    {
      return Get("select * from PLN_PLANO_CONTAS where PLN_CODIGO = " + id.ToString());
    }

    public bool Save(PLN_PLANO_CONTAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "PLN_PLANO_CONTAS";
      this.sb.AddField("PLN_TIPO", Tab.PLN_TIPO, 1);
      this.sb.AddField("PLN_DESCRICAO", Tab.PLN_DESCRICAO, 60);

      bool Gravou = false;
      if (Tab.PLN_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.PLN_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where PLN_CODIGO = " + Tab.PLN_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int PLN_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "PLN_PLANO_CONTAS";
      return this.cnn.Exec(this.sb.getDelete("where PLN_CODIGO = " + PLN_CODIGO));
    }
  }
}
