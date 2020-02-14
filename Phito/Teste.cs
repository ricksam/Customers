using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phito
{
  public partial class Teste : Form
  {
    public Teste()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      { txtResult.Text = lib.Class.WebUtils.GetWebResponse(txtLink.Text, txtArgs.Text); }
      catch (Exception ex)
      { txtResult.Text = ex.Message; }
    }
  }
}
