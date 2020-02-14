using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsCFG_CONFIG
  {
    public void AvancaNrImpressaoBaixa()
    {
      cnn.Exec("UPDATE CFG_CONFIG SET CFG_NRIMPRESSAO_BAIXA = CFG_NRIMPRESSAO_BAIXA + 1");
    }
  }
}
