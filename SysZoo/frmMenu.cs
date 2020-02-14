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
  public partial class frmMenu : frmBase
  {
    public frmMenu()
    {
      InitializeComponent();
    }

    bool Gerente{get;set;}
    DadosSZO dadosSZO{get;set;}

    public void SetGerencia(bool Gerente, DadosSZO dadosSZO)
    {
      this.Gerente = Gerente;
      this.dadosSZO = dadosSZO;
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

    private void btnConfiguracao_Click(object sender, EventArgs e)
    {
      //frmConfiguracao f = new frmConfiguracao();
      //f.ShowDialog();

      dadosSZO.AtualizaCadastros();
      frmGerencia f = new frmGerencia();
      f.SetGerencia(Gerente);
      f.ShowDialog();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void InformaMovimento(string Movimento) 
    {
      decimal valor = Utilities.RetornaValor();
      if (valor != 0)
      {
        lib.Entity.SQLite db = Utilities.GetDatabase();
        SZO_CFG_CONFIG Config = (new dsSZO_CFG_CONFIG(db)).Get();

        dsSZO_MCX_MOVIMENTO_CAIXA dsMcx = new dsSZO_MCX_MOVIMENTO_CAIXA(db);
        SZO_MCX_MOVIMENTO_CAIXA mcx = new SZO_MCX_MOVIMENTO_CAIXA();
        mcx.MCX_DATA = DateTime.Now;
        mcx.MCX_IDENTIFICACAO = Config.CFG_IDENTIFICACAO;
        mcx.MCX_MOVIMENTO = Config.CFG_MOVIMENTO;
        mcx.MCX_TIPO = Movimento;
        mcx.MCX_VALOR = valor;
        dsMcx.Save(mcx);
        Utilities.ImprimeMovimento(Config.CFG_PRINTER_PORT, Config.CFG_PRINTER_VELOCITY, mcx);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      InformaMovimento("SANGRIA");
    }

    private void btnSuprimento_Click(object sender, EventArgs e)
    {
      InformaMovimento("SUPRIMENTO");
    }
  }
}
