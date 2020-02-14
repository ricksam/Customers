using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo
{
  public partial class Configuracoes : lib.Visual.Models.frmDialog
  {
    public Configuracoes()
    {
      InitializeComponent();
      Cfg = new Config();
      Cfg.Open();
    }

    Config Cfg { get; set; }
    
    private void Carregar() 
    {
      txtNrRegForm.AsInt = Cfg.NrFormulariosTelaInicial;
      cbRemoveOnLine.Checked = Cfg.RemoveVendasOnLine;
      txtServidor.Text = Cfg.Email.Servidor;
      txtUsuario.Text = Cfg.Email.Usuario;
      txtSenha.Text = Cfg.Email.Senha;
      cbHabilitaSSL.Checked = Cfg.Email.HabilitaSSL;
      cbRequerAutenticacao.Checked = Cfg.Email.RequerAutenticacao;
      txtPorta.AsInt = Cfg.Email.Porta;
      txtPastaCopiaBkp.Text = Cfg.PastaCopiaBackup;
    }

    protected override void OnConfirm()
    {
      Cfg.NrFormulariosTelaInicial = txtNrRegForm.AsInt;
      Cfg.RemoveVendasOnLine = cbRemoveOnLine.Checked;
      Cfg.Email.Servidor = txtServidor.Text;
      Cfg.Email.Usuario = txtUsuario.Text;
      Cfg.Email.Senha = txtSenha.Text;
      Cfg.Email.HabilitaSSL = cbHabilitaSSL.Checked;
      Cfg.Email.RequerAutenticacao = cbRequerAutenticacao.Checked;
      Cfg.Email.Porta = txtPorta.AsInt;
      Cfg.PastaCopiaBackup = txtPastaCopiaBkp.Text;
      Cfg.Save();
      base.OnConfirm();
    }

    private void sknButton1_Click(object sender, EventArgs e)
    {
      View.Ajuda.ListaEMail le = new View.Ajuda.ListaEMail();
      le.ShowDialog();      
    }

    private void Configuracoes_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (dlgBkp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      { txtPastaCopiaBkp.Text = dlgBkp.SelectedPath; }
    }
  }
}
