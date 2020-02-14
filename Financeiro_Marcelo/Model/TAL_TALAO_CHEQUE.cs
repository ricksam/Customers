using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class TAL_TALAO_CHEQUE : DefaultEntity
  {
    public int TAL_CODIGO { get; set; }
    public int TAL_EMP_CODIGO { get; set; }
    public int TAL_CCN_CODIGO { get; set; }
    public int TAL_INICIO { get; set; }
    public int TAL_FIM { get; set; }
    public int TAL_ATUAL { get; set; }
  }
}
