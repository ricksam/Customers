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
  public partial class dsPRO_PRODUTOS : DefaultDataSource<PRO_PRODUTOS>
  {
    public dsPRO_PRODUTOS(Connection cnn)
      : base(cnn)
    { }

    public PRO_PRODUTOS Get(int id)
    {
      return Get("select * from PRO_PRODUTOS where PRO_CODIGO = " + id.ToString());
    }

    public bool Save(PRO_PRODUTOS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "PRO_PRODUTOS";
      this.sb.AddField("PRO_DESCRICAO", Tab.PRO_DESCRICAO, 60);
      this.sb.AddField("PRO_QTDE", Tab.PRO_QTDE);
      this.sb.AddField("PRO_UNIDADE", Tab.PRO_UNIDADE, 20);
      this.sb.AddField("PRO_CUSTO", Tab.PRO_CUSTO);
      this.sb.AddField("PRO_PRECO", Tab.PRO_PRECO);

      bool Gravou = false;
      if (Tab.PRO_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.PRO_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where PRO_CODIGO = " + Tab.PRO_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int PRO_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "PRO_PRODUTOS";
      return this.cnn.Exec(this.sb.getDelete("where PRO_CODIGO = " + PRO_CODIGO));
    }
  }
}
