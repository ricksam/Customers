using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Class;
using lib.Visual;
using lib.Database.Drivers;
using lib.Database.Query;

namespace Financeiro_Marcelo
{
  public partial class ContasPagar : lib.Visual.Models.frmBaseCadastro
  {
    public ContasPagar()
    {
      InitializeComponent();
      dsFin = new dsFIN_FINANCEIRO(Utilities.Cnn);
      dsCpg = new dsCPG_CONTAS_PAGAR(Utilities.Cnn);
      dsFrn = new dsFRN_FORNECEDORES(Utilities.Cnn);
    }

    FIN_FINANCEIRO TabFin { get; set; }
    CPG_CONTAS_PAGAR TabCpg { get; set; }
    dsFIN_FINANCEIRO dsFin { get; set; }
    dsCPG_CONTAS_PAGAR dsCpg { get; set; }
    dsFRN_FORNECEDORES dsFrn { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      cmbCategoria.DisplayMember = "CAT_DESCRICAO";
      cmbCategoria.ValueMember = "CAT_CODIGO";
      cmbCategoria.DataSource = (new dsCAT_CATEGORIAS(Utilities.Cnn)).GetList();

      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();

      cmbCategoria.Enabled = (TabFin.FIN_FRM_CODIGO == 0);
      cmbPlanoContas.Enabled = (TabFin.FIN_FRM_CODIGO == 0);
      cmbEmpresa.Enabled = (TabFin.FIN_FRM_CODIGO == 0);
      btnRemover.Enabled = (TabFin.FIN_FRM_CODIGO == 0) && (TabFin.FIN_CODIGO != 0);

      txtNrParcelas.AsInt = 1;
      lblNrParcelas.Visible = (TabFin.FIN_CODIGO == 0);
      txtNrParcelas.Visible = (TabFin.FIN_CODIGO == 0);
            
      cmbCategoria.SelectedValue = TabFin.FIN_CAT_CODIGO;
      cmbPlanoContas.SelectedValue = TabFin.FIN_PLN_CODIGO;
      cmbEmpresa.SelectedValue = TabFin.FIN_EMP_CODIGO;
      txtDescricao.Text = TabFin.FIN_DESCRICAO;
      txtValor.AsDecimal = TabFin.FIN_VALOR;
      txtValorNota.AsDecimal = TabFin.FIN_VALOR_NOTA;

      txtNrDocumento.Text = TabCpg.CPG_DOCUMENTO;

      if (TabFin.FIN_DATA == DateTime.MinValue)
      { txtDtEntrada.Text = ""; }
      else
      { txtDtEntrada.AsDateTime = TabFin.FIN_DATA; }

      if (TabFin.FIN_EMISSAO == DateTime.MinValue)
      { txtDtEmissao.Text = ""; }
      else
      { txtDtEmissao.AsDateTime = TabFin.FIN_EMISSAO; }

      if (TabCpg.CPG_VENCIMENTO == DateTime.MinValue)
      { txtDtVenc.Text = ""; }
      else
      { txtDtVenc.AsDateTime = TabCpg.CPG_VENCIMENTO; }

      if (TabCpg.CPG_FRN_CODIGO != 0)
      { txtFornecedor.Text = dsFrn.Get(TabCpg.CPG_FRN_CODIGO).FRN_NOME; }

      if (TabFin.FIN_CODIGO == 0)
      {
        txtNrDocumento.Text = "{{parcela}}/{{parcelas}}";
        txtDescricao.Text = "mês {{mes}}/{{ano}}";
      }

      cbOficial.Checked = TabCpg.CPG_OFICIAL;

      cmbEmpresa.Select();
    }
    #endregion

