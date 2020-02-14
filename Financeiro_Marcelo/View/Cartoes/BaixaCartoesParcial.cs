using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo.View.Cartoes
{
  public partial class BaixaCartoesParcial : lib.Visual.Models.frmDialog
  {
    public BaixaCartoesParcial()
    {
      InitializeComponent();
    }
        
    public LNC_LANC_CARTOES Tab { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      txtCartao.Text = Tab.CRT_DESCRICAO;
      txtEmissao.AsDateTime = Tab.LNC_EMISSAO;
      txtVencimento.AsDateTime = Tab.LNC_VENCIMENTO;
      txtValor.AsDecimal = Tab.LNC_VALOR;
      CalculaValorRestante();
    }
    #endregion

    #region private void CalculaValorRestante()
    private void CalculaValorRestante()
    {
      Tab.SetValor(txtValor.AsDecimal);
      txtValor.AsDecimal = Tab.LNC_VALOR;
      txtRestante.AsDecimal = Tab.ValorParcial;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      CalculaValorRestante();
      base.OnConfirm();
    }
    #endregion

    #region Events
    private void BaixaCartoesParcial_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void txtValor_Leave(object sender, EventArgs e)
    {
      CalculaValorRestante();
    }
    #endregion
  }
}
