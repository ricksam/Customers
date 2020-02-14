using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace WsPhito
{
  public partial class dsATD_ATENDIMENTO : DefaultDataSource<ATD_ATENDIMENTO>
  {
    public dsATD_ATENDIMENTO(Connection cnn)
      : base(cnn)
    { }

    public ATD_ATENDIMENTO Get(int id)
    {
      return Get("select * from ATD_ATENDIMENTO where ATD_CODIGO = " + id.ToString());
    }

    public bool Save(ATD_ATENDIMENTO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "ATD_ATENDIMENTO";

      this.sb.AddField("ATD_LOJA", Tab.ATD_LOJA, 60);
      this.sb.AddField("ATD_ASSUNTO", Tab.ATD_ASSUNTO, 40);
      this.sb.AddField("ATD_GUICHE", Tab.ATD_GUICHE);
      this.sb.AddField("ATD_SENHA", Tab.ATD_SENHA, 20);
      this.sb.AddField("ATD_PREFERENCIAL", Tab.ATD_PREFERENCIAL);

      if (Tab.ATD_ABERTURA != DateTime.MinValue)
      { this.sb.AddField("ATD_ABERTURA", Tab.ATD_ABERTURA, enmFieldType.DateTime); }

      if (Tab.ATD_INICIO != DateTime.MinValue)
      { this.sb.AddField("ATD_INICIO", Tab.ATD_INICIO, enmFieldType.DateTime); }

      if (Tab.ATD_FIM != DateTime.MinValue)
      { this.sb.AddField("ATD_FIM", Tab.ATD_FIM, enmFieldType.DateTime); }

      this.sb.AddField("ATD_CONCLUIDO", Tab.ATD_CONCLUIDO);

      bool Gravou = false;
      if (Tab.ATD_CODIGO == 0)
      {
        Gravou = this.cnn.Exec("set dateformat ymd " + this.sb.getInsert());
        Tab.ATD_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec("set dateformat ymd " + this.sb.getUpdate("where ATD_CODIGO = " + Tab.ATD_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int ATD_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "ATD_ATENDIMENTO";
      return this.cnn.Exec(this.sb.getDelete("where ATD_CODIGO = " + ATD_CODIGO));
    }
  }
}
