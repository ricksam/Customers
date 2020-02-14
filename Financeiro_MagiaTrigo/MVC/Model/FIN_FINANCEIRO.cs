using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class FIN_FINANCEIRO : DefaultEntity
  {
    public int FIN_CODIGO { get; set; }
    public int FIN_PLN_CODIGO { get; set; }
    public int FIN_CON_CODIGO { get; set; }
    public string FIN_DOCUMENTO { get; set; }
    public string FIN_DESCRICAO { get; set; }
    public DateTime FIN_EMISSAO { get; set; }
    public DateTime FIN_VENCIMENTO { get; set; }
    public DateTime FIN_DTPGTO { get; set; }
    public decimal FIN_VALOR { get; set; }
  }
}
