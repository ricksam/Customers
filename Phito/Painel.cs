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
  public partial class Painel : Form
  {
    #region public Painel()
    public Painel()
    {
      InitializeComponent();
    }
    #endregion

    #region Fields
    string LastSenha { get; set; }
    WsPhito.Service Service { get; set; }
    Config Config { get; set; }
    #endregion

    #region private void Carregar()
    private void Carregar() 
    {
      Config = new Config();
      Config.Open();

      Service = new WsPhito.Service(Config.WebService);
    }
    #endregion

    #region protected override void OnKeyDown(KeyEventArgs e)
    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.Escape)
      {
        this.Close();
      }
      base.OnKeyDown(e);
    }
    #endregion

    #region private void CriaLabels(string Senha, int Guiche, int pos)
    private void CriaLabels(string Senha, int Guiche, int pos) 
    {
      Label lSenha = new Label();
      lSenha.Font = new System.Drawing.Font("Arial", 24, FontStyle.Bold);
      lSenha.Text = Senha;
      lSenha.Top = 2 + (pos * 50);
      lSenha.Left = 2;
      lSenha.AutoSize = true;
            
      Label lGuiche = new Label();
      lGuiche.Font = new System.Drawing.Font("Arial", 24, FontStyle.Bold);
      lGuiche.Text = "Guiche: " + Guiche;
      lGuiche.Top = 2 + (pos * 50);
      lGuiche.Left = 180;
      lGuiche.AutoSize = true;

      pnlAnteriores.Controls.Add(lSenha);
      pnlAnteriores.Controls.Add(lGuiche);

      pnlAnteriores.ResumeLayout();
      pnlAnteriores.PerformLayout();
    }
    #endregion

    #region Events
    private void Painel_Load(object sender, EventArgs e)
    {
      pnlDisplay.Top = (this.Height - pnlDisplay.Height) / 2;
      pnlDisplay.Left = (this.Width - pnlDisplay.Width) / 2;

      Carregar();
    }

    private void tmrDisplay_Tick(object sender, EventArgs e)
    {
      tmrDisplay.Enabled = false;
      try
      {
        WsPhito.ATD_ATENDIMENTO[] list = Service.ExibePainel(Config.Loja);

        if (list.Length != 0 && LastSenha != list[0].ATD_SENHA)
        {
          // Limpa controls
          while (pnlAnteriores.Controls.Count != 0)
          {
            pnlAnteriores.Controls[0].Dispose();
            pnlAnteriores.Controls.RemoveAt(0);
          }

          // Cria Labels
          for (int i = 1; i < list.Length && i < 8; i++)
          { CriaLabels(list[i].ATD_SENHA, list[i].ATD_GUICHE, i - 1); }

          //Emite SOM

          // Exibe User
          lblSenha.Text = list[0].ATD_SENHA;

          lblNome.Text = "";
          if (imgFoto.Image != null)
          {
            imgFoto.Image.Dispose();
            imgFoto.Image = null;
            imgFoto.Visible = false;
          }

          lblGuiche.Text = "Guiche: " + list[0].ATD_GUICHE;
          LastSenha = list[0].ATD_SENHA;

          WsPhito.UserPhito User = Service.GetUsuario(list[0].ATD_SENHA);
          if (!string.IsNullOrEmpty(User.Nome))
          {
            lblNome.Text = "Nome: " + User.Nome;
            imgFoto.Image = new Bitmap((new lib.Class.Download(256)).ToStream(User.Foto));
            imgFoto.Visible = true;
          }
        }
      }
      catch { }
      tmrDisplay.Enabled = true;
    }
    #endregion
  }
}
