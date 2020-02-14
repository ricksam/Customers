using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using lib.Visual;

namespace Financeiro_Marcelo
{
  public partial class Lancamento : lib.Visual.Models.frmEdit
  {
    public Lancamento()
    {
      InitializeComponent();
      dsFrn = new dsFRN_FORNECEDORES(Utilities.Cnn);
      dsFni = new dsFNI_FINANCEIRO_ITEM(Utilities.Cnn);
      RemoverItems = new List<int>();
    }

    FNI_FINANCEIRO_ITEM[] TmpItems = null;
    private dsFRN_FORNECEDORES dsFrn { get; set; }
    private dsFNI_FINANCEIRO_ITEM dsFni { get; set; }
    public FIN_FINANCEIRO Fin { get; set; }    
    public List<int> RemoverItems { get; set; }

    #region public FNI_FINANCEIRO_ITEM[] Items
    public FNI_FINANCEIRO_ITEM[] Items
    {
      set { TmpItems = value; }
      get { return grdItems.GetItems<FNI_FINANCEIRO_ITEM>(); }
    }
    #endregion

    #region private void ExibeCategoria()
    private void ExibeCategoria() 
    {
      this.cmbCategoria.SelectedIndexChanged -= new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
      cmbCategoria.DataSource = (new dsCAT_CATEGORIAS(Utilities.Cnn)).GetList();
      cmbCategoria.DisplayMember = "CAT_DESCRICAO";
      cmbCategoria.ValueMember = "CAT_CODIGO";
      cmbCategoria.SelectedValue = -1;
      this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
    }
    #endregion

    #region private void ExibePlanoContas()
    private void ExibePlanoContas()
    {
      if (cmbCategoria.SelectedIndex != -1) 
      {
        cmbPlanoContas.DataSource = (new dsPLN_PLANOCONTAS(Utilities.Cnn)).GetList((int)cmbCategoria.SelectedValue);
        cmbPlanoContas.DisplayMember = "PLN_DESCRICAO";
        cmbPlanoContas.ValueMember = "PLN_CODIGO";
      }      
    }
    #endregion

    #region private void LiberaCampos()
    private void LiberaCampos() 
    {
      cmbPlanoContas.Enabled = true;
      txtDescricao.Enabled = true;
      txtValor.Enabled = true;
      txtValNota.Enabled = true;
    }
    #endregion

    #region private void HabilitaItens(bool Enabled)
    private void HabilitaItens(bool Enabled) 
    {
      txtProduto.Enabled = Enabled;
      btnAdicionarItem.Enabled = Enabled;
      grbItens.Enabled = Enabled;
      if (Enabled)
      { txtProduto.Select(); }
      else
      { txtDescricao.Select(); }
    }
    #endregion

    #region private void Carregar()
    private void Carregar() 
    {
      ExibeCategoria();

      if (Fin.FIN_CAT_CODIGO == 0)
      { Fin.PLN_CONFERENCIA = true; }

      cmbCategoria.SelectedValue = Fin.FIN_CAT_CODIGO;
      cmbPlanoContas.SelectedValue = Fin.FIN_PLN_CODIGO;
      txtDescricao.Text = Fin.FIN_DESCRICAO;
      txtValor.AsDecimal = Fin.FIN_VALOR;
      txtValNota.AsDecimal = Fin.FIN_VALOR_NOTA;
      dtEmissao.Value = Fin.FIN_EMISSAO;
      dtVencimento.Value = Fin.CPG_VENCIMENTO;
      txtDocumento.Text = Fin.CPG_DOCUMENTO;

      if(Fin.CPG_FRN_CODIGO!=0)
      { txtFornecedor.Text = dsFrn.Get(Fin.CPG_FRN_CODIGO).FRN_NOME; }

      CarregarItems(TmpItems);
    }
    #endregion

