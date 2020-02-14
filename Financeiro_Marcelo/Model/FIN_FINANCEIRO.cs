using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class FIN_FINANCEIRO : DefaultEntity
  {    
    public int FIN_CODIGO { get; set; }
    public int FIN_CAT_CODIGO { get; set; }
    public int FIN_PLN_CODIGO { get; set; }
    public int FIN_EMP_CODIGO { get; set; }
    public int FIN_FRM_CODIGO { get; set; }
    public string FIN_DESCRICAO { get; set; }
    public decimal FIN_VALOR { get; set; }
    public decimal FIN_VALOR_NOTA { get; set; }
    public DateTime FIN_DATA { get; set; }
    public DateTime FIN_EMISSAO { get; set; }
    public DateTime FIN_DATA_PGTO { get; set; }
    public string FIN_HORA { get; set; }
  }
}
