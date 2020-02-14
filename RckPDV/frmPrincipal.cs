using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckPDV
{
  public partial class frmPrincipal : frmBase
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void AjustaDisplay()
    {
      pnlDisplay.Width = this.Width-20;
      pnlDisplay.Left = (this.Width / 2) - (pnlDisplay.Width / 2);
      pnlDisplay.Top = (this.Height / 2) - (pnlDisplay.Height / 2) + (lblWindowTitle.Height/2) ;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void frmPrincipal_Load(object sender, EventArgs e)
    {
      AjustaDisplay();
    }
  }
}