    #region private bool FaltaPreencher()
    private bool FaltaPreencher() 
    {
      lib.Class.LockedField[] lf=  (new dsFIN_FINANCEIRO(Utilities.Cnn)).GetLockedFields(Fin);

      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "FIN_CAT_CODIGO")
        { cmbCategoria.Select(); }
        else if (lf[0].Field == "FIN_PLN_CODIGO")
        { cmbPlanoContas.Select(); }
        else if (lf[0].Field == "PLN_OBRIGA_DESCRICAO")
        { txtDescricao.Select(); }
        else if (lf[0].Field == "FIN_VALOR")
        { txtValor.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbCategoria.SelectedIndex != -1)
      {
        CAT_CATEGORIAS Cat = ((CAT_CATEGORIAS)cmbCategoria.SelectedItem);
        Fin.FIN_CAT_CODIGO = Cat.CAT_CODIGO;
        Fin.CAT_DESCRICAO = Cat.CAT_DESCRICAO;
        Fin.CAT_TIPO = Cat.CAT_TIPO;
      }

      if (cmbPlanoContas.SelectedIndex != -1)
      {
        PLN_PLANOCONTAS Pln = ((PLN_PLANOCONTAS)cmbPlanoContas.SelectedItem);
        Fin.FIN_PLN_CODIGO = Pln.PLN_CODIGO;
        Fin.PLN_DESCRICAO = Pln.PLN_DESCRICAO;
        Fin.PLN_OBRIGA_DESCRICAO = Pln.PLN_OBRIGA_DESCRICAO;
        Fin.PLN_CONFERENCIA = Pln.PLN_CONFERENCIA;
      }

      Fin.FIN_DESCRICAO = txtDescricao.Text;
      Fin.FIN_VALOR = txtValor.AsDecimal;
      Fin.FIN_VALOR_NOTA = txtValNota.AsDecimal;
      Fin.FIN_EMISSAO = dtEmissao.Value;
      Fin.FIN_DATA = dtEmissao.Value;
      Fin.CPG_VENCIMENTO = dtVencimento.Value;
      Fin.CPG_DOCUMENTO = txtDocumento.Text;
      Fin.FRN_NOME = txtFornecedor.Text;
            
      if (!FaltaPreencher())
      { base.OnConfirm(); }
    }
    #endregion

    #region METODOS ITEMS
    #region private void CarregarItems()
    private void CarregarItems(FNI_FINANCEIRO_ITEM[] items)
    {
      grdItems.Clear();
      grdItems.AddColumn(new lib.Database.Query.FieldColumn("Descrição", "FNI_DESCRICAO", lib.Database.Drivers.enmFieldType.String, 140));
      grdItems.AddColumn(new lib.Database.Query.FieldColumn("Qtde", "FNI_QTDE", lib.Database.Drivers.enmFieldType.Decimal, 80));
      grdItems.AddColumn(new lib.Database.Query.FieldColumn("Total", "FNI_VALOR_TOTAL", lib.Database.Drivers.enmFieldType.Decimal, 80));
      grdItems.AddColumn(new lib.Database.Query.FieldColumn("Unitário", "FNI_VALOR_UNITARIO", lib.Database.Drivers.enmFieldType.Decimal, 80));
      grdItems.AddItems(items);
    }
    #endregion

    #region private void AdicionarItem()
    private void AdicionarItem()
    {
      View.LancamentoItem li = new View.LancamentoItem();
      li.Tab = new FNI_FINANCEIRO_ITEM();

      string[] arr_str = dsFni.GetListName_FromDescricao(txtProduto.Text);
            
      li.Tab.FNI_DESCRICAO = "";
      if (arr_str.Length > 1)
      {
        View.SelecionaProduto fsel = new View.SelecionaProduto();
        fsel.CerregaProdutos(arr_str);
        if (fsel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        { li.Tab.FNI_DESCRICAO = fsel.GetItem(); }
      }
      else if(arr_str.Length == 1)
      { li.Tab.FNI_DESCRICAO = arr_str[0]; }

      if (string.IsNullOrEmpty(li.Tab.FNI_DESCRICAO) && !string.IsNullOrEmpty(txtProduto.Text))
      { li.Tab.FNI_DESCRICAO = txtProduto.Text; }
      txtProduto.Text = "";

      if (li.Exec())
      { grdItems.AddItem(li.Tab); }
    }
    #endregion

    #region private void AlterarItem()
    private void AlterarItem()
    {
      if (grdItems.SelectedRows.Count != 0)
      {
        int idx = grdItems.SelectedRows[0].Index;
        View.LancamentoItem li = new View.LancamentoItem();
        li.Tab = new FNI_FINANCEIRO_ITEM();
        li.Tab.Assign(grdItems.GetItem<FNI_FINANCEIRO_ITEM>(idx));
        if (li.Exec())
        { grdItems.AlterItem(idx, li.Tab); }
      }
    }
    #endregion

    #region private void RemoverItem()
    private void RemoverItem()
    {
      if (grdItems.SelectedRows.Count != 0)
      {
        int idx = grdItems.SelectedRows[0].Index;
        if (Msg.Question("Tem certeza que deseja remover este item?"))
        {
          RemoverItems.Add(grdItems.GetItem<FNI_FINANCEIRO_ITEM>(idx).FNI_CODIGO);
          grdItems.Rows.RemoveAt(idx);
        }
      }
    }
    #endregion
    #endregion

    #region Events
    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.F10)
      {
        RemoverItem();
      }

