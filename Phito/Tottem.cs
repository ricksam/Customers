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
  public partial class Tottem : Form
  {
    public Tottem()
    {
      InitializeComponent();
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.Escape) 
      {
        this.Close();
      }
      base.OnKeyDown(e);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      pnlDisplay.Top = (this.Height - pnlDisplay.Height) / 2;
      pnlDisplay.Left = (this.Width - pnlDisplay.Width) / 2;
    }

    private void btn_Click(object sender, EventArgs e)
    {
      Senha f = new Senha();
      f.Assunto = ((Button)sender).Text;
      f.ShowDialog();
    }
  }
}
