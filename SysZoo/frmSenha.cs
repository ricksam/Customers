using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysZoo
{
  public partial class frmSenha : frmBase
  {
    public frmSenha()
    {
      InitializeComponent();
    }

    public string Senha()
    {
      return txtSenha.Text;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(Senha()))
      { this.DialogResult = System.Windows.Forms.DialogResult.OK; }
    }
  }
}
