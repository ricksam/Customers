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
  public partial class dsCCN_CADASTRO_CONTAS : DefaultDataSource<CCN_CADASTRO_CONTAS>
  {
    public dsCCN_CADASTRO_CONTAS(Connection cnn)
      : base(cnn)
    { }

    public CCN_CADASTRO_CONTAS Get(int id)
    {
      return Get("select * from CCN_CADASTRO_CONTAS where CCN_CODIGO = " + id.ToString());
    }
    
    public bool Save(CCN_CADASTRO_CONTAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CCN_CADASTRO_CONTAS";
      this.sb.AddField("CCN_EMP_CODIGO", Tab.CCN_EMP_CODIGO);
      this.sb.AddField("CCN_BANCO", Tab.CCN_BANCO, 60);
      this.sb.AddField("CCN_AGENCIA", Tab.CCN_AGENCIA, 20);
      this.sb.AddField("CCN_CONTA", Tab.CCN_CONTA, 20);

      bool Gravou = false;
      if (Tab.CCN_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.CCN_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where CCN_CODIGO = " + Tab.CCN_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int CCN_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CCN_CADASTRO_CONTAS";
      return this.cnn.Exec(this.sb.getDelete("where CCN_CODIGO = " + CCN_CODIGO));
    }
  }
}
