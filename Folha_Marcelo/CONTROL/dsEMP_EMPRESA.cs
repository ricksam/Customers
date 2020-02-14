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
  public partial class dsEMP_EMPRESA : DefaultDataSource<EMP_EMPRESA>
  {
    public dsEMP_EMPRESA(Connection cnn)
      : base(cnn)
    { }

    public EMP_EMPRESA Get(int id)
    {
      return Get("select * from EMP_EMPRESA where EMP_CODIGO = " + id.ToString());
    }

    public bool Save(EMP_EMPRESA Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "EMP_EMPRESA";
      this.sb.AddField("EMP_NOME", Tab.EMP_NOME, 40);

      bool Gravou = false;
      if (Tab.EMP_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.EMP_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where EMP_CODIGO = " + Tab.EMP_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int EMP_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "EMP_EMPRESA";
      return this.cnn.Exec(this.sb.getDelete("where EMP_CODIGO = " + EMP_CODIGO));
    }
  }
}
