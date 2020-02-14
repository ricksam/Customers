using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class dsCFG_CONFIG : DefaultDataSource<CFG_CONFIG>
  {
    public dsCFG_CONFIG(Connection cnn)
      : base(cnn)
    { }

    public CFG_CONFIG Get()
    {
      return Get("select * from CFG_CONFIG");
    }
    
    public bool Save(CFG_CONFIG Tab)
    {
      this.sb.Clear();
      this.sb.Table = "CFG_CONFIG";
      this.sb.AddField("CFG_SENHA_ENTRADA", Tab.CFG_SENHA_ENTRADA);
      this.sb.AddField("CFG_SENHA_EXCLUSIVA", Tab.CFG_SENHA_EXCLUSIVA);
      this.sb.AddField("CFG_NRIMPRESSAO_BAIXA", Tab.CFG_NRIMPRESSAO_BAIXA);

      bool Gravou = false;
      if (GetList().Length == 0)
      { Gravou = this.cnn.Exec(this.sb.getInsert()); }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("")); }

      return Gravou;
    }

    public bool Remove(int CFG_SENHA_ENTRADA)
    {
      this.sb.Clear();
      this.sb.Table = "CFG_CONFIG";
      return this.cnn.Exec(this.sb.getDelete(""));
    }
  }
}
