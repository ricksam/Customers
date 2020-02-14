using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo.View
{
  public partial class CorrigirItem : lib.Visual.Models.frmBase
  {
    public CorrigirItem()
    {
      InitializeComponent();
    }

    dsFNI_FINANCEIRO_ITEM dsFni = new dsFNI_FINANCEIRO_ITEM(Utilities.Cnn);

    private void CarregarItens() 
    {
      
      string[] items = dsFni.GetDescricaoList();

      cmbItem.Items.Clear();
      cmbCorrigir.Items.Clear();

      cmbItem.Items.AddRange(items);
      cmbCorrigir.Items.AddRange(items);
    }

    private void CorrigirItem_Load(object sender, EventArgs e)
    {
      CarregarItens();
    }

    private void btnCorrigir_Click(object sender, EventArgs e)
    {
      string xmsg=string.Format( "Tem certeza que deseja alterar o item {0} para {1}",cmbItem.Text,cmbCorrigir.Text);
      if (lib.Visual.Msg.Question(xmsg))
      {
        dsFni.CorrigirItem(cmbItem.Text, cmbCorrigir.Text);
        CarregarItens();
        lib.Visual.Msg.Information("Alteração realizada com sucesso!");
      }
    }
  }
}
