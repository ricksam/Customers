using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckEventos
{
  public partial class Mensagens : Form
  {
    public Mensagens()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //SalvarScreen(textBox1,@"d:\tmp\foto1.jpg");
      try
      {
        string msg = txtNome.Text + " escreveu no livro de recados: " + txtMensagem.Text;
        Utilities.Mensagens.Add(msg);
        txtNome.Text = "";
        txtMensagem.Text = "";
        lblReturn.Text = "Mensagem gravada com sucesso! Dentro de alguns minutos estará postada no facebook.";
      }
      catch
      {
        lblReturn.Text = "";
      }
    }

    private void Mensagens_Load(object sender, EventArgs e)
    {
      pnlDisplay.Top = (this.Height / 2) - (pnlDisplay.Height / 2);
      pnlDisplay.Left = (this.Width / 2) - (pnlDisplay.Width / 2);
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
      lblReturn.Text = "";
    }

    /*private void SalvarScreen(Control controle, string nomeArquivo)
    {
      Bitmap imagem = new Bitmap(controle.Width, controle.Height);
      using (Graphics graphics = Graphics.FromImage(imagem))
      {
        graphics.CopyFromScreen(controle.PointToScreen(new Point()), Point.Empty, imagem.Size);
      }
      imagem.Save(nomeArquivo, System.Drawing.Imaging.ImageFormat.Jpeg);
    }*/
  }
}
