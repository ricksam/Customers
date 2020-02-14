using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo.View
{
  public partial class LancamentoItem : lib.Visual.Models.frmDialog
  {
    public LancamentoItem()
    {
      InitializeComponent();
      ds = new dsFNI_FINANCEIRO_ITEM(Utilities.Cnn);
    }

    dsFNI_FINANCEIRO_ITEM ds { get; set; }
    public FNI_FINANCEIRO_ITEM Tab { get; set; }
    string expressao { get; set; }

    private void Carregar()
    {
      txtDescricao.Text = Tab.FNI_DESCRICAO;
      txtQtde.AsDecimal = Tab.FNI_QTDE;
      txtTotal.AsDecimal = Tab.FNI_VALOR_TOTAL;
      txtVlrUnitario.AsDecimal = Tab.FNI_VALOR_UNITARIO;
      expressao = Tab.FNI_EXPRESSAO;
    }

    public bool FaltaPreencher()
    {
      lib.Class.LockedField[] lf = ds.GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        lib.Visual.Msg.Warning("Verifique os campos abaixo:\n" + xMsg);
      }
      return lf.Length != 0;
    }

    protected override void OnConfirm()
    {
      Tab.FNI_DESCRICAO = txtDescricao.Text;
      Tab.FNI_QTDE = txtQtde.AsDecimal;
      Tab.FNI_VALOR_TOTAL = txtTotal.AsDecimal;
      Tab.FNI_VALOR_UNITARIO = txtVlrUnitario.AsDecimal;
      Tab.FNI_EXPRESSAO = expressao;

      if (!FaltaPreencher())
      { base.OnConfirm(); }
    }

    private void txtTotal_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F2)
      {
        Expressao ex = new Expressao();
        ex.Set(expressao);
        ex.ShowDialog();
        expressao = ex.Get();
        txtTotal.AsDecimal = ex.Result();
        txtVlrUnitario.AsDecimal = ds.CalculaValorUnitario(txtTotal.AsDecimal, txtQtde.AsDecimal);
        txtTotal.Select();
        e.Handled = true;
      }

      if (((Keys)e.KeyCode).ToString().StartsWith("NumPad") || ((Keys)e.KeyCode).ToString().StartsWith("D"))
      {
        expressao = txtTotal.Text;
        txtVlrUnitario.AsDecimal = ds.CalculaValorUnitario(txtTotal.AsDecimal, txtQtde.AsDecimal);
      }
    }

    private void LancamentoItem_Load(object sender, EventArgs e)
    {
      Carregar();
    }
  }
}
