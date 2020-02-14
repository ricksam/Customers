using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
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
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CFG_CONFIG";
      this.sb.AddField("CFG_CAMPO_REMUNERACAO", Tab.CFG_CAMPO_REMUNERACAO, 20);
      this.sb.AddField("CFG_CAMPO_REMUNERACAO_TOTAL", Tab.CFG_CAMPO_REMUNERACAO_TOTAL, 20);
      this.sb.AddField("CFG_CAMPO_DESCONTO_TOTAL", Tab.CFG_CAMPO_DESCONTO_TOTAL, 20);
      this.sb.AddField("CFG_CAMPO_REMUNERACAO_LIQUIDA", Tab.CFG_CAMPO_REMUNERACAO_LIQUIDA, 20);
      this.sb.AddField("CFG_CAMPO_REFERENCIA", Tab.CFG_CAMPO_REFERENCIA, 20);
      this.sb.AddField("CFG_EMAIL_ALERTA", Tab.CFG_EMAIL_ALERTA,100);
      this.sb.AddField("CFG_ALERTA_ANIVERSARIO", Tab.CFG_ALERTA_ANIVERSARIO, 60);
      this.sb.AddField("CFG_OCORRENCIAS_AUTOMATICAS", Tab.CFG_OCORRENCIAS_AUTOMATICAS, 20);

      bool Gravou = false;
      if (GetList().Length == 0)
      { Gravou = this.cnn.Exec(this.sb.getInsert()); }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("")); }

      return Gravou;
    }

    public bool Remove()
    {
      this.sb.Clear();
      this.sb.Table = "CFG_CONFIG";
      return this.cnn.Exec(this.sb.getDelete(""));
    }
  }
}
