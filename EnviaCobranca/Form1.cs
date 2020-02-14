using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnviaCobranca
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();
      string CorpoEmail = string.Format("<h1>{0}</h1><p>{1}</p>{2}", txtTitulo.Text, txtTexto.Text.Replace("\n","<br />"), txtScript.Text);
      mail.SendMail(CorpoEmail, true, txtEmailDestino.Text, txtTitulo.Text,new string[]{"jricksam@gmail.com"});
    }
  }
}
