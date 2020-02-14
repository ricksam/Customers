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
  public partial class frmCadastroOperadores : frmBase
  {
    public frmCadastroOperadores()
    {
      InitializeComponent();
    }

    SZO_OPR_OPERADORES Opr = new SZO_OPR_OPERADORES();

    private void Listar() 
    {
      grdOperadores.AutoGenerateColumns = false;
      grdOperadores.DataSource = (new dsSZO_OPR_OPERADORES(Utilities.GetDatabase())).List_Ativos();
    }

    private void Editar(SZO_OPR_OPERADORES opr) 
    {
      Opr = opr;
      txtNome.Text = opr.OPR_NOME;
      txtSenha.Text = opr.OPR_SENHA;
      cbGerencia.Checked = opr.OPR_GERENCIA;
      cbCancelarItem.Checked = opr.OPR_CANCELAR_ITEM;
      cbCancelarVenda.Checked = opr.OPR_CANCELAR_CUPOM;
      txtNome.Select();
    }

    private void frmCadastroOperadores_Load(object sender, EventArgs e)
    {
      Listar();
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      Editar(new SZO_OPR_OPERADORES());
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtNome.Text)) 
      {
        Utilities.MsgAlert("Preencha o campo nome");
        txtNome.Select();
        return;
      }

      Opr.OPR_SINCRONIZADO = false;
      Opr.OPR_NOME = txtNome.Text;
      Opr.OPR_SENHA = txtSenha.Text;
      Opr.OPR_GERENCIA = cbGerencia.Checked;
      Opr.OPR_CANCELAR_ITEM = cbCancelarItem.Checked;
      Opr.OPR_CANCELAR_CUPOM = cbCancelarVenda.Checked;
      (new dsSZO_OPR_OPERADORES(Utilities.GetDatabase())).Save(Opr);
      Listar();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if (grdOperadores.SelectedRows.Count != 0) 
      {
        SZO_OPR_OPERADORES operador = ((SZO_OPR_OPERADORES)grdOperadores.SelectedRows[0].DataBoundItem);
        if (Utilities.MsgQuestion(string.Format("Tem certeza que deseja remover o operador {0}", operador.OPR_NOME)))
        {
          operador.OPR_SINCRONIZADO = false;
          operador.OPR_INATIVO = true;
          (new dsSZO_OPR_OPERADORES(Utilities.GetDatabase())).Save(operador);
          Listar();
        }
      }
      else
      { Utilities.MsgAlert("Selecione um operador para excluir!"); }
    }

    private void grdOperadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (grdOperadores.SelectedRows.Count != 0)
      { Editar(((SZO_OPR_OPERADORES)grdOperadores.SelectedRows[0].DataBoundItem)); }
    }
  }
}
