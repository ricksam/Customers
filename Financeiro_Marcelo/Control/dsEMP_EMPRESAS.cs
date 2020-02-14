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
  public partial class dsEMP_EMPRESAS : DefaultDataSource<EMP_EMPRESAS>
  {
    public dsEMP_EMPRESAS(Connection cnn)
      : base(cnn)
    { }

    public EMP_EMPRESAS Get(int id)
    {
      return Get("select * from EMP_EMPRESAS where EMP_CODIGO = " + id.ToString());
    }

    public bool Save(EMP_EMPRESAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "EMP_EMPRESAS";
      this.sb.AddField("EMP_CNPJ", Tab.EMP_CNPJ, 20);
      this.sb.AddField("EMP_DESCRICAO", Tab.EMP_DESCRICAO, 60);
      this.sb.AddField("EMP_DESCRICAO_ONLINE", Tab.EMP_DESCRICAO_ONLINE, 60);

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
      this.sb.Table = "EMP_EMPRESAS";
      return this.cnn.Exec(this.sb.getDelete("where EMP_CODIGO = " + EMP_CODIGO));
    }
  }
}
