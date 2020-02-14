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
  public partial class SelecionaConta : lib.Visual.Models.frmDialog
  {
    public SelecionaConta()
    {
      InitializeComponent();
    }

    int EMP_CODIGO { get; set; }
    decimal Valor { get; set; }
    public SDC_SALDO_CONTAS Saldo { get; set; }

    public void SetValues(int EMP_CODIGO, decimal Valor)
    {
      this.EMP_CODIGO = EMP_CODIGO;
      this.Valor = Valor;
    }

    private void Carregar()
    {
      cmbContas.ValueMember = "CCN_CODIGO";
      cmbContas.DisplayMember = "Descricao";
      cmbContas.DataSource = (new dsCCN_CADASTRO_CONTAS(Utilities.Cnn)).GetList_FromEmpresa(EMP_CODIGO);

      txtValor.AsDecimal = Valor;
    }

    protected override void OnConfirm()
    {
      if (cmbContas.SelectedIndex != -1)
      {
        Saldo = (new dsSDC_SALDO_CONTAS(Utilities.Cnn)).CreateSalto(
          "BAIXA DE CARTAO",
          enmTipoSaldoContas.Credito,
          (int)cmbContas.SelectedValue,
          txtValor.AsDecimal
          );

        base.OnConfirm();
      }
      else
      { lib.Visual.Msg.Warning("Selecione uma conta"); }
    }

    private void SelecionaConta_Load(object sender, EventArgs e)
    {
      Carregar();
    }
  }
}
