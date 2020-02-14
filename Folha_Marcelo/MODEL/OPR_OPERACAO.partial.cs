using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_Marcelo
{
  public enum TipoOperacao { SemValor, Credito, Debito }
  partial class OPR_OPERACAO
  {
    public TipoOperacao TipoOperacao
    {
      get {
        switch (OPR_TIPO)
        {
          case ("N"): return Folha_Marcelo.TipoOperacao.SemValor;
          case ("C"): return Folha_Marcelo.TipoOperacao.Credito;
          case ("D"): return Folha_Marcelo.TipoOperacao.Debito;          
          default: return Folha_Marcelo.TipoOperacao.SemValor;
        }
      }
      set
      {
        switch (value)
        {
          case TipoOperacao.SemValor: { OPR_TIPO = "N"; break; }
          case TipoOperacao.Credito: { OPR_TIPO = "C"; break; }
          case TipoOperacao.Debito: { OPR_TIPO = "D"; break; }
          default: { OPR_TIPO = "C"; break; }
        }
      }
    }
  }
}
