using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class FRM_FORMULARIOS : DefaultEntity
  {
    public int FRM_CODIGO { get; set; }
    public int FRM_NUMERO { get; set; }
    public int FRM_EMP_CODIGO { get; set; }
    public DateTime FRM_DATA { get; set; }
    public decimal FRM_TROCOINICIAL { get; set; }
    public decimal FRM_TROCOFINAL { get; set; }
    public decimal FRM_TOTRECEITAS { get; set; }
    public decimal FRM_TOTCOMPRAS { get; set; }
    public decimal FRM_TOTDESPESAS { get; set; }
    public bool FRM_BLOQUEADO { get; set; }
    public int FRM_NUMERO_CLIENTES{ get; set; }
    public decimal FRM_VALOR_COMPARATIVO { get; set; }
    public decimal FRM_VALOR_CANCELADO { get; set; }
  }
}
