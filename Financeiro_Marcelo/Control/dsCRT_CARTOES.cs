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
  public partial class dsCRT_CARTOES : DefaultDataSource<CRT_CARTOES>
  {
    public dsCRT_CARTOES(Connection cnn)
      : base(cnn)
    { }

    public CRT_CARTOES Get(int id)
    {
      return Get("select * from CRT_CARTOES where CRT_CODIGO = " + id.ToString());
    }

    public bool Save(CRT_CARTOES Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CRT_CARTOES";
      this.sb.AddField("CRT_EMP_CODIGO", Tab.CRT_EMP_CODIGO);
      this.sb.AddField("CRT_DESCRICAO", Tab.CRT_DESCRICAO, 40);
      this.sb.AddField("CRT_NRDIAS", Tab.CRT_NRDIAS);
      this.sb.AddField("CRT_SEMANA", Tab.CRT_SEMANA);
      this.sb.AddField("CRT_VENCIMENTOS", Tab.CRT_VENCIMENTOS, 20);
      this.sb.AddField("CRT_TAXA", Tab.CRT_TAXA);

      bool Gravou = false;
      if (Tab.CRT_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.CRT_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where CRT_CODIGO = " + Tab.CRT_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int CRT_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CRT_CARTOES";
      return this.cnn.Exec(this.sb.getDelete("where CRT_CODIGO = " + CRT_CODIGO));
    }
  }
}