    #region private void CarregaPlanoContas()
    private void CarregaPlanoContas() 
    {
      if (cmbCategoria.SelectedIndex != -1)
      {
        cmbPlanoContas.DisplayMember = "PLN_DESCRICAO";
        cmbPlanoContas.ValueMember = "PLN_CODIGO";
        cmbPlanoContas.DataSource = (new dsPLN_PLANOCONTAS(Utilities.Cnn)).GetList((int)cmbCategoria.SelectedValue);
      }
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();

      TabFin = new FIN_FINANCEIRO();
      TabCpg = new CPG_CONTAS_PAGAR();            
      Carregar();      
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);

      TabCpg = Grid.GetItem<CPG_CONTAS_PAGAR>();
      TabFin = dsFin.Get(TabCpg.CPG_FIN_CODIGO);      
      Carregar();      
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover este lançamento ? ")))
      {
        try
        {
          Utilities.Cnn.BeginTransaction();
          dsCpg.Remove(TabCpg.CPG_CODIGO);
          dsFin.Remove(TabCpg.CPG_FIN_CODIGO);
          Utilities.Cnn.CommitTransaction();
        }
        catch(Exception ex)
        {
          Utilities.Cnn.RollbackTransaction();
          Utilities.FormError.ShowError(ex);
        }
        base.OnRemoveRecord();
      }      
    }
    #endregion

    #region private bool FaltaPreencher()
    private bool FaltaPreencher()
    {
      bool bParcelas = false;
      List<LockedField> lf = new List<LockedField>();

      lf.AddRange(dsCpg.GetLockedFields(TabCpg));
      lf.AddRange(dsFin.GetLockedFields(TabFin));

      if (txtNrParcelas.AsInt == 0)
      { lf.Add(new LockedField("Parcelas", " - Informe um número de parcelas maior que zero")); }

      if (lf.Count != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Count; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);
      }
      else
      {        
        if (txtNrParcelas.AsInt > 1)
        {
          string xConfirm =
            string.Format(
              "Tem certeza que deseja gerar {0} parcelas para todo dia {1} dos meses seguintes ao vencimento {2} ?",
              txtNrParcelas.AsInt,
              TabCpg.CPG_VENCIMENTO.Day,
              TabCpg.CPG_VENCIMENTO.ToString("dd/MM/yyyy"));
          bParcelas = !Msg.Question(xConfirm);
        }
      }

