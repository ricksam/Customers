using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using lib.Database.Query;
using lib.Visual;
using lib.Visual.Components;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class Financeiro : lib.Visual.Models.frmEdit
  {
    #region public Financeiro()
    public Financeiro()
    {
      InitializeComponent();
      dsFin = new dsFIN_FINANCEIRO(Utilities.Cnn);
      dsFni = new dsFNI_FINANCEIRO_ITEM(Utilities.Cnn);
      ItemsReceitas = new List<FNI_FINANCEIRO_ITEM[]>();
      ItemsDespesas = new List<FNI_FINANCEIRO_ITEM[]>();
      RemoverItems = new List<int>();
      RemoveLancamento = new List<int>();
    }
    #endregion

    #region Fields
    private dsFIN_FINANCEIRO dsFin { get; set; }
    private dsFNI_FINANCEIRO_ITEM dsFni { get; set; }
    public FRM_FORMULARIOS Frm { get; set; }
    public VDA_VENDA Vda { get; set; }
    public List<FNI_FINANCEIRO_ITEM[]> ItemsReceitas { get; set; }
    public List<FNI_FINANCEIRO_ITEM[]> ItemsDespesas { get; set; }
    public List<int> RemoverItems { get; set; }
    public List<int> RemoveLancamento { get; set; }
    #endregion

    #region Methods
    #region public void Carregar()
    private void Carregar()
    {
      txtLoja.Text = (new dsEMP_EMPRESAS(Utilities.Cnn)).Get(Frm.FRM_EMP_CODIGO).EMP_DESCRICAO;
      txtPDV.Text = Frm.FRM_NUMERO.ToString();
      txtDate.Text = Frm.FRM_DATA.ToString("dd/MM/yyyy");
      txtTrocoInicial.AsDecimal = Frm.FRM_TROCOINICIAL;
      txtTrocoFinal.AsDecimal = Frm.FRM_TROCOFINAL;
      cbBloqueado.Checked = Frm.FRM_BLOQUEADO;
      if (Frm.FRM_CODIGO != 0)
      {
        txtValComparativo.AsDecimal = Frm.FRM_VALOR_COMPARATIVO;
        txtNrCli.AsInt = Frm.FRM_NUMERO_CLIENTES;
        txtCancelado.AsDecimal = Frm.FRM_VALOR_CANCELADO;
      }
      else if (Vda != null)
      {
        txtValComparativo.AsDecimal = Vda.VDA_TOTAL;
        txtNrCli.AsInt = Vda.VDA_CUPONS;
      }

      CarregaReceitas(dsFin.GetList_Receitas(Frm.FRM_EMP_CODIGO, Frm.FRM_CODIGO, Frm.FRM_DATA));
      CarregaDespesas(dsFin.GetList_Despesas(Frm.FRM_EMP_CODIGO, Frm.FRM_CODIGO, Frm.FRM_DATA));
      ExibeResultado();
    }
    #endregion

    #region private void CarregaDadosGrid(lib.Visual.Components.sknGrid Grid, FIN_FINANCEIRO[] Fin)
    private void CarregaDadosGrid(lib.Visual.Components.sknGrid Grid, FIN_FINANCEIRO[] Fin) 
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Check", "Sel", enmFieldType.Bool,60));
      Grid.AddColumn(new FieldColumn("Plano de Contas", "PLN_DESCRICAO", enmFieldType.String, 120));

      if (Grid == lstDespesas)
      { Grid.AddColumn(new FieldColumn("Fornecedor", "FRN_NOME", enmFieldType.String, 120)); }
      else
      { Grid.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String, 120)); }

      Grid.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal));
      
      if (Grid == lstDespesas)
      { Grid.AddColumn(new FieldColumn("Val. Nota", "FIN_VALOR_NOTA", enmFieldType.Decimal)); }

      Grid.AddColumn(new FieldColumn("Conferência", "PLN_CONFERENCIA", enmFieldType.Bool, 80));
      
      if (Grid == lstDespesas)
      { Grid.AddColumn(new FieldColumn("Pago", "Pago", enmFieldType.Bool, 60)); }

      if (Fin.Length != 0)
      { Grid.AddItems(Fin); }
    }
    #endregion

    #region private void CarregaReceitas(FIN_FINANCEIRO[] Receitas)
    private void CarregaReceitas(FIN_FINANCEIRO[] Receitas)
    {
      for (int i = 0; i < Receitas.Length; i++)
      { ItemsReceitas.Add(dsFni.GetList_FromFIN(Receitas[i].FIN_CODIGO)); }

      CarregaDadosGrid(lstReceitas, Receitas);

      Frm.FRM_TOTRECEITAS = 0;
      for (int i = 0; i < Receitas.Length; i++)
      {
        if (Receitas[i].PLN_CONFERENCIA)
        { Frm.FRM_TOTRECEITAS += Receitas[i].FIN_VALOR; }
      }
    }
    #endregion

    #region private void CarregaDespesas(FIN_FINANCEIRO[] Despesas)
    private void CarregaDespesas(FIN_FINANCEIRO[] Despesas)
    {
      for (int i = 0; i < Despesas.Length; i++)
      { ItemsDespesas.Add(dsFni.GetList_FromFIN(Despesas[i].FIN_CODIGO)); }

      CarregaDadosGrid(lstDespesas, Despesas);
      
      Frm.FRM_TOTDESPESAS = 0;
      for (int i = 0; i < Despesas.Length; i++)
      {
        if (Despesas[i].PLN_CONFERENCIA)
        { Frm.FRM_TOTDESPESAS += Despesas[i].FIN_VALOR; }
      }
    }
    #endregion

    #region private void ExibeResultado()
    private void ExibeResultado() 
    {
      txtReceitas.AsDecimal = Frm.FRM_TOTRECEITAS;
      txtDespesas.AsDecimal = Frm.FRM_TOTDESPESAS;
      txtResultado.AsDecimal = Frm.Resultado;
    }
    #endregion
        
    #region private void AdicionarLancamento()
    private void AdicionarLancamento()
    {
      Lancamento l = new Lancamento();
      l.Fin = new FIN_FINANCEIRO();
      l.Fin.FIN_EMP_CODIGO = this.Frm.FRM_EMP_CODIGO;
      l.Fin.FIN_DATA = this.Frm.FRM_DATA;
      l.Fin.FIN_EMISSAO = txtDate.AsDateTime;
      l.Fin.CPG_VENCIMENTO = txtDate.AsDateTime;
      l.Items = new FNI_FINANCEIRO_ITEM[] { };

      if (l.Exec())
      {
        l.Fin.FIN_EMP_CODIGO = this.Frm.FRM_EMP_CODIGO;        
        l.Fin.FIN_DATA = this.Frm.FRM_DATA;

        RemoverItems.AddRange(l.RemoverItems);

        if (l.Fin.TipoLancamento == enmTipoLancamento.Receita)
        {
          ItemsReceitas.Add(l.Items);
          lstReceitas.AddItem(l.Fin);

          if (l.Fin.PLN_CONFERENCIA)
          { Frm.FRM_TOTRECEITAS += l.Fin.FIN_VALOR; }
        }
        else
        {
          ItemsDespesas.Add(l.Items);
          lstDespesas.AddItem(l.Fin);

          if (l.Fin.PLN_CONFERENCIA)
          { Frm.FRM_TOTDESPESAS += l.Fin.FIN_VALOR; }
        }
        ExibeResultado();
      }
    }
    #endregion

    #region private void AlterarLancamento(sknGrid grd)
    private void AlterarLancamento(sknGrid grd)
    {
      if (grd.SelectedRows.Count != 0)
      {
        int idx = grd.SelectedRows[0].Index;
        Lancamento l = new Lancamento();
        l.Fin = new FIN_FINANCEIRO();
        FIN_FINANCEIRO FinAnt = grd.GetItem<FIN_FINANCEIRO>();
        
        if (FinAnt.Pago && !Utilities.Liberar()) 
        {
          Msg.Warning("Não é permitido alterar um lançamento pago");
          return;
        }

        l.Fin.Assign(FinAnt);
        if (l.Fin.TipoLancamento == enmTipoLancamento.Receita)
        { l.Items = ItemsReceitas[idx]; }
        else
        { l.Items = ItemsDespesas[idx]; }

        if (l.Exec())
        {
          grd.AlterItem(idx, l.Fin);

          if (l.Fin.TipoLancamento == enmTipoLancamento.Receita)
          { ItemsReceitas[idx] = l.Items; }
          else
          { ItemsDespesas[idx] = l.Items; }

          RemoverItems.AddRange(l.RemoverItems);

          if (FinAnt.PLN_CONFERENCIA)
          {
            if (FinAnt.TipoLancamento == enmTipoLancamento.Receita)
            { Frm.FRM_TOTRECEITAS -= FinAnt.FIN_VALOR; }
            else if (FinAnt.TipoLancamento == enmTipoLancamento.Despesa)
            { Frm.FRM_TOTDESPESAS -= FinAnt.FIN_VALOR; }
          }

          if (l.Fin.PLN_CONFERENCIA)
          {
            if (l.Fin.TipoLancamento == enmTipoLancamento.Receita)
            { Frm.FRM_TOTRECEITAS += l.Fin.FIN_VALOR; }
            else if (l.Fin.TipoLancamento == enmTipoLancamento.Despesa)
            { Frm.FRM_TOTDESPESAS += l.Fin.FIN_VALOR; }
          }

          ExibeResultado();
        }
      }
    }
    #endregion

    #region private void RemoverLancamento(sknGrid grd)
    private void RemoverLancamento(sknGrid grd)
    {
      if (grd.SelectedRows.Count != 0)
      {
        FIN_FINANCEIRO Fin = grd.GetItem<FIN_FINANCEIRO>();

        if (Fin.Pago)
        {
          Msg.Warning("Não é permitido remover um lançamento pago");
          return;
        }

        string infoLanc = string.Format(
          "Categoria:{0}\n" +
          "Plano de Contas:{1}\n" +
          "Descrição:{2}\n" +
          "Valor:{3}",
          Fin.CAT_DESCRICAO,
          Fin.PLN_DESCRICAO,
          Fin.DescricaoResumida,
          Fin.FIN_VALOR.ToString("#,##0.00")
        );

        int idx = grd.SelectedRows[0].Index;
        if (Msg.Question("Tem certeza que deseja remover o lançamento:\n" + infoLanc))
        {
          if (Fin.PLN_CONFERENCIA && Fin.TipoLancamento == enmTipoLancamento.Receita)
          {
            for (int i = 0; i < ItemsReceitas[idx].Length; i++)
            { RemoverItems.Add(ItemsReceitas[idx][i].FNI_CODIGO); }

            ItemsReceitas.RemoveAt(idx);
            Frm.FRM_TOTRECEITAS -= Fin.FIN_VALOR; 
          }
          else if (Fin.PLN_CONFERENCIA && Fin.TipoLancamento == enmTipoLancamento.Despesa)
          {
            for (int i = 0; i < ItemsReceitas[idx].Length; i++)
            { RemoverItems.Add(ItemsDespesas[idx][i].FNI_CODIGO); }

            ItemsDespesas.RemoveAt(idx);
            Frm.FRM_TOTDESPESAS -= Fin.FIN_VALOR; 
          }

          RemoveLancamento.Add(Fin.FIN_CODIGO);
          grd.Rows.RemoveAt(idx);
          ExibeResultado();
        }
      }
    }
    #endregion

    #region protected override void OnConfirm()
    private void GravaLancamentos(dsCPG_CONTAS_PAGAR dsCpg, FIN_FINANCEIRO[] lstFin, List<FNI_FINANCEIRO_ITEM[]> Items) 
    {
      CPG_CONTAS_PAGAR Cpg;
      for (int i = 0; i < lstFin.Length; i++)
      {
        FIN_FINANCEIRO Fin = lstFin[i];
        
        Fin.FIN_FRM_CODIGO = this.Frm.FRM_CODIGO;
        Fin.FIN_EMP_CODIGO = this.Frm.FRM_EMP_CODIGO;
        Fin.FIN_DATA = this.Frm.FRM_DATA;

        if (Fin.PLN_CONFERENCIA)
        { Fin.FIN_DATA_PGTO = Fin.FIN_DATA; }
        dsFin.Save(Fin);

        #region GravaItems
        for (int j = 0; j < Items[i].Length; j++)
        {
          Items[i][j].FNI_FIN_CODIGO = Fin.FIN_CODIGO;
          dsFni.Save(Items[i][j]);
        }
        #endregion

        if (Fin.PLN_CONFERENCIA)
        {
          Cpg = dsCpg.Get_FromFinanceiro(Fin.FIN_CODIGO);
          if (Cpg.CPG_CODIGO != 0)
          { dsCpg.Remove(Cpg.CPG_CODIGO); }
        }
        else
        {
          Cpg = dsCpg.Get_FromFinanceiro(Fin.FIN_CODIGO);
          Cpg.CPG_EMP_CODIGO = Fin.FIN_EMP_CODIGO;
          Cpg.CPG_FIN_CODIGO = Fin.FIN_CODIGO;
          Cpg.CPG_VENCIMENTO = Fin.CPG_VENCIMENTO;
          Cpg.CPG_DOCUMENTO = Fin.CPG_DOCUMENTO;
          Cpg.CPG_FRN_CODIGO = Fin.CPG_FRN_CODIGO;
          dsCpg.Save(Cpg);
        }
      }
    }

    protected override void OnConfirm()
    {
      dsCPG_CONTAS_PAGAR dsCpg = new dsCPG_CONTAS_PAGAR(Utilities.Cnn);

      //List<FIN_FINANCEIRO> lstFin = new List<FIN_FINANCEIRO>();

      //lstFin.AddRange(lstReceitas.GetItems<FIN_FINANCEIRO>());
      //lstFin.AddRange(lstDespesas.GetItems<FIN_FINANCEIRO>());

      List<FIN_FINANCEIRO> lstFinReceitas = new List<FIN_FINANCEIRO>();
      List<FIN_FINANCEIRO> lstFinDespesas = new List<FIN_FINANCEIRO>();

      lstFinReceitas.AddRange(lstReceitas.GetItems<FIN_FINANCEIRO>());
      lstFinDespesas.AddRange(lstDespesas.GetItems<FIN_FINANCEIRO>());
            
      try
      {
        Utilities.Cnn.BeginTransaction();

        #region Atualiza e grava formulário
        Frm.FRM_TOTCOMPRAS = 0;
        for (int i = 0; i < lstFinDespesas.Count; i++)
        {
          if (lstFinDespesas[i].FIN_CAT_CODIGO == 5)
          { Frm.FRM_TOTCOMPRAS += lstFinDespesas[i].FIN_VALOR; }
        }
        
        Frm.FRM_TROCOINICIAL = txtTrocoInicial.AsDecimal;
        Frm.FRM_TROCOFINAL = txtTrocoFinal.AsDecimal;
        Frm.FRM_BLOQUEADO = cbBloqueado.Checked;
        Frm.FRM_VALOR_COMPARATIVO = txtValComparativo.AsDecimal;
        Frm.FRM_NUMERO_CLIENTES = txtNrCli.AsInt;
        Frm.FRM_VALOR_CANCELADO = txtCancelado.AsDecimal;

        // Salva Formulário
        (new dsFRM_FORMULARIOS(Utilities.Cnn)).Save(Frm);

        //Salva Venda
        if (Vda != null) 
        {
          Vda.VDA_FRM_CODIGO = Frm.FRM_CODIGO;
          (new dsVDA_VENDA(Utilities.Cnn)).SaveNrForm(Vda);
        }
        #endregion

        #region Remove Lançamentos e Items
        for (int i = 0; i < RemoverItems.Count; i++)
        { dsFni.Remove(RemoverItems[i]); }

        for (int i = 0; i < RemoveLancamento.Count; i++)
        {
          dsCpg.Remove_FromFinanceiro(RemoveLancamento[i]);
          dsFin.Remove(RemoveLancamento[i]); 
        }

        /*dsFin.RemoveOldItems(lstFin.ToArray(), 
          this.Frm.FRM_EMP_CODIGO, 
          this.Frm.FRM_CODIGO, 
          this.Frm.FRM_DATA);*/
        #endregion

        GravaLancamentos(dsCpg, lstFinReceitas.ToArray(), ItemsReceitas);
        GravaLancamentos(dsCpg, lstFinDespesas.ToArray(), ItemsDespesas);
                
        Utilities.Cnn.CommitTransaction();
      }
      catch(Exception ex)
      {
        Msg.Warning(ex.Message);
        Utilities.Cnn.RollbackTransaction(); 
      }

      base.OnConfirm();
    }
    #endregion
    #endregion

    #region Events
    private void Financeiro_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
      AdicionarLancamento();
    }

    private void lst_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { AlterarLancamento((sknGrid)sender); }
      else if (e.KeyData == Keys.Delete)
      { RemoverLancamento((sknGrid)sender); }
    }

    private void lst_DoubleClick(object sender, EventArgs e)
    { AlterarLancamento((sknGrid)sender); }

    #region private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 0)
      {
        if (((sknGrid)sender).SelectedRows.Count != 0)
        {
          FIN_FINANCEIRO Fin = ((sknGrid)sender).GetItem<FIN_FINANCEIRO>();
          Fin.Sel = !Fin.Sel;
          ((sknGrid)sender).AlterItem(Fin);
        }
      }
    }
    #endregion

    private void sknButton1_Click(object sender, EventArgs e)
    {
      
    }
    #endregion
  }
}
