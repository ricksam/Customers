using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class LNC_LANCAMENTO : DefaultEntity
  {
    public int LNC_CODIGO { get; set; }
    public int LNC_OPR_CODIGO { get; set; }
    public int LNC_CLB_CODIGO { get; set; }
    public int LNC_EMP_CODIGO { get; set; }
    public int LNC_MES { get; set; }
    public int LNC_ANO { get; set; }
    public decimal LNC_REFERENCIA { get; set; }
    public decimal LNC_VALOR { get; set; }
  }
}
