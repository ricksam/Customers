using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class BCN_BAIXA_CONTAS : DefaultEntity
  {
    public int BCN_CODIGO { get; set; }
    public int BCN_CCN_CODIGO { get; set; }
    public int BCN_EMP_CODIGO { get; set; }
    public string BCN_NUMERO_CHEQUE { get; set; }
    public decimal BCN_VALOR { get; set; }
    public DateTime BCN_DATA_PGTO { get; set; }
    public bool BCN_COMPENSADO { get; set; }
    public DateTime BCN_DATA_COMPENSACAO { get; set; }
    public bool BCN_TIPO_CHEQUE { get; set; }
    public string BCN_DESCRICAO { get; set; }
  }
}
