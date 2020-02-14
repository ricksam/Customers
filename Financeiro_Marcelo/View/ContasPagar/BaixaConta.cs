using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Database.Query;
using lib.Database.Drivers;
using lib.Visual;

namespace Financeiro_Marcelo
{
  public partial class BaixaConta : lib.Visual.Models.frmBase
  {
    #region public BaixaConta()
    public BaixaConta()
    {
      InitializeComponent();
      bsCpg = new dsCPG_CONTAS_PAGAR(Utilities.Cnn);
      bsBcn = new dsBCN_BAIXA_CONTAS(Utilities.Cnn);
    }
    #endregion

    #region Fields
    dsCPG_CONTAS_PAGAR bsCpg { get; set; }
    dsBCN_BAIXA_CONTAS bsBcn { get; set; }
    BCN_BAIXA_CONTAS Bcn { get; set; }
    bool IsAdmin { get; set; }
    #endregion

    #region Methods
    #region private void Carregar()
    private void Carregar() 
    {
      Bcn = new BCN_BAIXA_CONTAS();
      dtVenc.Value = DateTime.Now.AddMonths(2);
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();      
    }
    #endregion

    #region private void CarregaLancamentos()
    private void CarregaLancamentos() 
    {
      if (cmbEmpresa.SelectedIndex != -1)
      {        
        grdLancamentos.Clear();
        grdLancamentos.AddColumn(new FieldColumn("Baixar", "Sel", enmFieldType.Bool, 50));
        grdLancamentos.AddColumn(new FieldColumn("Seleção", "CPG_SEL", enmFieldType.Bool, 50));
        grdLancamentos.AddColumn(new FieldColumn("Formulário", "FRM_NUMERO", enmFieldType.Int,60));
        grdLancamentos.AddColumn(new FieldColumn("Fornecedor", "FRN_NOME", enmFieldType.String, 100));
        grdLancamentos.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String, 100));
        grdLancamentos.AddColumn(new FieldColumn("Documento", "CPG_DOCUMENTO", enmFieldType.String, 100));
        grdLancamentos.AddColumn(new FieldColumn("Entrada", "FIN_DATA", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Vencimento", "CPG_VENCIMENTO", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal,90));
        grdLancamentos.AddColumn(new FieldColumn("Lançar", "ValorParcial", enmFieldType.Decimal, 90));

        CPG_CONTAS_PAGAR[] lst = bsCpg.GetList_EmAberto((int)cmbEmpresa.SelectedValue, dtVenc.Value); 
        grdLancamentos.AddItems(lst);

        Bcn.BCN_CODIGO = 0;
        Bcn.BCN_NUMERO_CHEQUE = "";
        Bcn.BCN_EMP_CODIGO = 0;
        Bcn.BCN_CCN_CODIGO = 0;
        Bcn.BCN_VALOR = 0;

        decimal TotPesquisa = 0;
        for (int i = 0; i < lst.Length; i++)
        {
          TotPesquisa += lst[i].FIN_VALOR;
          if (lst[i].Sel)
          { Bcn.BCN_VALOR += lst[i].FIN_VALOR; }
        }

        lblTotPesquisa.Text = "Total Pesquisado: " + TotPesquisa.ToString("#,##0.00");
        txtTotal.AsDecimal = Bcn.BCN_VALOR;
      }
    }
    #endregion

    #region private void CalculaSelecao()
    private void CalculaSelecao(bool Sel, decimal Valor) 
    {
      if (Sel)
      { Bcn.BCN_VALOR += Valor; }
      else
      { Bcn.BCN_VALOR -= Valor; }
    }
    #endregion

    #region private void EditaLancamento()
    private void EditaLancamento()
    {
      if (grdLancamentos.SelectedRows.Count != 0)
      {
        int idx = grdLancamentos.SelectedRows[0].Index;
        BaixaParcial bp = new BaixaParcial();
        bp.Cpg = new CPG_CONTAS_PAGAR();
        bp.Cpg.Assign(grdLancamentos.GetItem<CPG_CONTAS_PAGAR>());

        if (!bp.Cpg.Sel)
        {
          Msg.Warning("Este lançamento não está marcado para baixar");
          return;
        }

        decimal ValAnt = bp.Cpg.FIN_VALOR;

        if (bp.Exec())
        {
          grdLancamentos.AlterItem(idx, bp.Cpg);
          Bcn.BCN_VALOR -= ValAnt;
          Bcn.BCN_VALOR += bp.Cpg.FIN_VALOR;
          txtTotal.AsDecimal = Bcn.BCN_VALOR;
        }
      }
    }
    #endregion

