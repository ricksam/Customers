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
  public partial class Configuracao : lib.Visual.Models.frmEdit
  {
    public Configuracao()
    {
      InitializeComponent();
    }

    Config Config { get; set; }

    private void Carregar() 
    {
      Config = new Config();
      Config.Open();

      txtLoja.Text = Config.Loja;
      txtGuiche.AsInt = Config.Guiche;
      txtPortaImpressora.Text = Config.PortaImpressora;
      txtWebService.Text = Config.WebService;
    }

    private void Configuracao_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    protected override void OnConfirm()
    {
      Config.Loja = txtLoja.Text;
      Config.Guiche = txtGuiche.AsInt;
      Config.PortaImpressora = txtPortaImpressora.Text;
      Config.WebService = txtWebService.Text;
      Config.Save();

      base.OnConfirm();
    }
  }
}
