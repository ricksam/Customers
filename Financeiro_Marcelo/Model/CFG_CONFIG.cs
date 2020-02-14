using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class CFG_CONFIG : DefaultEntity
  {
    public string CFG_SENHA_ENTRADA { get; set; }
    public string CFG_SENHA_EXCLUSIVA { get; set; }
    public int CFG_NRIMPRESSAO_BAIXA { get; set; }
  }
}
