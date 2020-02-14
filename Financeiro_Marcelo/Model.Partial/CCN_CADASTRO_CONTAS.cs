using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class CCN_CADASTRO_CONTAS
  {
    public string EMP_DESCRICAO { get; set; }
    public string Descricao
    {
      get
      {
        return string.Format("Banco {0}, Agencia {1}, Conta {2}",
          CCN_BANCO, CCN_AGENCIA, CCN_CONTA);
      }
    }
  }
}
