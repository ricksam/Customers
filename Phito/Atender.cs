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
  public partial class Atender : Form
  {
    public Atender()
    {
      InitializeComponent();
    }

    public WsPhito.ATD_ATENDIMENTO Tab { get; set; }
    public int Guiche { get; set; }
    Config Config { get; set; }
    WsPhito.Service Service { get; set; }
    const string MsgErro = "Erro ao finalizar o atendimento verifique se há conexão com a internet!";
        
    public void Carregar()
    {
      Config = new Config();
      Config.Open();

      Service = new WsPhito.Service(Config.WebService);

      lblNome.Text = "";
      if (imgFoto.Image != null)
      {
        imgFoto.Image.Dispose();
        imgFoto.Image = null;
        imgFoto.Visible = false;
      }

      lblSenha.Text = "Senha:" + Tab.ATD_SENHA;
      lblChegada.Text = "Chegada: " + Tab.ATD_ABERTURA.ToString("HH:mm");
      lblPreferencial.Text = "Preferencial: " + (Tab.ATD_PREFERENCIAL ? "Sim" : "Não");

      WsPhito.UserPhito User = Service.GetUsuario(Tab.ATD_SENHA);
      if (!string.IsNullOrEmpty(User.Nome))
      {
        lblNome.Text = "Nome: " + User.Nome;
        imgFoto.Image = new Bitmap((new lib.Class.Download(256)).ToStream(User.Foto));
        imgFoto.Visible = true;
      }
    }

    private void Atender_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void btnIniciarAtendimento_Click(object sender, EventArgs e)
    {
      btnIniciarAtendimento.Enabled = false;
      btnFinalizarAtendimento.Enabled = true;
      btnProximo.Enabled = true;
      (new WsPhito.Service(Config.WebService)).IniciarAtendimento(Tab.ATD_CODIGO, Guiche);
    }

    private void btnFinalizarAtendimento_Click(object sender, EventArgs e)
    {
      try
      { (new WsPhito.Service(Config.WebService)).FinalizarAtendimento(Tab.ATD_CODIGO, true); }
      catch { lib.Visual.Msg.Warning(MsgErro); }
      finally { this.Close(); }
    }

    private void btnProximo_Click(object sender, EventArgs e)
    {
      try
      { (new WsPhito.Service(Config.WebService)).FinalizarAtendimento(Tab.ATD_CODIGO, false); }
      catch { lib.Visual.Msg.Warning(MsgErro); }
      finally { this.Close(); }
    }

  }
}
