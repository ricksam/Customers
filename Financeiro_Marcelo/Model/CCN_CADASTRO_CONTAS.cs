using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class CCN_CADASTRO_CONTAS : DefaultEntity
  {
    public int CCN_CODIGO { get; set; }
    public int CCN_EMP_CODIGO { get; set; }
    public string CCN_BANCO { get; set; }
    public string CCN_AGENCIA { get; set; }
    public string CCN_CONTA { get; set; }
  }
}
