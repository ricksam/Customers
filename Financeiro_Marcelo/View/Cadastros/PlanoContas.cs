using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using lib.Database.Query;
using lib.Database.Drivers;
using lib.Visual;

namespace Financeiro_Marcelo
{
  public partial class PlanoContas : lib.Visual.Models.frmBase
  {
    public PlanoContas()
    {
      InitializeComponent();
      bsCat = new dsCAT_CATEGORIAS(Utilities.Cnn);
      bsPln = new dsPLN_PLANOCONTAS(Utilities.Cnn);
    }

    #region Fields
    enum enmModo { Lista, Edicao }
    dsCAT_CATEGORIAS bsCat { get; set; }
    dsPLN_PLANOCONTAS bsPln { get; set; }
    CAT_CATEGORIAS SelCat { get; set; }
    #endregion

    #region private void Carregar()
    private void Carregar()
    {
      ExibeModo(enmModo.Lista);
      Listar();      
    }
    #endregion

    #region private void ExibeModo(enmModo Modo)
    private void ExibeModo(enmModo Modo)
    {
      pnlList.Enabled = Modo == enmModo.Lista;
      pnlEdicao.Enabled = Modo == enmModo.Edicao;
    }
    #endregion

    #region private void Listar()
    private void Listar() 
    {
      lstCategorias.Clear();
      lstCategorias.AddColumn(new FieldColumn("Descrição", "CAT_DESCRICAO", enmFieldType.String));
      lstCategorias.AddColumn(new FieldColumn("Tipo", "CAT_TIPO", enmFieldType.String));
      lstCategorias.AddItems(bsCat.GetList());      
    }
    #endregion
    
    #region private void Novo()
    private void Novo()
    {
      ExibeModo(enmModo.Edicao);
      ExibeCategorias(new CAT_CATEGORIAS());
    }
    #endregion
    
    #region private void Alterar()
    private void Alterar()
    {
      if (lstCategorias.SelectedRows.Count != 0)
      {
        ExibeModo(enmModo.Edicao);
        CAT_CATEGORIAS Emp = lstCategorias.GetItem<CAT_CATEGORIAS>();
        ExibeCategorias(Emp);
      }
    }
    #endregion
    
    #region private void ExibeCAT_CATEGORIAS(CAT_CATEGORIAS Emp)
    private void ExibeCategorias(CAT_CATEGORIAS CAT_CATEGORIAS)
    {
      SelCat = CAT_CATEGORIAS;
      txtCategoria.Text = CAT_CATEGORIAS.CAT_DESCRICAO;
      cmbTipo.SelectedIndex = CAT_CATEGORIAS.TipoFinanceiro == enmTipoFinanceiro.Receita ? 0 : 1;
      txtCategoria.Focus();
      ListarPlano();
    }
    #endregion

    #region private void Excluir()
    private void Excluir()
    {
      if (lstCategorias.SelectedRows.Count != 0)
      {
        CAT_CATEGORIAS CAT_CATEGORIAS = lstCategorias.GetItem<CAT_CATEGORIAS>();

        if ((new dsFIN_FINANCEIRO(Utilities.Cnn)).CategoriaTemFinanceiro(CAT_CATEGORIAS.CAT_CODIGO))
        {
          Msg.Warning("Não é possível remover planos de contas que possuem lançamentos financeiros");
          return;
        }

        if (Msg.Question("Tem certeza que deseja excluir a categoria " + CAT_CATEGORIAS.CAT_DESCRICAO))
        {
          bsCat.Remove(CAT_CATEGORIAS.CAT_CODIGO);
          Listar();
        }
      }
    }
    #endregion

    #region private void ListarPlano()
    private void ListarPlano()
    {
      lstPlano.Clear();
      lstPlano.AddColumn(new FieldColumn("Descrição", "PLN_DESCRICAO", enmFieldType.String, 120));
      lstPlano.AddColumn(new FieldColumn("Prioridade", "PLN_PRIORIDADE", enmFieldType.Int, 60));
      lstPlano.AddColumn(new FieldColumn("Obriga Descr.", "PLN_OBRIGA_DESCRICAO", enmFieldType.Bool, 60));
      lstPlano.AddColumn(new FieldColumn("Conferencia", "PLN_CONFERENCIA", enmFieldType.Bool, 60));
      lstPlano.AddColumn(new FieldColumn("Itens", "PLN_ADICIONA_ITENS", enmFieldType.Bool, 60));
      lstPlano.AddItems(bsPln.GetList(SelCat.CAT_CODIGO));
    }
    #endregion

