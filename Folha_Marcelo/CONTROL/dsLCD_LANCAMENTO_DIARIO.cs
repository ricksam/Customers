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
  public partial class dsLCD_LANCAMENTO_DIARIO : DefaultDataSource<LCD_LANCAMENTO_DIARIO>
  {
    public dsLCD_LANCAMENTO_DIARIO(Connection cnn)
      : base(cnn)
    { }

    public LCD_LANCAMENTO_DIARIO Get(int id)
    {
      return Get("select * from LCD_LANCAMENTO_DIARIO where LCD_CODIGO = " + id.ToString());
    }

    public bool Save(LCD_LANCAMENTO_DIARIO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "LCD_LANCAMENTO_DIARIO";
      this.sb.AddField("LCD_OPR_CODIGO", Tab.LCD_OPR_CODIGO);
      this.sb.AddField("LCD_CLB_CODIGO", Tab.LCD_CLB_CODIGO);
      this.sb.AddField("LCD_EMP_CODIGO", Tab.LCD_EMP_CODIGO);
      this.sb.AddField("LCD_DESCRICAO", Tab.LCD_DESCRICAO, 80);
      this.sb.AddField("LCD_DIA", Tab.LCD_DIA);
      this.sb.AddField("LCD_MES", Tab.LCD_MES);
      this.sb.AddField("LCD_ANO", Tab.LCD_ANO);
      this.sb.AddField("LCD_DATA", Tab.LCD_DATA, enmFieldType.Date);
      this.sb.AddField("LCD_REFERENCIA", Tab.LCD_REFERENCIA);
      this.sb.AddField("LCD_VALOR", Tab.LCD_VALOR);

      bool Gravou = false;
      if (Tab.LCD_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.LCD_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where LCD_CODIGO = " + Tab.LCD_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int LCD_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "LCD_LANCAMENTO_DIARIO";
      return this.cnn.Exec(this.sb.getDelete("where LCD_CODIGO = " + LCD_CODIGO));
    }
  }
}