      base.OnKeyDown(e);
    }

    private void Lancamento_Load(object sender, EventArgs e)
    {
      Carregar();
    }
        
    private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
      ExibePlanoContas();
      LiberaCampos();
    }
    
    private void txtValor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { btnConfirm.Select(); }
      else if (e.KeyData == Keys.F2)
      {
        Expressao ex = new Expressao();
        ex.ShowDialog();
        txtValor.AsDecimal = ex.Result();        
      }
    }
    
    private void btnFornecedor_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery fs = new lib.Visual.Forms.FormQuery();
      fs.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(PesquisaForneceor_OnSerch);
      if (fs.Exec())
      {
        Fin.CPG_FRN_CODIGO = fs.Grid.GetField("FRN_CODIGO").ToInt();
        txtFornecedor.Text = fs.Grid.GetField("FRN_NOME").ToString();
      }
    }

    private void PesquisaForneceor_OnSerch(object sender, lib.Visual.Components.sknGrid Grid, string s)
    {
      Grid.Clear();
      Grid.AddColumn(new lib.Database.Query.FieldColumn("Fornecedor", "FRN_NOME", lib.Database.Drivers.enmFieldType.String, 240));
      Grid.AddItems(dsFrn.Search(s));
    }
    
    private void cmbPlanoContas_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbPlanoContas.SelectedIndex != -1) 
      {
        PLN_PLANOCONTAS Pln = ((PLN_PLANOCONTAS)cmbPlanoContas.SelectedItem);
        if (Pln.PLN_CONFERENCIA) 
        {
          Fin.CPG_FRN_CODIGO = 0;
          txtFornecedor.Text = "";
          txtDocumento.Text = "";
          
        }

        btnCadFornecedor.Enabled = !Pln.PLN_CONFERENCIA;
        btnFornecedor.Enabled = !Pln.PLN_CONFERENCIA;
        txtDocumento.Enabled = !Pln.PLN_CONFERENCIA;
        grbItens.Enabled = Pln.PLN_ADICIONA_ITENS;
      }
    }
    
    private void btnAdicionarItem_Click(object sender, EventArgs e)
    {
      AdicionarItem();
    }
    
    private void sknButton1_Click(object sender, EventArgs e)
    {
      View.Cadastros.CadFornecedores f = new View.Cadastros.CadFornecedores();
      f.ShowDialog();
    }
    
    private void removerF10ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RemoverItem();
    }
    
    private void grdItems_DoubleClick(object sender, EventArgs e)
    {
      AlterarItem();
    }

    private void grdItems_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { AlterarItem(); }

      if (e.KeyData == Keys.Delete)
      { RemoverItem(); }
    }

    private void sknButton2_Click(object sender, EventArgs e)
    {
      FNI_FINANCEIRO_ITEM[] itm = Items;
      decimal Total = 0;
      for (int i = 0; i < itm.Length; i++)
      { Total += itm[i].FNI_VALOR_TOTAL; }
      txtValNota.AsDecimal = Total;
    }
    

    private void txtProduto_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter) 
      {
        AdicionarItem();
      }
    }
    #endregion
  }
}
