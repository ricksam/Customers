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
  public partial class dsFRN_FORNECEDORES : DefaultDataSource<FRN_FORNECEDORES>
  {
    public dsFRN_FORNECEDORES(Connection cnn)
      : base(cnn)
    { }

    public FRN_FORNECEDORES Get(int id)
    {
      return Get("select * from FRN_FORNECEDORES where FRN_CODIGO = " + id.ToString());
    }

    public bool Save(FRN_FORNECEDORES Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "FRN_FORNECEDORES";
      this.sb.AddField("FRN_NOME", Tab.FRN_NOME, 60);
      this.sb.AddField("FRN_CNPJ", Tab.FRN_CNPJ, 20);
      this.sb.AddField("FRN_TELEFONE", Tab.FRN_TELEFONE, 20);

      bool Gravou = false;
      if (Tab.FRN_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.FRN_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where FRN_CODIGO = " + Tab.FRN_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int FRN_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "FRN_FORNECEDORES";
      return this.cnn.Exec(this.sb.getDelete("where FRN_CODIGO = " + FRN_CODIGO));
    }
  }
}
