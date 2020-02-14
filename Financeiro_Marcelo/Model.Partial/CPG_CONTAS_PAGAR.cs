using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  //public enum enmSituacaoContas { Aberto, Pago, EmAtrazo }
  partial class CPG_CONTAS_PAGAR
  {
    public CPG_CONTAS_PAGAR() 
    {
      CPG_OFICIAL = true;
    }

    public bool Sel { get; set; }
    public int FRM_NUMERO { get; set; }
    public string EMP_DESCRICAO { get; set; }
    public string FRN_NOME { get; set; }
    public string CAT_DESCRICAO { get; set; }
    public string PLN_DESCRICAO { get; set; }
    public string FIN_DESCRICAO { get; set; }
    public DateTime FIN_EMISSAO { get; set; }
    public DateTime FIN_DATA { get; set; }
    public DateTime FIN_DATA_PGTO { get; set; }
    public decimal FIN_VALOR { get; set; }
    public decimal FIN_VALOR_NOTA { get; set; }
    public decimal ValorParcial { get; set; }
    private decimal GetTotTitulo() { return FIN_VALOR + ValorParcial; }

    public void SetValor(decimal Valor) 
    {
      decimal Tot = GetTotTitulo();
      if (Valor <= Tot && Valor > 0)
      {
        FIN_VALOR = Valor;
        ValorParcial = Tot - FIN_VALOR;
      }
    }
  }
}
