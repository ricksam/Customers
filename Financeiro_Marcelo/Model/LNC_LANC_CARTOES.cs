using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class LNC_LANC_CARTOES : DefaultEntity
  {
    public int LNC_CODIGO { get; set; }
    public int LNC_CRT_CODIGO { get; set; }
    public int LNC_CCN_CODIGO { get; set; }
    public DateTime LNC_EMISSAO { get; set; }
    public DateTime LNC_VENCIMENTO { get; set; }
    public DateTime LNC_DATA_PGTO { get; set; }
    public decimal LNC_VALOR { get; set; }
    public decimal LNC_VALOR_TAXA { get; set; }
    public decimal LNC_VALOR_RECEBER { get; set; }
  }
}
