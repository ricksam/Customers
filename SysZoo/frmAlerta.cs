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
  public partial class frmAlerta : frmBase
  {
    public frmAlerta()
    {
      InitializeComponent();
    }

    public void Carregar(string s) 
    {
      lblMensagem.Text = s;
    }

    private void frmAlerta_Load(object sender, EventArgs e)
    {
      btnOk.Select();
    }
  }
}
