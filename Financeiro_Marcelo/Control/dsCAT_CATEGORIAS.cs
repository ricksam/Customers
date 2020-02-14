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
  public partial class dsCAT_CATEGORIAS : DefaultDataSource<CAT_CATEGORIAS>
  {
    public dsCAT_CATEGORIAS(Connection cnn)
      : base(cnn)
    { }

    public CAT_CATEGORIAS Get(int id)
    {
      return Get("select * from CAT_CATEGORIAS where CAT_CODIGO = " + id.ToString());
    }
    
    public bool Save(CAT_CATEGORIAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CAT_CATEGORIAS";
      this.sb.AddField("CAT_DESCRICAO", Tab.CAT_DESCRICAO, 40);
      this.sb.AddField("CAT_TIPO", Tab.CAT_TIPO, 1);

      bool Gravou = false;
      if (Tab.CAT_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.CAT_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where CAT_CODIGO = " + Tab.CAT_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int CAT_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CAT_CATEGORIAS";
      return this.cnn.Exec(this.sb.getDelete("where CAT_CODIGO = " + CAT_CODIGO));
    }
  }
}