      return lf.Count != 0 || bParcelas;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbCategoria.SelectedIndex != -1)
      { TabFin.FIN_CAT_CODIGO = (int)cmbCategoria.SelectedValue; }

      if (cmbPlanoContas.SelectedIndex != -1)
      { TabFin.FIN_PLN_CODIGO = (int)cmbPlanoContas.SelectedValue; }

      if (cmbEmpresa.SelectedIndex != -1)
      { TabFin.FIN_EMP_CODIGO = (int)cmbEmpresa.SelectedValue; }

      TabFin.FIN_FRM_CODIGO = 0;
      TabFin.FIN_DESCRICAO = txtDescricao.Text;
      TabFin.FIN_VALOR = txtValor.AsDecimal;
      TabFin.FIN_VALOR_NOTA = txtValorNota.AsDecimal;
      TabFin.FIN_DATA = txtDtEntrada.AsDateTime;
      TabFin.FIN_EMISSAO = txtDtEmissao.AsDateTime;

      TabCpg.CPG_DOCUMENTO = txtNrDocumento.Text;
      TabCpg.CPG_VENCIMENTO = txtDtVenc.AsDateTime;
      TabCpg.CPG_EMP_CODIGO = TabFin.FIN_EMP_CODIGO;
      TabCpg.CPG_OFICIAL = cbOficial.Checked;

      if (!FaltaPreencher())
      {
        Utilities.Cnn.BeginTransaction();
        try
        {
          #region Grava Lancamento ou Parcelas
          if (txtNrParcelas.Visible)
          {
            // Insert
            for (int i = 0; i < txtNrParcelas.AsInt; i++)
            {
              TabFin.FIN_DESCRICAO = FormatCampo(txtDescricao.Text, TabCpg.CPG_VENCIMENTO, (i + 1), txtNrParcelas.AsInt);
              TabCpg.CPG_DOCUMENTO = FormatCampo(txtNrDocumento.Text, TabCpg.CPG_VENCIMENTO, (i + 1), txtNrParcelas.AsInt);

              GravaLancamento();
              TabFin.FIN_CODIGO = 0;
              TabCpg.CPG_CODIGO = 0;
              TabCpg.CPG_VENCIMENTO = TabCpg.CPG_VENCIMENTO.AddMonths(1);
            }
          }
          else
          {
            // Update
            GravaLancamento();
          }
          #endregion

          Utilities.Cnn.CommitTransaction();
          base.OnConfirm();
        }
        catch (Exception ex)
        {
          Utilities.Cnn.RollbackTransaction();
          Utilities.FormError.ShowError(ex);
        }
      }
    }
    #endregion

    #region private string FormatCampo(string sFormat,DateTime Vencimento, int Parcela, int Parcelas)
    private string FormatCampo(string sFormat,DateTime Vencimento, int Parcela, int Parcelas) 
    {
      sFormat = sFormat.Replace("{{mes}}",Vencimento.Month.ToString("00"));
      sFormat = sFormat.Replace("{{ano}}", Vencimento.Year.ToString("0000"));
      sFormat = sFormat.Replace("{{parcela}}", Parcela.ToString());
      sFormat = sFormat.Replace("{{parcelas}}", Parcelas.ToString());
      return sFormat;
    }
    #endregion

    #region private void GravaLancamento()
    private void GravaLancamento() 
    { 
        dsFin.Save(TabFin);
        TabCpg.CPG_FIN_CODIGO = TabFin.FIN_CODIGO;
        dsCpg.Save(TabCpg);
    }
    #endregion

    #region Events
    private void Form_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Empresa", "EMP_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Categoria", "CAT_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Plano de Contas", "PLN_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Fornecedor", "FRN_NOME", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Formulário", "FRM_NUMERO", enmFieldType.Int, 60));
      Grid.AddColumn(new FieldColumn("Documento", "CPG_DOCUMENTO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Entrada", "FIN_DATA", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Emissão", "FIN_EMISSAO", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Vencimento", "CPG_VENCIMENTO", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal));
      Grid.AddColumn(new FieldColumn("Valor Nota", "FIN_VALOR_NOTA", enmFieldType.Decimal));
      Grid.AddItems(dsCpg.Search(TextSearch));
    }
    
    private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaPlanoContas();
    }

    private void txtValor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F2)
      {
        Expressao ex = new Expressao();
        ex.ShowDialog();
        txtValor.AsDecimal = ex.Result();
        txtValor.Select();
        e.Handled = true;
      }
    }

    private void txtDt_Enter(object sender, EventArgs e)
    {
      lib.Visual.Components.sknMaskedTextBox skn = ((lib.Visual.Components.sknMaskedTextBox)sender);
      skn.SelectionStart = 0;
      skn.SelectionLength = skn.Text.Length;
    }

    private void btnFornecedor_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery fs = new lib.Visual.Forms.FormQuery();
      fs.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(PesquisaForneceor_OnSerch);
      if (fs.Exec())
      {
        TabCpg.CPG_FRN_CODIGO = fs.Grid.GetField("FRN_CODIGO").ToInt();
        txtFornecedor.Text = fs.Grid.GetField("FRN_NOME").ToString();
      }
    }

    private void PesquisaForneceor_OnSerch(object sender, lib.Visual.Components.sknGrid Grid, string s)
    {
      Grid.Clear();
      Grid.AddColumn(new lib.Database.Query.FieldColumn("Fornecedor", "FRN_NOME", lib.Database.Drivers.enmFieldType.String, 240));
      Grid.AddItems(dsFrn.Search(s));
    }
    #endregion
  }
}