    #region private void Baixar()
    private void Baixar() 
    {
      if (cmbEmpresa.SelectedIndex == -1)
      {
        Msg.Warning("Informe a empresa!");
        cmbEmpresa.Select();
        return;
      }

      if (Bcn.BCN_VALOR == 0)
      {
        Msg.Warning("Não há lançamentos selecionados!");
        return;
      }

      Pagar p = new Pagar();
      p.Bcn = this.Bcn;
      p.Carregar((int)cmbEmpresa.SelectedValue, cmbEmpresa.Text);
      if (p.Exec())
      {
        Utilities.Cnn.BeginTransaction();
        try
        {
          //(new dsCFG_CONFIG(Utilities.Cnn)).AvancaNrImpressaoBaixa();
          dsFIN_FINANCEIRO bsFin = new dsFIN_FINANCEIRO(Utilities.Cnn);

          Bcn.BCN_EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
          //Bcn.BCN_DATA_PGTO = DateTime.Now;
          bsBcn.Save(Bcn);

          #region Lança registro saldo
          dsSDC_SALDO_CONTAS dsSaldo = new dsSDC_SALDO_CONTAS(Utilities.Cnn);
          dsSaldo.Save(dsSaldo.CreateSalto("BAIXA DE CONTAS",enmTipoSaldoContas.Debito,Bcn.BCN_CCN_CODIGO,Bcn.BCN_VALOR));
          #endregion

          CPG_CONTAS_PAGAR[] lst_pag = grdLancamentos.GetItems<CPG_CONTAS_PAGAR>();
          for (int i = 0; i < lst_pag.Length; i++)
          {
            if (lst_pag[i].Sel)
            {
              lst_pag[i].CPG_BCN_CODIGO = Bcn.BCN_CODIGO;
              bsCpg.Save(lst_pag[i]);

              FIN_FINANCEIRO Fin = bsFin.Get(lst_pag[i].CPG_FIN_CODIGO);
              Fin.FIN_DATA_PGTO = Bcn.BCN_DATA_PGTO;
              bsFin.Save(Fin);

              if (lst_pag[i].ValorParcial != 0)
              {                
                Fin.FIN_VALOR = lst_pag[i].FIN_VALOR;
                bsFin.Save(Fin);

                #region Gera Novo Financeiro e Nova Conta com o valor restante
                Fin.FIN_CODIGO = 0;
                Fin.FIN_DATA_PGTO = DateTime.MinValue;
                Fin.FIN_VALOR = lst_pag[i].ValorParcial;
                bsFin.Save(Fin);

                lst_pag[i].CPG_CODIGO = 0;
                lst_pag[i].CPG_BCN_CODIGO = 0;
                lst_pag[i].CPG_FIN_CODIGO = Fin.FIN_CODIGO;
                bsCpg.Save(lst_pag[i]);
                #endregion
              }
            }
          }
          Utilities.Cnn.CommitTransaction();

          List<SqlWebReport.ParamQuery> pars = new List<SqlWebReport.ParamQuery>();
          pars.Add(new SqlWebReport.ParamQuery(Bcn.BCN_CODIGO, SqlWebReport.FieldType.Int));
          Utilities.ExibeReport("BaixaConta", pars);
        }
        catch (Exception ex)
        {
          Utilities.Cnn.RollbackTransaction();
          Utilities.FormError.ShowError(ex);
        }
        this.CarregaLancamentos();
      }
    }
    #endregion
    #endregion

    #region Events
    #region private void sknButton2_Click(object sender, EventArgs e)
    private void sknButton2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    #endregion

    #region private void BaixaConta_Load(object sender, EventArgs e)
    private void BaixaConta_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    #endregion

    #region private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaLancamentos();
    }
    #endregion

    #region private void grdLancamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    private void grdLancamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
      {
        if (grdLancamentos.SelectedRows.Count != 0)
        {
          CPG_CONTAS_PAGAR Pag = grdLancamentos.GetItem<CPG_CONTAS_PAGAR>();

          if (e.ColumnIndex == 0)
          {
              Pag.Sel = !Pag.Sel;
              CalculaSelecao(Pag.Sel, Pag.FIN_VALOR);
          }

          if (e.ColumnIndex == 1)
          {
            if (!IsAdmin)
            { IsAdmin = Utilities.Liberar(); }

            if (IsAdmin)
            {
              Pag.CPG_SEL = !Pag.CPG_SEL;
              Pag.Sel = Pag.CPG_SEL;
              CalculaSelecao(Pag.Sel, Pag.FIN_VALOR);
            }
          }
          
          txtTotal.AsDecimal = Bcn.BCN_VALOR;
          grdLancamentos.AlterItem(Pag);
        }
      }
    }
    #endregion

    #region private void dtVenc_ValueChanged(object sender, EventArgs e)
    private void dtVenc_ValueChanged(object sender, EventArgs e)
    {
      CarregaLancamentos();
    }
    #endregion

    #region private void btnBaixa_Click(object sender, EventArgs e)
    private void btnBaixa_Click(object sender, EventArgs e)
    {
      Baixar();
    }
    #endregion

    #region private void btnSalvar_Click(object sender, EventArgs e)
    private void btnSalvar_Click(object sender, EventArgs e)
    {
      CPG_CONTAS_PAGAR[] lst = grdLancamentos.GetItems<CPG_CONTAS_PAGAR>();
      for (int i = 0; i < lst.Length; i++)
      { bsCpg.Save(lst[i]); }

      List<SqlWebReport.ParamQuery> Pars = new List<SqlWebReport.ParamQuery>();
      Pars.Add(new SqlWebReport.ParamQuery((int)cmbEmpresa.SelectedValue, SqlWebReport.FieldType.Int));
      //Utilities.ExibeReport("BaixaSelecao",Pars);
    }
    #endregion

    #region private void grdLancamentos_KeyDown(object sender, KeyEventArgs e)
    private void grdLancamentos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { EditaLancamento(); }
    }
    #endregion

    #region private void grdLancamentos_DoubleClick(object sender, EventArgs e)
    private void grdLancamentos_DoubleClick(object sender, EventArgs e)
    {
      EditaLancamento();
    }
    #endregion
    #endregion


  }
}
