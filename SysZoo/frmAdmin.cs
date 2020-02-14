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
  public partial class frmAdmin : frmBase
  {
    public frmAdmin()
    {
      InitializeComponent();
    }

    private void btnTickets_Click(object sender, EventArgs e)
    {
      frmCadastroTicket f = new frmCadastroTicket();
      f.ShowDialog();
    }

    private void btnPagamento_Click(object sender, EventArgs e)
    {
      frmCadastroPagamento f = new frmCadastroPagamento();
      f.ShowDialog();
    }

    private void btnOperadores_Click(object sender, EventArgs e)
    {
      frmCadastroOperadores f = new frmCadastroOperadores();
      f.ShowDialog();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Utilities.ShowReport("Fechamento - DataReal");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Utilities.ShowReport("Fechamento - CampoPercentual");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      (new frmAjuda()).ShowDialog();
    }

    private void frmAdmin_Load(object sender, EventArgs e)
    {
      this.Text = "Admin " + lib.Class.Utils.GetVersion();
      this.lblWindowTitle.Text = "Admin " + lib.Class.Utils.GetVersion();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Utilities.ShowReport("Resumo");
    }

  }
}
