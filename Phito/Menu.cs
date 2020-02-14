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
  public partial class Menu : Form
  {
    public Menu()
    {
      InitializeComponent();
    }

    private bool FaltaConfigurar()
    {
      Config c = new Config();
      c.Open();

      string xmsg = "";
      if (string.IsNullOrEmpty(c.Loja))
      { xmsg = " - A configuração da loja não foi definida, este processo irá falhar!\r\n"; }
            
      if (string.IsNullOrEmpty(c.WebService))
      { xmsg = " - Configure o WebService!\r\n"; }

      if (!string.IsNullOrEmpty(xmsg))
      {
        lib.Visual.Msg.Warning("Verifique os problemas abaixo:\r\n" + xmsg);
        return true;
      }

      return false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!FaltaConfigurar())
      {
        Tottem f = new Tottem();
        f.ShowDialog();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (!FaltaConfigurar())
      {
        Atendente f = new Atendente();
        f.ShowDialog();
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (!FaltaConfigurar())
      {
        Painel f = new Painel();
        f.ShowDialog();
      }
    }
    
    private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Configuracao f = new Configuracao();
      f.ShowDialog();
    }

    private void Menu_Load(object sender, EventArgs e)
    {
      this.Text = string.Format("Phito [{0}]", lib.Class.Utils.GetVersion());
    }

    private void testeToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      Config c = new Config();
      c.Open();
      WsPhito.UserPhito User = (new WsPhito.Service(c.WebService)).GetUsuario("123");
    }
  }
}
