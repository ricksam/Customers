using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Database.Drivers;
using lib.Database.Query;
using lib.Visual;

namespace Financeiro_Marcelo.View.Cartoes
{
  public partial class BaixaCartoes : lib.Visual.Models.frmBase
  {
    public BaixaCartoes()
    {
      InitializeComponent();
      dsLanc = new dsLNC_LANC_CARTOES(Utilities.Cnn);
    }

    dsLNC_LANC_CARTOES dsLanc { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      dtVencimento.Value = DateTime.Now.AddMonths(1);
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();
    }
    #endregion

    #region private void AddSelecionado(bool Sel, decimal Valor, decimal Taxa, decimal Receber)
    private void AddSelecionado(bool Sel, decimal Valor, decimal Taxa, decimal Receber) 
    {
      if (Sel)
      {
        txtValorTotal.AsDecimal += Valor;
        txtTotalTaxas.AsDecimal += Taxa;
        txtTotalReceber.AsDecimal += Receber;
      }
      else
      {
        txtValorTotal.AsDecimal -= Valor;
        txtTotalTaxas.AsDecimal -= Taxa;
        txtTotalReceber.AsDecimal -= Receber;
      }
    }
    #endregion
            
    #region private void PesquisarCartao()
    private void PesquisarCartao()
    {
      if (cmbEmpresa.SelectedIndex != -1 && dtVencimento.Value != DateTime.MinValue)
      {
        LNC_LANC_CARTOES[] lst = dsLanc.GetList_Aberto((int)cmbEmpresa.SelectedValue, dtVencimento.Value);

        grdCartoes.Clear();
        grdCartoes.AddColumn(new FieldColumn("Sel", "Sel", enmFieldType.Bool));
        grdCartoes.AddColumn(new FieldColumn("Cartão", "CRT_DESCRICAO", enmFieldType.String, 120));
        grdCartoes.AddColumn(new FieldColumn("Emissão", "LNC_EMISSAO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Vencimento", "LNC_VENCIMENTO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Valor", "LNC_VALOR", enmFieldType.Decimal, 90));
        grdCartoes.AddColumn(new FieldColumn("Taxa", "LNC_VALOR_TAXA", enmFieldType.Decimal, 60));
        grdCartoes.AddColumn(new FieldColumn("a Receber", "LNC_VALOR_RECEBER", enmFieldType.Decimal, 90));
        grdCartoes.AddColumn(new FieldColumn("Restante", "ValorParcial", enmFieldType.Decimal, 90));
        grdCartoes.AddItems(lst);

        txtValorTotal.AsDecimal = 0;
        txtTotalTaxas.AsDecimal = 0;
        txtTotalReceber.AsDecimal = 0;

        //for (int i = 0; i < lst.Length; i++)
        //{ AddTotal(lst[i].LNC_VALOR, lst[i].LNC_VALOR_TAXA, lst[i].LNC_VALOR_RECEBER); }
      }
    }
    #endregion

    #region private void EditaLancamento()
    private void EditaLancamento()
    {
      if (grdCartoes.SelectedRows.Count != 0)
      {
        int idx = grdCartoes.SelectedRows[0].Index;
        BaixaCartoesParcial bp = new BaixaCartoesParcial();
        bp.Tab = new LNC_LANC_CARTOES();
        bp.Tab.Assign(grdCartoes.GetItem<LNC_LANC_CARTOES>());

        if (!bp.Tab.Sel)
        {
          Msg.Warning("Este lançamento não está marcado para baixar");
          return;
        }

        decimal ValAnt = bp.Tab.LNC_VALOR;
        decimal TaxaAnt = bp.Tab.LNC_VALOR_TAXA;
        decimal RecAnt = bp.Tab.LNC_VALOR_RECEBER;

        if (bp.Exec())
        {
          dsLanc.Calcule(bp.Tab);
          grdCartoes.AlterItem(idx, bp.Tab);

          AddSelecionado(bp.Tab.Sel, -ValAnt, -TaxaAnt, -RecAnt);
          AddSelecionado(bp.Tab.Sel, bp.Tab.LNC_VALOR, bp.Tab.LNC_VALOR_TAXA, bp.Tab.LNC_VALOR_RECEBER);
        }
      }
    }
    #endregion

