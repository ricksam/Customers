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
  public enum enmOperacao {Ticket, Venda, Pagamento }

  public partial class frmVendaTicket : frmBase
  {
    public frmVendaTicket()
    {
      InitializeComponent();
      dadosSZO.StatusSZO += new StatusSZO_Event(OnStatusSZO);
    }

    DadosSZO dadosSZO = new DadosSZO(lib.Class.Utils.GetVersion());
    SZO_CFG_CONFIG Config = new SZO_CFG_CONFIG();
    SZO_OPR_OPERADORES Operador = new SZO_OPR_OPERADORES();

    private void OnStatusSZO(string msg) 
    {
      this.BeginInvoke((Action)delegate() {
        lblProcessoInternet.Text = msg;
        lblProcessoInternet.Refresh();
      });
    }

    private void Carregar() 
    {
      AjustaDisplay();
      lblWindowTitle.Text = "Venda Ticket " + lib.Class.Utils.GetVersion() + " [F1] Ajuda | Animal Day:" + (new AnimalDay()).getAnimal();
      Config = (new dsSZO_CFG_CONFIG(Utilities.GetDatabase())).Get();
      lblCOM.Text = Config.CFG_PRINTER_PORT;
      CarregaTicketForma();
      CarregaOperador();
    }
    
    private void SelecionaOperacao(enmOperacao Operacao) 
    {
      switch (Operacao)
      {
        case enmOperacao.Ticket:
          {
            lstTickets.BackColor = base.CorAmarelo;
            lstVenda.BackColor = base.CorBranco;
            lstPgto.BackColor = base.CorCinza;
            lstTickets.Select();
            break;
          }
        case enmOperacao.Venda:
          {
            lstTickets.BackColor = base.CorCinza;
            lstVenda.BackColor = base.CorAmarelo;
            lstPgto.BackColor = base.CorCinza;
            lstVenda.Select();
            break;
          }
        case enmOperacao.Pagamento:
          {
            lstTickets.BackColor = base.CorCinza;
            lstVenda.BackColor = base.CorBranco;
            lstPgto.BackColor = base.CorAmarelo;
            lstPgto.Select();
            break;
          }
        default: 
          {
            lstTickets.BackColor = base.CorCinza;
            lstVenda.BackColor = base.CorBranco;
            lstPgto.BackColor = base.CorAmarelo;
            lstPgto.Select();
            break;
          }
      }
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.F1) { (new frmAjuda()).ShowDialog(); }
      else if (e.KeyData == Keys.T) { SelecionaOperacao(enmOperacao.Ticket); }
      else if (e.KeyData == Keys.Multiply) { VendaLote(); }
      else if (e.KeyData == Keys.V) { SelecionaOperacao(enmOperacao.Venda); }
      else if (e.KeyData == Keys.P) { SelecionaOperacao(enmOperacao.Pagamento); }
      else if (e.KeyData == Keys.Delete) 
      { Cancelaritem(); }
      else if (e.KeyData == Keys.I)
      { ImprimeTicket(); }
      else if (e.KeyData == Keys.Right)
      {
        if (lstTickets.Focused) { SelecionaOperacao(enmOperacao.Venda); }
        else if (lstVenda.Focused) { SelecionaOperacao(enmOperacao.Pagamento); }
      }
      else if (e.KeyData == Keys.Left)
      {
        if (lstPgto.Focused) { SelecionaOperacao(enmOperacao.Venda); }
        else if (lstVenda.Focused) { SelecionaOperacao(enmOperacao.Ticket); }
      }

      // Eh Atalho venda
      for (int i = 0; i < lstTickets.Items.Count; i++)
      {
        if (((SZO_CTK_CADASTRO_TICKETS)lstTickets.Items[i]).CTK_ATALHO == e.KeyData.ToString())
        {
          lstTickets.SelectedIndex = i;
          VendaUnitario(); 
        }
      }
      

      base.OnKeyDown(e);
    }

    private bool PossuiItens()
    {
      for (int i = 0; i < lstVenda.Items.Count; i++)
      {
        if (lstVenda.Items[i] is SZO_VTK_VENDA_TICKETS)
        { return true; }
      }
      return false;
    }

    private bool PossuiPagamentos()
    {
      for (int i = 0; i < lstVenda.Items.Count; i++)
      {
        if (lstVenda.Items[i] is SZO_PGT_PAGAMENTO)
        { return true; }
      }
      return false;
    }

    private void RetornaTotais(out int QtdeItens, out decimal TotalItens, out decimal TotalPago)
    {
      QtdeItens = 0;
      TotalItens = 0;
      TotalPago = 0;

      for (int i = 0; i < lstVenda.Items.Count; i++)
      {
        if (lstVenda.Items[i] is SZO_VTK_VENDA_TICKETS)
        {
          TotalItens += ((SZO_VTK_VENDA_TICKETS)lstVenda.Items[i]).VTK_VALOR;
          QtdeItens++;
        }

        if (lstVenda.Items[i] is SZO_PGT_PAGAMENTO)
        { TotalPago += ((SZO_PGT_PAGAMENTO)lstVenda.Items[i]).PGT_VALOR; }
      }
    }

    private void CarregaTicketForma()
    {
      SelecionaOperacao(enmOperacao.Ticket);
      lstTickets.DataSource = (new dsSZO_CTK_CADASTRO_TICKETS(Utilities.GetDatabase())).List_Hoje();
      lstPgto.DataSource = (new dsSZO_FPG_FORMA_PAGAMENTO(Utilities.GetDatabase())).List_Ativos();
      LimpaVenda();
    }

    private void LimpaVenda()
    {
      lstVenda.Items.Clear();

      int qtde_itens = 0;
      decimal tot_itens = 0;
      decimal tot_pago = 0;
      RetornaTotais(out qtde_itens, out tot_itens, out tot_pago);

      lblTotal.Text = tot_itens.ToString("0.00");

      SelecionaOperacao(enmOperacao.Ticket);

      dadosSZO.PausarProcesso = false;
    }

    private void ImprimeTicket() 
    {
      int QtdeItens = 0;
      decimal TotalItem = 0;
      decimal TotalPago = 0;
      RetornaTotais(out QtdeItens, out TotalItem,out TotalPago);

      if (QtdeItens == 0) 
      {
        Utilities.MsgAlert("Informe os itens");
        return;
      }

      /*if (TotalPago == 0)
      {
        Utilities.MsgAlert("Informe as formas de pagamento");
        return;
      }*/

      if (TotalPago < TotalItem)
      {
        Utilities.MsgAlert("O total pago não pode ser menor que o total dos itens");
        return;
      }

      if (QtdeItens != 0 && TotalPago >= TotalItem)
      {
        lib.Entity.SQLite db = Utilities.GetDatabase();
        dsSZO_VDA_VENDA dsVda = new dsSZO_VDA_VENDA(db);
        dsSZO_VTK_VENDA_TICKETS dsVtk = new dsSZO_VTK_VENDA_TICKETS(db);
        dsSZO_PGT_PAGAMENTO dsPgt = new dsSZO_PGT_PAGAMENTO(db);

        string msg_erro = "";
        List<SZO_VTK_VENDA_TICKETS> Imprimir = new List<SZO_VTK_VENDA_TICKETS>();

        db.DbConnection.Open();
        System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();

        try
        {
          SZO_VDA_VENDA Vda = new SZO_VDA_VENDA();
          Vda.VDA_IDENTIFICACAO = Config.CFG_IDENTIFICACAO;
          Vda.VDA_MOVIMENTO = Config.CFG_MOVIMENTO;
          Vda.VDA_OPR_MD5 = Operador.OPR_MD5;
          Vda.VDA_TOTAL = TotalItem;
          Vda.VDA_TOTAL_PAGO = TotalPago;
          Vda.VDA_TROCO = TotalPago - TotalItem;
          dsVda.Save(Vda, transaction);
          /*if (Vda.VDA_CODIGO == 0)
          {
            Vda.VDA_CODIGO = db.ReturnLastID(transaction).ToInt();
          }*/

          for (int i = 0; i < lstVenda.Items.Count; i++)
          {
            if (lstVenda.Items[i] is SZO_VTK_VENDA_TICKETS)
            {
              SZO_VTK_VENDA_TICKETS ticket = (SZO_VTK_VENDA_TICKETS)lstVenda.Items[i];
              ticket.VTK_VDA_MD5 = Vda.VDA_MD5;
              dsVtk.Save(ticket, transaction);
              /*if (ticket.VTK_CODIGO == 0)
              {
                ticket.VTK_CODIGO = db.ReturnLastID(transaction).ToInt();
              }*/
              Imprimir.Add(ticket);
            }
            else if (lstVenda.Items[i] is SZO_PGT_PAGAMENTO)
            {
              SZO_PGT_PAGAMENTO pagamento = (SZO_PGT_PAGAMENTO)lstVenda.Items[i];
              pagamento.PGT_VDA_MD5 = Vda.VDA_MD5;
              dsPgt.Save(pagamento, transaction);
            }
          }

          transaction.Commit();
        }
        catch(Exception ex)
        {
          msg_erro = ex.Message;
          transaction.Rollback();
          Imprimir.Clear();
        }
        finally
        {
          if (db.DbConnection.State != ConnectionState.Closed)
          { db.DbConnection.Close(); }
        }

        if (Imprimir.Count != 0)
        {
          SZO_CTK_CADASTRO_TICKETS[] tabela = (new dsSZO_CTK_CADASTRO_TICKETS(db)).List_Hoje();
          Utilities.ImprimeTicket(Imprimir.ToArray(), tabela, Config.CFG_PRINTER_PORT, Config.CFG_PRINTER_VELOCITY, Config.CFG_IMPRIMIR_INDIVIDUAL);
          LimpaVenda();
        }
        else
        { Utilities.MsgAlert(msg_erro); }
      }
    }

    private void AjustaDisplay() 
    {
      pnlDisplay.Left = (this.Width / 2) - (pnlDisplay.Width / 2);
      pnlDisplay.Top = (this.Height / 2) - (pnlDisplay.Height / 2);
    }

    private void CarregaOperador() 
    {
      lib.Entity.SQLite db = Utilities.GetDatabase();

      if (Config.CFG_OPR_CODIGO != 0)
      {
        Operador = (new dsSZO_OPR_OPERADORES(db)).Get(Config.CFG_OPR_CODIGO);
        lblOperador.Text = "Operador: " + Operador.OPR_NOME;
      }

      if (Operador.OPR_CODIGO == 0)
      {
        Operador = Utilities.RetornaOperador();
        lblOperador.Text = "Operador: " + Operador.OPR_NOME;

        if (Operador.OPR_CODIGO != 0)
        {
          Config.CFG_OPR_CODIGO = Operador.OPR_CODIGO;
          Config.CFG_MOVIMENTO = DateTime.Now;
          (new dsSZO_CFG_CONFIG(db)).Save(Config);
        }
      }
    }

    private void Cancelaritem()
    {
      if (!Operador.OPR_CANCELAR_ITEM) 
      {
        SZO_OPR_OPERADORES opr = Utilities.RetornaOperador();
        if (!opr.OPR_CANCELAR_ITEM)
        {
          Utilities.MsgAlert("Acesso negado!");
          return;
        }
      }

      if (lstVenda.SelectedIndex != -1 && !PossuiPagamentos())
      {
        lstVenda.Items.RemoveAt(lstVenda.SelectedIndex);
        if (lstVenda.Items.Count != 0)
        { lstVenda.SelectedIndex = lstVenda.Items.Count - 1; }

        int qtde_itens = 0;
        decimal tot_itens = 0;
        decimal tot_pago = 0;
        RetornaTotais(out qtde_itens, out tot_itens, out tot_pago);

        if (qtde_itens == 0)
        { dadosSZO.PausarProcesso = false; }

        SelecionaOperacao(enmOperacao.Ticket);
        lblTotal.Text = tot_itens.ToString("0.00");
      }
    }

    private void LancaTicket(SZO_CTK_CADASTRO_TICKETS ticket) 
    {
      if (!lib.Class.WebUtils.IsNetworkAlive())
      {
        Utilities.MsgAlert("Cabo de rede desconectado!");
        return;
      }

      CarregaOperador();

      if (Operador.OPR_CODIGO != 0)
      {
        dadosSZO.PausarProcesso = true;

        SZO_VTK_VENDA_TICKETS VTicket = new SZO_VTK_VENDA_TICKETS();
        VTicket.VTK_CTK_MD5 = ticket.CTK_MD5;
        VTicket.VTK_DATA = DateTime.Now;
        VTicket.VTK_DESCRICAO = ticket.CTK_DESCRICAO;
        VTicket.VDA_MOVIMENTO = Config.CFG_MOVIMENTO;
        VTicket.VTK_IDENTIFICACAO = Config.CFG_IDENTIFICACAO;
        VTicket.VTK_OPR_MD5 = Operador.OPR_MD5;
        VTicket.VTK_VALOR = ticket.CTK_VALOR;
        lstVenda.Items.Add(VTicket);
        lstVenda.SelectedIndex = lstVenda.Items.Count - 1;

        int qtde_itens = 0;
        decimal tot_itens = 0;
        decimal tot_pago = 0;
        RetornaTotais(out qtde_itens, out tot_itens, out tot_pago);

        SelecionaOperacao(enmOperacao.Ticket);
        lblTotal.Text = tot_itens.ToString("0.00");
      }
    }

    private void VendaUnitario()
    {
      if (lstTickets.SelectedIndex != -1)
      {
        if (PossuiPagamentos())
        {
          Utilities.MsgAlert("Já existem formas de pagamentos lançadas");
          return;
        }

        SZO_CTK_CADASTRO_TICKETS ticket = ((SZO_CTK_CADASTRO_TICKETS)lstTickets.SelectedItem);
        LancaTicket(ticket);
      }
    }

    private void VendaLote()
    {
      if (lstTickets.SelectedIndex != -1)
      {
        if (PossuiPagamentos())
        {
          Utilities.MsgAlert("Já existem formas de pagamentos lançadas");
          return;
        }

        SZO_CTK_CADASTRO_TICKETS ticket = ((SZO_CTK_CADASTRO_TICKETS)lstTickets.SelectedItem);
        int Qtde = Utilities.RetornaQtde();
        for (int i = 0; i < Qtde; i++)
        { LancaTicket(ticket); }
      }
    }

    private void LancaFormaPgto() 
    {
      if (lstTickets.SelectedIndex != -1)
      {
        if (!PossuiItens())
        {
          Utilities.MsgAlert("Faltam itens nesta venda");
          return;
        }

        int qtde_itens = 0;
        decimal tot_itens = 0;
        decimal tot_pago = 0;
        RetornaTotais(out qtde_itens, out tot_itens, out tot_pago);

        if (tot_pago > tot_itens)
        {
          Utilities.MsgAlert("Lançamentos encerrados.\r\nClique em imprimir ou cancelar.");
          return;
        }

        decimal valor = Utilities.RetornaValor();
        if (valor != 0)
        {
          if (lstPgto.Items.Count == 0)
          {
            Utilities.MsgAlert("Não existem formas de pagamentos cadastradas!");
            return;
          }

          if (!PossuiPagamentos())
          { lstVenda.Items.Add("--------------------"); }

          SZO_FPG_FORMA_PAGAMENTO forma = ((SZO_FPG_FORMA_PAGAMENTO)lstPgto.SelectedItem);
          SZO_PGT_PAGAMENTO pg = new SZO_PGT_PAGAMENTO();
          pg.PGT_IDENTIFICACAO = Config.CFG_IDENTIFICACAO;
          pg.PGT_MOVIMENTO = Config.CFG_MOVIMENTO;
          pg.PGT_OPR_MD5 = Operador.OPR_MD5;
          pg.PGT_FPG_MD5 = forma.FPG_MD5;
          pg.PGT_DESCRICAO = forma.FPG_DESCRICAO;
          pg.PGT_VALOR = valor;
          lstVenda.Items.Add(pg);


          if ((tot_pago + valor) >= tot_itens)
          {
            decimal Troco = (tot_pago + valor) - tot_itens;
            lstVenda.Items.Add("--------------------");
            lstVenda.Items.Add("Troco" + Troco.ToString("0.00").PadLeft(15));
          }

          lstVenda.SelectedIndex = lstVenda.Items.Count - 1;
        }
      }
    }

    private void frmVendaTicket_Load(object sender, EventArgs e)
    {
      lblDataHora.Text = DateTime.Now.ToString("dd/MM/yy HH:mm");
      Carregar();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      //dadosSZO.AtualizaCadastros();

      //frmGerencia f = new frmGerencia();
      //f.SetGerencia(Operador.OPR_GERENCIA);
      //f.ShowDialog();

      frmMenu f = new frmMenu();
      f.SetGerencia(Operador.OPR_GERENCIA, dadosSZO);
      f.ShowDialog();
      Carregar();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      frmSair f = new frmSair();
      f.ShowDialog();

      if (f.EncerrarMovimento)
      {
        Operador = new SZO_OPR_OPERADORES();
        if (!f.FecharPrograma)
        { Carregar(); }
      }
      
      if (f.FecharPrograma)
      { this.Close(); }
    }

    private void CancelarVenda() 
    {
      if (lstVenda.Items.Count != 0)
      {
        if (!Operador.OPR_CANCELAR_CUPOM)
        {
          SZO_OPR_OPERADORES opr = Utilities.RetornaOperador();
          if (!opr.OPR_CANCELAR_CUPOM)
          {
            Utilities.MsgAlert("Acesso negado!");
            return;
          }
        }

        if (Utilities.MsgQuestion("Tem certeza que deseja cancelar esta venda"))
        { LimpaVenda(); }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      
        CancelarVenda();
      
    }

    private void lstTickets_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        VendaUnitario();
      }
    }

    private void lstPgto_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter )
      {
        LancaFormaPgto();
      }
    }

    private void btnUnitario_Click(object sender, EventArgs e)
    {
      VendaUnitario();
    }

    private void btnLote_Click(object sender, EventArgs e)
    {
      VendaLote();
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
      ImprimeTicket();
    }

    private void btnCancelarItem_Click(object sender, EventArgs e)
    {
      Cancelaritem();
    }

    private void tmrDataHora_Tick(object sender, EventArgs e)
    {
      lblDataHora.Text = DateTime.Now.ToString("dd/MM/yy HH:mm");
    }

    private void frmVendaTicket_FormClosed(object sender, FormClosedEventArgs e)
    {
      dadosSZO.PararProcesso = true;
    }

    private void lstTickets_Click(object sender, EventArgs e)
    {
      SelecionaOperacao(enmOperacao.Ticket);
    }

    private void lstVenda_Click(object sender, EventArgs e)
    {
      SelecionaOperacao(enmOperacao.Venda);
    }

    private void lstPgto_Click(object sender, EventArgs e)
    {
      SelecionaOperacao(enmOperacao.Pagamento);
    }
  }
}
