using System;
using System.Collections.Generic;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class FRM_FORMULARIOS
  {
    public string EMP_DESCRICAO { get; set; }
    public decimal Resultado { get { return FRM_TOTDESPESAS + FRM_TOTRECEITAS + FRM_TROCOFINAL - FRM_TROCOINICIAL; } }
  }
}
