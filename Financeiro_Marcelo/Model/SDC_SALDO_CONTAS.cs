using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class SDC_SALDO_CONTAS : DefaultEntity
  {
    public int SDC_CODIGO { get; set; }
    public int SDC_CCN_CODIGO { get; set; }
    public DateTime SDC_DATA { get; set; }
    public string SDC_OPERACAO { get; set; }
    public int SDC_ANTERIOR_CODIGO { get; set; }
    public decimal SDC_VALOR_LANCADO { get; set; }
    public decimal SDC_SALDO_ATUAL { get; set; }
    public string SDC_TIPO { get; set; }
  }
}
