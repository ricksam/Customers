using System;
using System.Collections.Generic;
using System.Text;

namespace Financeiro_Marcelo
{
  public enum enmTipoLancamento { Receita, Despesa }
  partial class FIN_FINANCEIRO
  {    
    public bool Sel { get; set; }
    public string CAT_DESCRICAO { get; set; }
    public string CAT_TIPO { get; set; }
    public string PLN_DESCRICAO { get; set; }
    public string FRN_NOME { get; set; }
    public bool PLN_CONFERENCIA { get; set; }
    public bool PLN_OBRIGA_DESCRICAO { get; set; }
    #region public string DescricaoResumida
    public string DescricaoResumida
    {
      get
      {
        if (string.IsNullOrEmpty(FIN_DESCRICAO))
        { return ""; }

        if (FIN_DESCRICAO.Length > 20)
        { return FIN_DESCRICAO.Substring(0, 20); }
        else
        { return FIN_DESCRICAO; }
      }
    }
    #endregion
    #region public enmTipoLancamento TipoLancamento
    public enmTipoLancamento TipoLancamento
    { get { return (CAT_TIPO == "R" ? enmTipoLancamento.Receita : enmTipoLancamento.Despesa); } }
    #endregion
    public string CPG_DOCUMENTO { get; set; }
    public DateTime CPG_VENCIMENTO { get; set; }
    public int CPG_BCN_CODIGO { get; set; }
    public int CPG_FRN_CODIGO { get; set; }
    public bool Pago { get { return CPG_BCN_CODIGO != 0; } }
  }
}
