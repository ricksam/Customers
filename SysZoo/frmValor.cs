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
  public partial class frmValor : frmBase
  {
    public frmValor()
    {
      InitializeComponent();
    }

    public void Titulo(string s) 
    {
      lblInfo.Text = s;
    }

    public decimal Valor()
    {
      return (new lib.Class.Conversion()).ToDecimal(txtValor.Text);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (Valor() != 0)
      { this.DialogResult = System.Windows.Forms.DialogResult.OK; }
    }
  }
}
