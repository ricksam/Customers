using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class LCD_LANCAMENTO_DIARIO : DefaultEntity
  {
    public int LCD_CODIGO { get; set; }
    public int LCD_OPR_CODIGO { get; set; }
    public int LCD_CLB_CODIGO { get; set; }
    public int LCD_EMP_CODIGO { get; set; }
    public string LCD_DESCRICAO { get; set; }
    public int LCD_DIA { get; set; }
    public int LCD_MES { get; set; }
    public int LCD_ANO { get; set; }
    public DateTime LCD_DATA { get; set; }
    public decimal LCD_REFERENCIA { get; set; }
    public decimal LCD_VALOR { get; set; }
  }
}