    #region private bool PossuiSelecionados(LNC_LANC_CARTOES[] lst)
    private bool PossuiSelecionados(LNC_LANC_CARTOES[] lst) 
    {
      for (int i = 0; i < lst.Length; i++)
      {
        if (lst[i].Sel)
        { return true; }
      }
      return false;
    }
    #endregion

    #region private void Baixar()
    private void Baixar() 
    {
      LNC_LANC_CARTOES[] lst = grdCartoes.GetItems<LNC_LANC_CARTOES>();
      if (!PossuiSelecionados(lst)) 
      {
        Msg.Warning("Selecione um ou mais cartões para baixar");
        return;
      }

      Financeiro_Marcelo.View.Cartoes.SelecionaConta Sel = new SelecionaConta();
      Sel.SetValues( (int)cmbEmpresa.SelectedValue,txtTotalReceber.AsDecimal);
      if (Sel.Exec())
      {
        try
        {
          Utilities.Cnn.BeginTransaction();
          (new dsSDC_SALDO_CONTAS(Utilities.Cnn)).Save(Sel.Saldo);
          for (int i = 0; i < lst.Length; i++)
          {
            if (lst[i].Sel)
            {
              lst[i].LNC_DATA_PGTO = DateTime.Now;
              lst[i].LNC_CCN_CODIGO = Sel.Saldo.SDC_CCN_CODIGO;
              dsLanc.Save(lst[i]);

              if (lst[i].ValorParcial != 0) 
              {
                lst[i].LNC_CODIGO = 0;
                lst[i].LNC_VALOR = lst[i].ValorParcial;
                lst[i].ValorParcial = 0;
                lst[i].LNC_DATA_PGTO = DateTime.MinValue;
                lst[i].LNC_CCN_CODIGO = 0;
                dsLanc.Save(lst[i]); 
              }
            }
          }//for (int i = 0; i < lst.Length; i++)
          Utilities.Cnn.CommitTransaction();
        }
        catch 
        { Utilities.Cnn.RollbackTransaction(); }

        PesquisarCartao();
      }
    }
    #endregion

    #region private void CheckMarck(bool Mark)
    private void CheckMarck(bool Mark) 
    {
      for (int i = 0; i < grdCartoes.Rows.Count; i++)
      {
        LNC_LANC_CARTOES lanc = grdCartoes.GetItem<LNC_LANC_CARTOES>(i);
        if (lanc.Sel != Mark)
        {
          lanc.Sel = Mark;
          AddSelecionado(lanc.Sel, lanc.LNC_VALOR, lanc.LNC_VALOR_TAXA, lanc.LNC_VALOR_RECEBER);
          grdCartoes.AlterItem(i, lanc);
        }
      }
    }
    #endregion

    #region Events
    private void dtEmissao_ValueChanged(object sender, EventArgs e)
    {
      PesquisarCartao();
    }

    private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
      PesquisarCartao();
    }

    private void LancaCartoes_Load(object sender, EventArgs e)
    {
      Carregar();
    }    
    
    private void grdCartoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
      {
        if (grdCartoes.SelectedRows.Count != 0)
        {
          LNC_LANC_CARTOES lanc = grdCartoes.GetItem<LNC_LANC_CARTOES>();

          if (e.ColumnIndex == 0)
          {
            lanc.Sel = !lanc.Sel;
            AddSelecionado(lanc.Sel, lanc.LNC_VALOR, lanc.LNC_VALOR_TAXA, lanc.LNC_VALOR_RECEBER);
          }
                    
          grdCartoes.AlterItem(lanc);
        }
      }
    }

    private void btnBaixar_Click(object sender, EventArgs e)
    {
      Baixar();
    }

    private void btnMarcarTodos_Click(object sender, EventArgs e)
    {
      CheckMarck(true);
    }

    private void btnDesmarcarTodos_Click(object sender, EventArgs e)
    {
      CheckMarck(false);
    }
    #endregion

    private void grdCartoes_DoubleClick(object sender, EventArgs e)
    {
      EditaLancamento();
    }

    private void grdCartoes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { EditaLancamento(); }
    }
  }
}
