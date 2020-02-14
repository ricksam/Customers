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
  public partial class dsOPR_OPERACAO : DefaultDataSource<OPR_OPERACAO>
  {
    public dsOPR_OPERACAO(Connection cnn)
      : base(cnn)
    { }

    public OPR_OPERACAO Get(int id)
    {
      return Get("select * from OPR_OPERACAO where OPR_CODIGO = " + id.ToString());
    }

    public bool Save(OPR_OPERACAO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "OPR_OPERACAO";

      if (Tab.OPR_PLN_CODIGO == 0)
      { this.sb.AddField("OPR_PLN_CODIGO", null); }
      else
      { this.sb.AddField("OPR_PLN_CODIGO", Tab.OPR_PLN_CODIGO); }

      this.sb.AddField("OPR_DESCRICAO", Tab.OPR_DESCRICAO, 40);      
      this.sb.AddField("OPR_ADDESTOQUE", Tab.OPR_ADDESTOQUE);

      bool Gravou = false;
      if (Tab.OPR_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.OPR_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where OPR_CODIGO = " + Tab.OPR_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int OPR_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "OPR_OPERACAO";
      return this.cnn.Exec(this.sb.getDelete("where OPR_CODIGO = " + OPR_CODIGO));
    }
  }
}
