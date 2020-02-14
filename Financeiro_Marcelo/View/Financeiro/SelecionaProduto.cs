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
  public partial class SelecionaProduto : lib.Visual.Models.frmBase
  {
    public SelecionaProduto()
    {
      InitializeComponent();
    }

    public void CerregaProdutos(string[] Produtos)
    {
      lstProdutos.Items.AddRange(Produtos);
      if (lstProdutos.Items.Count != 0)
      { lstProdutos.SelectedIndex = 0; }
    }

    public string GetItem()
    {
      if (lstProdutos.SelectedIndex != -1)
      { return lstProdutos.Items[lstProdutos.SelectedIndex].ToString(); }
      else 
      { return ""; }
    }

    private void lstProdutos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { this.DialogResult = System.Windows.Forms.DialogResult.OK; }
    }

    private void lstProdutos_DoubleClick(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
    }
  }
}
