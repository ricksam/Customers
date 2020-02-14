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
  public partial class dsACS_ACESSO : DefaultDataSource<ACS_ACESSO>
  {
    public dsACS_ACESSO(Connection cnn)
      : base(cnn)
    { }

    public ACS_ACESSO Get(int id)
    {
      return Get("select * from ACS_ACESSO where ACS_CODIGO = " + id.ToString());
    }
    
    //partial void GetPartialLockedFields(ACS_ACESSO Tab, List<LockedField> LockedFields);
        
    public bool Save(ACS_ACESSO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "ACS_ACESSO";
      this.sb.AddField("ACS_NOME", Tab.ACS_NOME, 100);
      this.sb.AddField("ACS_DESCRICAO", Tab.ACS_DESCRICAO, 100);

      bool Gravou = false;
      if (Tab.ACS_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.ACS_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where ACS_CODIGO = " + Tab.ACS_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int ACS_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "ACS_ACESSO";
      return this.cnn.Exec(this.sb.getDelete("where ACS_CODIGO = " + ACS_CODIGO));
    }
  }
}
