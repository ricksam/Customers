using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class LNC_LANC_CARTOES
  {
    public bool Sel { get; set; }
    public string CRT_DESCRICAO { get; set; }
    public decimal CRT_TAXA { get; set; }
    public int CRT_NRDIAS { get; set; }
    public int CRT_SEMANA { get; set; }
    public string CRT_VENCIMENTOS { get; set; }
    public decimal ValorParcial { get; set; }
    private decimal GetTotTitulo() { return LNC_VALOR + ValorParcial; }

    public void SetValor(decimal Valor)
    {
      decimal Tot = GetTotTitulo();
      if (Valor <= Tot && Valor > 0)
      {
        LNC_VALOR = Valor;
        ValorParcial = Tot - LNC_VALOR;
      }
    }
  }
}
