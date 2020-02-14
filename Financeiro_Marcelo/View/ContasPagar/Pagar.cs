using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual;

namespace Financeiro_Marcelo
{
  public partial class Pagar : lib.Visual.Models.frmDialog
  {
    public Pagar()
    {
      InitializeComponent();
      dsTal = new dsTAL_TALAO_CHEQUE(Utilities.Cnn);
    }


    public BCN_BAIXA_CONTAS Bcn { get; set; }
    private dsTAL_TALAO_CHEQUE dsTal { get; set; }
    private int CodEmpresa { get; set; }

    public void Carregar(int CodEmpresa, string NomeEmpresa) 
    {
      this.CodEmpresa = CodEmpresa;
      txtEmpresa.Text = NomeEmpresa;      
      cmbConta.DisplayMember = "Descricao";
      cmbConta.ValueMember = "CCN_CODIGO";
      cmbConta.DataSource = (new dsCCN_CADASTRO_CONTAS(Utilities.Cnn)).GetList_FromEmpresa(CodEmpresa);
      //SetNrChequeTalao();
    }

    #region private void SetNrChequeTalao()
    private void SetNrChequeTalao()
    {
      TAL_TALAO_CHEQUE Tal = new TAL_TALAO_CHEQUE();

      txtNrCheque.TabStop = false;
      txtNrCheque.Enabled = false;

      if (cmbConta.SelectedIndex != -1)
      { Tal = dsTal.Get_FromEmpresa(CodEmpresa, (int)cmbConta.SelectedValue); }

      if (Tal.TAL_CODIGO != 0)
      {
        if (Tal.TAL_ATUAL == 0)
        { txtNrCheque.AsInt = Tal.TAL_INICIO; }
        else
        { txtNrCheque.AsInt = Tal.TAL_ATUAL + 1; }        
        return;
      }

      Msg.Information(
        @"
         Não existem talões de cheques cadastrados para esta loja.
         Cadastre os talões de cheques em cadastro/Cadastro de Talão de Cheques");

    }
    #endregion

    private void HabilitaCampos() 
    {
      //txtNrCheque.Enabled = rbCheque.Checked;
      cmbConta.Enabled = rbCheque.Checked;
      txtDescricao.Enabled = rbOutra.Checked;
    }
        
    protected override void OnConfirm()
    {
      if (rbCheque.Checked)
      {
        if (cmbConta.SelectedIndex == -1)
        {
          Msg.Warning("Informe uma conta");
          cmbConta.Select();
          return;
        }

        if (string.IsNullOrEmpty(txtNrCheque.Text))
        {
          Msg.Warning("Para pagamento com cheque é necessário ter um talão cadastrado para esta empresa");
          cmbConta.Select();
          return;
        }
      }
      else if (string.IsNullOrEmpty(txtDescricao.Text))
      {
        Msg.Warning("Informe uma descrição");
        txtDescricao.Select();
        return;
      }

      if (rbCheque.Checked)
      {
        TAL_TALAO_CHEQUE Tal = dsTal.Get_FromEmpresa(CodEmpresa,(int)cmbConta.SelectedValue);
        if (Tal.TAL_CODIGO != 0)
        {
          if (Tal.TAL_ATUAL == 0)
          { Tal.TAL_ATUAL = Tal.TAL_INICIO; }
          else
          { Tal.TAL_ATUAL++; }

          dsTal.Save(Tal);
          txtNrCheque.AsInt = Tal.TAL_ATUAL;
        }
      }

      if (txtDataBaixa.AsDateTime == DateTime.MinValue)
      { Bcn.BCN_DATA_PGTO = DateTime.Now; }
      else
      { Bcn.BCN_DATA_PGTO = txtDataBaixa.AsDateTime; }

      Bcn.BCN_NUMERO_CHEQUE = txtNrCheque.Text;
      Bcn.BCN_CCN_CODIGO = (int)cmbConta.SelectedValue;
      Bcn.BCN_TIPO_CHEQUE = rbCheque.Checked;
      Bcn.BCN_DESCRICAO = txtDescricao.Text;
      
      base.OnConfirm();
    }

    private void Pagar_Load(object sender, EventArgs e)
    {
      HabilitaCampos();
      txtDataBaixa.AsDateTime = DateTime.Now;
      txtValorTotal.AsDecimal = Bcn.BCN_VALOR;
      rbCheque.Select();
      if (txtNrCheque.AsInt == 0)
      { SetNrChequeTalao(); }
    }
    
    private void rb_CheckedChanged(object sender, EventArgs e)
    {
      HabilitaCampos();
    }

    private void cmbConta_SelectedIndexChanged(object sender, EventArgs e)
    {
      SetNrChequeTalao();
    }
  }
}
