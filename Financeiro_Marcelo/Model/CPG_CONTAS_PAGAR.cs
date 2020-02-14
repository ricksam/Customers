using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class CPG_CONTAS_PAGAR : DefaultEntity
  {    
    public int CPG_CODIGO { get; set; }
    public int CPG_FIN_CODIGO { get; set; }
    public int CPG_EMP_CODIGO { get; set; }
    public int CPG_BCN_CODIGO { get; set; }
    public int CPG_FRN_CODIGO { get; set; }
    public string CPG_DOCUMENTO { get; set; }
    public DateTime CPG_VENCIMENTO { get; set; }
    public bool CPG_SEL { get; set; }
    public bool CPG_OFICIAL { get; set; }
  }
}
