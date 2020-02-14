using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo
{
  public partial class BaixaParcial : lib.Visual.Models.frmDialog
  {
    #region public BaixaParcial()
    public BaixaParcial()
    {
      InitializeComponent();
    }
    #endregion

    #region Fields
    public CPG_CONTAS_PAGAR Cpg { get; set; }
    #endregion

    #region Methods
    private void Carregar() 
    {
      txtPlanoContas.Text = Cpg.PLN_DESCRICAO;
      txtDescricao.Text = Cpg.FIN_DESCRICAO;
      txtDocumento.Text = Cpg.CPG_DOCUMENTO;
      txtEntrada.AsDateTime = Cpg.FIN_DATA;
      txtVencimento.AsDateTime = Cpg.CPG_VENCIMENTO;
      txtValor.AsDecimal = Cpg.FIN_VALOR;
      txtRestante.AsDecimal = Cpg.ValorParcial;
    }

    private void CalculaValorRestante() 
    {
      Cpg.SetValor(txtValor.AsDecimal);
      txtValor.AsDecimal = Cpg.FIN_VALOR;
      txtRestante.AsDecimal = Cpg.ValorParcial;
    }

    protected override void OnConfirm()
    {      
      Cpg.FIN_VALOR = txtValor.AsDecimal;
      Cpg.ValorParcial = txtRestante.AsDecimal;
      base.OnConfirm();
    }
    #endregion

    #region Events
    private void BaixaParcial_Load(object sender, EventArgs e)
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
