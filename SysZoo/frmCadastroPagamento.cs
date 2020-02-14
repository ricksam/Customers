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
  public partial class frmCadastroPagamento : frmBase
  {
    public frmCadastroPagamento()
    {
      InitializeComponent();
    }

    private void Listar() 
    {
      lstFormas.DataSource = (new dsSZO_FPG_FORMA_PAGAMENTO(Utilities.GetDatabase())).List_Ativos();
      txtForma.Select();
    }

    private void frmCadastroPagamento_Load(object sender, EventArgs e)
    {
      Listar();
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtForma.Text))
      {
        Utilities.MsgAlert("Informe uma forma de pagamento");
        txtForma.Select();
        return;
      }

      SZO_FPG_FORMA_PAGAMENTO fpg = new SZO_FPG_FORMA_PAGAMENTO();
      fpg.FPG_SINCRONIZADO = false;
      fpg.FPG_DESCRICAO = txtForma.Text;
      (new dsSZO_FPG_FORMA_PAGAMENTO(Utilities.GetDatabase())).Save(fpg);
      txtForma.Text = "";
      Listar();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      SZO_FPG_FORMA_PAGAMENTO fpg = ((SZO_FPG_FORMA_PAGAMENTO)lstFormas.SelectedItem);
      if (fpg != null)
      {
        if (Utilities.MsgQuestion(string.Format("Tem certeza que deseja remover a forma {0}", fpg.FPG_DESCRICAO)))
        {
          fpg.FPG_SINCRONIZADO = false;
          fpg.FPG_INATIVO = true;
          (new dsSZO_FPG_FORMA_PAGAMENTO(Utilities.GetDatabase())).Save(fpg);
          Listar();
        }
      }
    }
  }
}
