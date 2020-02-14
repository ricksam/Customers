using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo.Senha
{
  public partial class InformarSenha : lib.Visual.Models.frmDialog
  {
    public InformarSenha()
    {
      InitializeComponent();
    }

    public string Senha { get { return txtSenha.Text; } }

    private void InformarSenha_Load(object sender, EventArgs e)
    {
      this.Visible = false;
      this.Refresh();
      this.Visible = true;
      this.Refresh();
      txtSenha.Select();
      txtSenha.Focus();
    }

    private void txtSenha_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { OnConfirm(); }
    }
  }
}
