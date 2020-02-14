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
  public partial class Expressao : lib.Visual.Models.frmBase
  {
    public Expressao()
    {
      InitializeComponent();
    }

    public void Set(string expressao)
    { txtExpressao.Text = expressao; }

    public string Get()
    { return txtExpressao.Text; }

    public decimal Result() 
    {
      try
      {
        if (string.IsNullOrEmpty(txtExpressao.Text))
        { return 0; }
        else
        {
          lib.Class.Calc c = new lib.Class.Calc();
          c.SetExpression(txtExpressao.Text.Replace("=", ""));
          return c.GetResult();
        }
      }
      catch { return 0; }
    }

    private void sknTextBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if(e.KeyData==Keys.Enter)
      { this.DialogResult = System.Windows.Forms.DialogResult.OK; }
    }

    private void Expressao_Load(object sender, EventArgs e)
    {
      txtExpressao.Focus();
    }
  }
}
