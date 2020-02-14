using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlePortarias
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      frmMorador f = new frmMorador();
      f.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      frmVisitante f = new frmVisitante();
      f.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      frmMoradia f = new frmMoradia();
      f.ShowDialog();
    }
  }
}
