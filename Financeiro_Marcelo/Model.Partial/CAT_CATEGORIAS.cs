using System;
using System.Collections.Generic;
using System.Text;

namespace Financeiro_Marcelo
{
  public enum enmTipoFinanceiro { Receita, Despesa }
  partial class CAT_CATEGORIAS
  {
    public enmTipoFinanceiro TipoFinanceiro
    {
      get { return CAT_TIPO == "R" ? enmTipoFinanceiro.Receita : enmTipoFinanceiro.Despesa; }
      set { CAT_TIPO = value == enmTipoFinanceiro.Receita ? "R" : "D"; }
    }
  }
}
