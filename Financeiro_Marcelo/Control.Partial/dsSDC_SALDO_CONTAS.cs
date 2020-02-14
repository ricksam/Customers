using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Financeiro_Marcelo
{
  partial class dsSDC_SALDO_CONTAS
  {
    public string Lastsearch { get; set; }

    #region public SDC_SALDO_CONTAS[] Search(string s)
    public SDC_SALDO_CONTAS[] Search(string s)
    {
      int nr_res = 5;

      if (s == Lastsearch)
      { nr_res = 100; }
      else
      { Lastsearch = s; }

      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");
      return GetList(
          @"
            SELECT * FROM SDC_SALDO_CONTAS 
            WHERE 
              SDC_CCN_CODIGO LIKE {0}
              OR SDC_DATA LIKE {0}
              OR SDC_OPERACAO LIKE {0}
              OR SDC_ANTERIOR_CODIGO LIKE {0}
              OR SDC_VALOR_LANCADO LIKE {0}
              OR SDC_SALDO_ATUAL LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public SDC_SALDO_CONTAS[] GetUltimos(int SDC_CCN_CODIGO, int Qtde)
    public SDC_SALDO_CONTAS[] GetUltimos(int SDC_CCN_CODIGO, int Qtde)
    {
      return GetList(
        string.Format(
          "SELECT * FROM SDC_SALDO_CONTAS WHERE SDC_CCN_CODIGO = {0} ORDER BY SDC_CODIGO DESC", 
          SDC_CCN_CODIGO),
        Qtde);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(SDC_SALDO_CONTAS Tab)
    public override LockedField[] GetLockedFields(SDC_SALDO_CONTAS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.SDC_CCN_CODIGO == 0)
      { LockedFields.Add(new LockedField("SDC_CCN_CODIGO", " - Informe o campo SDC_CCN_CODIGO")); }
            
      if (string.IsNullOrEmpty(Tab.SDC_OPERACAO))
      { LockedFields.Add(new LockedField("SDC_OPERACAO", " - Informe o campo SDC_OPERACAO")); }

      if (Tab.SDC_VALOR_LANCADO == 0)
      { LockedFields.Add(new LockedField("SDC_VALOR_LANCADO", " - Informe o campo SDC_VALOR_LANCADO")); }

      if (string.IsNullOrEmpty(Tab.SDC_TIPO))
      { LockedFields.Add(new LockedField("SDC_TIPO", " - Informe o campo SDC_TIPO")); }

      Tab.SDC_DATA = DateTime.Now;
      Tab.SDC_ANTERIOR_CODIGO = GetMax_SDC_CODIGO(Tab.SDC_CCN_CODIGO);

      if (Tab.Tipo == enmTipoSaldoContas.Credito)
      { Tab.SDC_SALDO_ATUAL = GetSaldo_FromMax(Tab.SDC_ANTERIOR_CODIGO) + Tab.SDC_VALOR_LANCADO; }
      else
      { Tab.SDC_SALDO_ATUAL = GetSaldo_FromMax(Tab.SDC_ANTERIOR_CODIGO) - Tab.SDC_VALOR_LANCADO; }

      return LockedFields.ToArray();
    }
    #endregion

    #region private int GetMax_SDC_CODIGO(int SDC_CCN_CODIGO)
    private int GetMax_SDC_CODIGO(int SDC_CCN_CODIGO) 
    {
      return this.cnn.Sql(string.Format("SELECT MAX(SDC_CODIGO) FROM SDC_SALDO_CONTAS WHERE SDC_CCN_CODIGO = {0}", SDC_CCN_CODIGO)).ToInt();
    }
    #endregion

    #region private decimal GetSaldo_FromMax(int MAX_SDC_CODIGO)
    private decimal GetSaldo_FromMax(int MAX_SDC_CODIGO)
    {
      return Get(MAX_SDC_CODIGO).SDC_SALDO_ATUAL;
    }
    #endregion

    #region public decimal SaldoAtual(int SDC_CCN_CODIGO)
    public decimal GetSaldoAtual(int SDC_CCN_CODIGO) 
    {
      return GetSaldo_FromMax(GetMax_SDC_CODIGO(SDC_CCN_CODIGO));
    }
    #endregion

    #region public SDC_SALDO_CONTAS CreateSalto(string SDC_OPERACAO, enmTipoSaldoContas Tipo, int SDC_CCN_CODIGO, decimal Valor)
    public SDC_SALDO_CONTAS CreateSalto(string SDC_OPERACAO, enmTipoSaldoContas Tipo, int SDC_CCN_CODIGO, decimal Valor) 
    {
      SDC_SALDO_CONTAS s = new SDC_SALDO_CONTAS();
      s.SDC_OPERACAO = SDC_OPERACAO;
      s.Tipo = Tipo;
      s.SDC_CCN_CODIGO = SDC_CCN_CODIGO;
      s.SDC_VALOR_LANCADO = Valor;
      return s;
    }
    #endregion
  }
}

