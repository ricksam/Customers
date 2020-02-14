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
  public partial class Atendente : Form
  {
    public Atendente()
    {
      InitializeComponent();
    }

    WsPhito.Service Service { get; set; }
    Config Config { get; set; }

    private void Carregar()
    {
      Config = new Config();
      Config.Open();

      Service = new WsPhito.Service(Config.WebService);

      lblInfo.Text = "Guiche: " + Config.Guiche;

      if (Config.Guiche == 0)
      { lib.Visual.Msg.Warning("Ainda não foi configurado o número deste guiche"); }

      Atualizar();
    }


    #region public int GetQtde(string Assunto, WsPhito.Assunto[] Assuntos)
    public int GetQtde(string Assunto, WsPhito.Assunto[] Assuntos)
    {
      for (int i = 0; i < Assuntos.Length; i++)
      {
        if (Assunto.ToUpper() == Assuntos[i].Descricao.ToUpper())
        { return Assuntos[i].Qtde; }
      }
      return 0;
    }
    #endregion

    private void Atualizar() 
    {
      try
      {
        WsPhito.Assunto[] Assuntos = Service.List(Config.Loja);

        btnAtendimento.Text = string.Format("Atendimento ({0})", GetQtde(Utility.ASSUNTO_ATENDIMENTO, Assuntos));
        btnRetiradaFormulas.Text = string.Format("Retirada de Formulas ({0})", GetQtde(Utility.ASSUNTO_RETIRADAFORMULA, Assuntos));
        btnConsulta.Text = string.Format("Consulta ({0})", GetQtde(Utility.ASSUNTO_CONSULTA, Assuntos));
      }
      catch { lib.Visual.Msg.Warning("Houve um erro ao carregar os atendimentos. Verifique se há conexão com a internet e pressione F5"); }
    }
    
    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.F5)
      { Atualizar(); }
      base.OnKeyDown(e);
    }

    

    #region
    private void ExibirAtendimento(string Assunto, string ButtonText) 
    {
      if (ButtonText.IndexOf("(0)") != -1)
      {
        lib.Visual.Msg.Warning("Não há atendimentos para este assunto");
        return;
      }

      Atender f = new Atender();
      f.Guiche = Config.Guiche;
      f.Tab = Service.GetNext(Config.Loja, Assunto);
      f.ShowDialog();
      Atualizar();
    }
    #endregion

    #region private void Atendente_Load(object sender, EventArgs e)
    private void Atendente_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    #endregion

    #region Botões de Atendimento
    private void btnAtendimento_Click(object sender, EventArgs e)
    {
      ExibirAtendimento(Utility.ASSUNTO_ATENDIMENTO, ((Button)sender).Text);
    }

    private void btnRetiradaFormulas_Click(object sender, EventArgs e)
    {
      ExibirAtendimento(Utility.ASSUNTO_RETIRADAFORMULA, ((Button)sender).Text);
    }

    private void btnConsulta_Click(object sender, EventArgs e)
    {
      ExibirAtendimento(Utility.ASSUNTO_CONSULTA, ((Button)sender).Text);
    }
    #endregion
  }
}
