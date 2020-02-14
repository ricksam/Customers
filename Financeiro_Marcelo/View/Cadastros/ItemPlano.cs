using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using lib.Class;
using lib.Visual;

namespace Financeiro_Marcelo
{
  public partial class ItemPlano : lib.Visual.Models.frmDialog
  {
    public ItemPlano()
    {
      InitializeComponent();
    }

    public PLN_PLANOCONTAS Tab { get; set; }

    private void Carregar() 
    {
      txtDescricao.Text = Tab.PLN_DESCRICAO;
      txtPrioridade.AsInt = Tab.PLN_PRIORIDADE;
      cbObrigaDescricao.Checked = Tab.PLN_OBRIGA_DESCRICAO;
      cbConferencia.Checked = Tab.PLN_CONFERENCIA;
      cbAdicionaItens.Checked = Tab.PLN_ADICIONA_ITENS;
    }

    private bool FaltaPreencher() 
    {
      LockedField[] lf = (new dsPLN_PLANOCONTAS(Utilities.Cnn)).GetLockedFields(Tab);
      
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "PLN_DESCRICAO")
        { txtDescricao.Select(); }        
      }

      return lf.Length != 0;
    }

    protected override void OnConfirm()
    {
      Tab.PLN_DESCRICAO = txtDescricao.Text;
      Tab.PLN_PRIORIDADE = txtPrioridade.AsInt;
      Tab.PLN_OBRIGA_DESCRICAO = cbObrigaDescricao.Checked;
      Tab.PLN_CONFERENCIA = cbConferencia.Checked;
      Tab.PLN_ADICIONA_ITENS = cbAdicionaItens.Checked;

      if (!FaltaPreencher())
      { base.OnConfirm(); }
    }

    private void ItemPlano_Load(object sender, EventArgs e)
    {
      Carregar();
    }
  }
}
