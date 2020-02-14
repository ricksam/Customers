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
  public partial class dsPLN_PLANOCONTAS : DefaultDataSource<PLN_PLANOCONTAS>
  {
    public dsPLN_PLANOCONTAS(Connection cnn)
      : base(cnn)
    { }

    public PLN_PLANOCONTAS Get(int id)
    {
      return Get("select * from PLN_PLANOCONTAS where PLN_CODIGO = " + id.ToString());
    }
    
    public bool Save(PLN_PLANOCONTAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "PLN_PLANOCONTAS";
      this.sb.AddField("PLN_CAT_CODIGO", Tab.PLN_CAT_CODIGO);
      this.sb.AddField("PLN_DESCRICAO", Tab.PLN_DESCRICAO, 60);
      this.sb.AddField("PLN_OBRIGA_DESCRICAO", Tab.PLN_OBRIGA_DESCRICAO);
      this.sb.AddField("PLN_PRIORIDADE", Tab.PLN_PRIORIDADE);
      this.sb.AddField("PLN_CONFERENCIA", Tab.PLN_CONFERENCIA);
      this.sb.AddField("PLN_ADICIONA_ITENS", Tab.PLN_ADICIONA_ITENS);

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
      this.sb.Table = "PLN_PLANOCONTAS";
      return this.cnn.Exec(this.sb.getDelete("where PLN_CODIGO = " + PLN_CODIGO));
    }
  }
}
