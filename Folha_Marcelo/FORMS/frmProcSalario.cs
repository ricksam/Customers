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
  public partial class frmProcSalario : lib.Visual.Models.frmBase
  {
    public frmProcSalario()
    {
      InitializeComponent();
    }

    private void frmProcSalario_Load(object sender, EventArgs e)
    {
      cmbAno.Items.Clear();
      for (int i = DateTime.Now.Year - 2; i <= (DateTime.Now.Year + 2); i++)
      { cmbAno.Items.Add(i.ToString()); }
    }
  }
}
