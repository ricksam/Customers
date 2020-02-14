using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_Marcelo
{
  partial class LCD_LANCAMENTO_DIARIO
  {
    public string OPR_DESCRICAO { get; set; }
    public string OPR_TIPO { get; set; }

    public TipoOperacao TipoOperacao
    {

      get
      {
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
