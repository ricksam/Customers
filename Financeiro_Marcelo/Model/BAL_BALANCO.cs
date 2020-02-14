using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class BAL_BALANCO : DefaultEntity
  {
    public int BAL_CODIGO { get; set; }
    public int BAL_ANTERIOR { get; set; }
    public int BAL_EMP_CODIGO { get; set; }
    public decimal BAL_ESTOQUE_INICIAL { get; set; }
    public decimal BAL_ESTOQUE_FINAL { get; set; }
    public decimal BAL_COMPRAS { get; set; }
    public decimal BAL_CMV { get; set; }
    public DateTime BAL_DATA { get; set; }
    public DateTime BAL_INICIO { get; set; }
  }
}
