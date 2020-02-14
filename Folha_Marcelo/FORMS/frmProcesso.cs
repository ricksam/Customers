using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folha_Marcelo.FORMS
{
  public partial class frmProcesso : lib.Visual.Models.frmBase
  {
    public frmProcesso()
    {
      InitializeComponent();
    }

    public void SetText(string s) 
    {
      this.Text = s;
      this.label1.Text = s;
      this.label1.Refresh();
    }
  }
}
