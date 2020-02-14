using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  public enum enmTipoSaldoContas { Credito, Debito }
  partial class SDC_SALDO_CONTAS
  {
    public enmTipoSaldoContas Tipo
    {
      get { return SDC_TIPO == "C" ? enmTipoSaldoContas.Credito : enmTipoSaldoContas.Debito; }
      set { SDC_TIPO = value == enmTipoSaldoContas.Credito ? "C" : "D"; }
    }
  }    
}
