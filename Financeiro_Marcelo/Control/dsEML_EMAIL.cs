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
  public partial class dsEML_EMAIL : DefaultDataSource<EML_EMAIL>
  {
    public dsEML_EMAIL(Connection cnn)
      : base(cnn)
    { }

    public EML_EMAIL Get(int id)
    {
      return Get("select * from EML_EMAIL where EML_CODIGO = " + id.ToString());
    }

    public bool Save(EML_EMAIL Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "EML_EMAIL";
      this.sb.AddField("EML_CONTATO", Tab.EML_CONTATO, 200);

      bool Gravou = false;
      if (Tab.EML_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.EML_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where EML_CODIGO = " + Tab.EML_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int EML_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "EML_EMAIL";
      return this.cnn.Exec(this.sb.getDelete("where EML_CODIGO = " + EML_CODIGO));
    }
  }
}
