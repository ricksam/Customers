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
  public partial class dsACU_ACESSO_USUARIO : DefaultDataSource<ACU_ACESSO_USUARIO>
  {
    public dsACU_ACESSO_USUARIO(Connection cnn)
      : base(cnn)
    { }

    public ACU_ACESSO_USUARIO Get(int id)
    {
      return Get("select * from ACU_ACESSO_USUARIO where ACU_ACS_CODIGO = " + id.ToString());
    }

    public bool Save(ACU_ACESSO_USUARIO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "ACU_ACESSO_USUARIO";
      this.sb.AddField("ACU_USU_CODIGO", Tab.ACU_USU_CODIGO);

      bool Gravou = false;
      if (Tab.ACU_ACS_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.ACU_ACS_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where ACU_ACS_CODIGO = " + Tab.ACU_ACS_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int ACU_ACS_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "ACU_ACESSO_USUARIO";
      return this.cnn.Exec(this.sb.getDelete("where ACU_ACS_CODIGO = " + ACU_ACS_CODIGO));
    }
  }
}
