using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Class;
using lib.Database.Query;
using lib.Database.Drivers;
using lib.Visual;

namespace Financeiro_Marcelo.View
{
  public partial class DepositoRetirada : lib.Visual.Models.frmDialog
  {
    public DepositoRetirada()
    {
      InitializeComponent();
      ds = new dsSDC_SALDO_CONTAS(Utilities.Cnn);
    }

    public SDC_SALDO_CONTAS Tab { get; set; }
    dsSDC_SALDO_CONTAS ds { get; set; }

    private void Carregar()
    {
      Array arr = Enum.GetNames(typeof(enmTipoSaldoContas));
      cmbTipo.Items.Clear();
      for (int i = 0; i < arr.Length; i++)
      { cmbTipo.Items.Add(arr.GetValue(i)); }
    }

    #region private bool FaltaPreencher()
    private bool FaltaPreencher()
    {
      LockedField[] lf = ds.GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

                
        if (lf[0].Field == "SDC_OPERACAO")
        { txtDescricao.Select(); }
        else if (lf[0].Field == "SDC_TIPO")
        { cmbTipo.Select(); }
        else if (lf[0].Field == "SDC_VALOR_LANCADO")
        { txtValor.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion
   
    protected override void OnConfirm()
    {
      Tab.SDC_OPERACAO = txtDescricao.Text;

      if (cmbTipo.SelectedIndex != -1)
      { Tab.Tipo = (enmTipoSaldoContas)cmbTipo.SelectedIndex; }

      Tab.SDC_VALOR_LANCADO = txtValor.AsDecimal;

      if (!FaltaPreencher())
      {
        ds.Save(Tab);
        base.OnConfirm();
      }
    }

    private void DepositoRetirada_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void txtValor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F2)
      {
        Expressao ex = new Expressao();
        ex.ShowDialog();
        txtValor.AsDecimal = ex.Result();
        txtValor.Select();
        e.Handled = true;
      }
    }
  }
}
