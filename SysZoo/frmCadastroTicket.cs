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
  public partial class frmCadastroTicket : frmBase
  {
    public frmCadastroTicket()
    {
      InitializeComponent();
    }

    SZO_CTK_CADASTRO_TICKETS Ctk = new SZO_CTK_CADASTRO_TICKETS();

    private void frmCadastroTicket_Load(object sender, EventArgs e)
    {
      Listar();
    }

    private void Listar() 
    {
      SZO_CTK_CADASTRO_TICKETS[] tickets = (new dsSZO_CTK_CADASTRO_TICKETS(Utilities.GetDatabase())).List_Ativos();
      grdTickets.AutoGenerateColumns = false;
      grdTickets.DataSource = tickets;
    }

    private void Editar(SZO_CTK_CADASTRO_TICKETS ctk) 
    {
      Ctk = ctk;
      txtDescricao.Text = ctk.CTK_DESCRICAO;
      txtValor.Text = ctk.CTK_VALOR.ToString("0.00");
      cbDOM.Checked = ctk.CTK_DOM;
      cbSEG.Checked = ctk.CTK_SEG;
      cbTER.Checked = ctk.CTK_TER;
      cbQUA.Checked = ctk.CTK_QUA;
      cbQUI.Checked = ctk.CTK_QUI;
      cbSEX.Checked = ctk.CTK_SEX;
      cbSAB.Checked = ctk.CTK_SAB;
      txtAtalho.Text = ctk.CTK_ATALHO;
      txtDescricao.Select();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      cbDOM.Checked = true;
      cbSEG.Checked = true;
      cbTER.Checked = true;
      cbQUA.Checked = true;
      cbQUI.Checked = true;
      cbSEX.Checked = true;
      cbSAB.Checked = true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      cbDOM.Checked = false;
      cbSEG.Checked = false;
      cbTER.Checked = false;
      cbQUA.Checked = false;
      cbQUI.Checked = false;
      cbSEX.Checked = false;
      cbSAB.Checked = false;
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      Editar(new SZO_CTK_CADASTRO_TICKETS());
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtDescricao.Text))
      {
        Utilities.MsgAlert("Informe a descrição do ticket");
        txtDescricao.Select();
        return;
      }

      lib.Class.Conversion cnv = new lib.Class.Conversion();
      Ctk.CTK_SINCRONIZADO = false;
      Ctk.CTK_DESCRICAO = txtDescricao.Text;
      Ctk.CTK_VALOR = cnv.ToDecimal(txtValor.Text);
      Ctk.CTK_DOM = cbDOM.Checked;
      Ctk.CTK_SEG = cbSEG.Checked;
      Ctk.CTK_TER = cbTER.Checked;
      Ctk.CTK_QUA = cbQUA.Checked;
      Ctk.CTK_QUI = cbQUI.Checked;
      Ctk.CTK_SEX = cbSEX.Checked;
      Ctk.CTK_SAB = cbSAB.Checked;
      Ctk.CTK_ATALHO = txtAtalho.Text;
      (new dsSZO_CTK_CADASTRO_TICKETS(Utilities.GetDatabase())).Save(Ctk);
      Listar();
    }

    private void grdTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (grdTickets.SelectedRows.Count != 0)
      { Editar((SZO_CTK_CADASTRO_TICKETS)grdTickets.SelectedRows[0].DataBoundItem); }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if (grdTickets.SelectedRows.Count != 0)
      {
        SZO_CTK_CADASTRO_TICKETS ticket = (SZO_CTK_CADASTRO_TICKETS)grdTickets.SelectedRows[0].DataBoundItem;
        if (Utilities.MsgQuestion(string.Format("Tem certeza que deseja excluir o ticket {0} de {1}", ticket.CTK_DESCRICAO, ticket.CTK_VALOR.ToString("0.00"))))
        {
          ticket.CTK_SINCRONIZADO = false;
          ticket.CTK_INATIVO = true;
          (new dsSZO_CTK_CADASTRO_TICKETS(Utilities.GetDatabase())).Save(ticket);
          Listar();
        }
      }
      else
      { Utilities.MsgAlert("Selecione um ticket para excluir!"); }
    }


  }
}