    #region private void NovoPlano()
    private void NovoPlano()
    {
      ItemPlano itm = new ItemPlano();
      itm.Tab = new PLN_PLANOCONTAS();
      if (itm.Exec())
      {
        //PLN_PLANOCONTAS Pln = new PLN_PLANOCONTAS();
        itm.Tab.PLN_CAT_CODIGO = SelCat.CAT_CODIGO;
        //Pln.PLN_DESCRICAO = itm.Descricao;
        lstPlano.AddItem(itm.Tab);
      }
    }
    #endregion

    #region private void AlterarPlano()
    private void AlterarPlano()
    {
      if (lstPlano.SelectedRows.Count != 0)
      {
        int idx = lstPlano.SelectedRows[0].Index;
        ItemPlano itm = new ItemPlano();
        itm.Tab = new PLN_PLANOCONTAS();
        itm.Tab.Assign(lstPlano.GetItem<PLN_PLANOCONTAS>(idx));        
        if (itm.Exec())
        { lstPlano.AlterItem(idx, itm.Tab); }
      }
    }
    #endregion

    #region private void RemovePlano()
    private void RemovePlano()
    {
      if (lstPlano.SelectedRows.Count != 0)
      {
        if ((new dsFIN_FINANCEIRO(Utilities.Cnn)).PlanoContasTemFinanceiro(lstPlano.GetItem<PLN_PLANOCONTAS>().PLN_CODIGO))
        {
          Msg.Information("Não é possível remover um plano de contas que possui financeiros");
          return;
        }

        int idx = lstPlano.SelectedRows[0].Index;
        if (Msg.Question("Tem certeza que deseja remover o plano de contas " + lstPlano.GetItem<PLN_PLANOCONTAS>().PLN_DESCRICAO))
        { lstPlano.Rows.RemoveAt(idx); }
      }
    }
    #endregion

    #region private void Salvar()
    private void Salvar()
    {
      if (string.IsNullOrEmpty(txtCategoria.Text))
      {
        Msg.Warning("Informe o nome da categoria");
        return;
      }

      try
      {
        Utilities.Cnn.BeginTransaction();
        SelCat.CAT_DESCRICAO = txtCategoria.Text;
        SelCat.TipoFinanceiro = cmbTipo.SelectedIndex == 0 ? enmTipoFinanceiro.Receita : enmTipoFinanceiro.Despesa;
        bsCat.Save(SelCat);

        bsPln.RemoveOldItems(lstPlano.GetItems<PLN_PLANOCONTAS>(), SelCat.CAT_CODIGO);

        for (int i = 0; i < lstPlano.Rows.Count; i++)
        {
          PLN_PLANOCONTAS Pln = lstPlano.GetItem<PLN_PLANOCONTAS>(i);
          Pln.PLN_CAT_CODIGO = SelCat.CAT_CODIGO;
          bsPln.Save(Pln);
        }

        Utilities.Cnn.CommitTransaction();
      }
      catch
      { Utilities.Cnn.RollbackTransaction(); }

      Listar();
      Novo();
      ExibeModo(enmModo.Lista);
    }
    #endregion

    #region private void Cancelar()
    private void Cancelar()
    {
      Novo();
      ExibeModo(enmModo.Lista);
    }
    #endregion

    #region Events
    private void PlanoContas_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      Novo();
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      Alterar();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      Excluir();
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Salvar();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Cancelar();
    }
            
    private void lstPlano_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter) 
      { AlterarPlano(); }
      else if (e.KeyData == Keys.Delete)
      { RemovePlano(); }
    }

    private void lstPlano_DoubleClick(object sender, EventArgs e)
    {
      AlterarPlano();
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
      NovoPlano();
    }
    #endregion
  }
}
