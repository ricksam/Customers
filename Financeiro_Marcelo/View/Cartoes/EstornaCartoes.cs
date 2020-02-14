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
  public partial class EstornaCartoes : lib.Visual.Models.frmBase
  {
    public EstornaCartoes()
    {
      InitializeComponent();
      dsLanc = new dsLNC_LANC_CARTOES(Utilities.Cnn);
    }

    dsLNC_LANC_CARTOES dsLanc { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      dtPgto.Value = DateTime.Now.AddMonths(1);
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
      if (cmbEmpresa.SelectedIndex != -1 && dtPgto.Value != DateTime.MinValue)
      {
        LNC_LANC_CARTOES[] lst = dsLanc.GetList_Pagos((int)cmbEmpresa.SelectedValue, dtPgto.Value);

        grdCartoes.Clear();
        grdCartoes.AddColumn(new FieldColumn("Sel", "Sel", enmFieldType.Bool));
        grdCartoes.AddColumn(new FieldColumn("Cartão", "CRT_DESCRICAO", enmFieldType.String, 120));
        grdCartoes.AddColumn(new FieldColumn("Emissão", "LNC_EMISSAO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Vencimento", "LNC_VENCIMENTO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Pago", "LNC_DATA_PGTO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Valor", "LNC_VALOR", enmFieldType.Decimal, 90));
        grdCartoes.AddColumn(new FieldColumn("Taxa", "LNC_VALOR_TAXA", enmFieldType.Decimal, 60));
        grdCartoes.AddColumn(new FieldColumn("a Receber", "LNC_VALOR_RECEBER", enmFieldType.Decimal, 90));
        grdCartoes.AddItems(lst);

        txtValorTotal.AsDecimal = 0;
        txtTotalTaxas.AsDecimal = 0;
        txtTotalReceber.AsDecimal = 0;

        //for (int i = 0; i < lst.Length; i++)
        //{ AddTotal(lst[i].LNC_VALOR, lst[i].LNC_VALOR_TAXA, lst[i].LNC_VALOR_RECEBER); }
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
    private void Estornar() 
    {
      LNC_LANC_CARTOES[] lst = grdCartoes.GetItems<LNC_LANC_CARTOES>();
      if (!PossuiSelecionados(lst)) 
      {
        Msg.Warning("Selecione um ou mais cartões para estornar");
        return;
      }

      if (Msg.Question(string.Format("Tem certeza que deseja estornar o total: {0} ?", txtValorTotal.AsDecimal.ToString("#,##0.00"))))
      {
        
        dsSDC_SALDO_CONTAS dsSaldo = new dsSDC_SALDO_CONTAS(Utilities.Cnn);                
        for (int i = 0; i < lst.Length; i++)
        {
          if (lst[i].Sel)
          {
            Utilities.Cnn.BeginTransaction();
            SDC_SALDO_CONTAS saldo = dsSaldo.CreateSalto("ESTORNO DE CARTAO", enmTipoSaldoContas.Debito, lst[i].LNC_CCN_CODIGO, lst[i].LNC_VALOR_RECEBER);
            dsSaldo.Save(saldo);

            lst[i].LNC_DATA_PGTO = DateTime.MinValue;
            lst[i].LNC_CCN_CODIGO = 0;
            dsLanc.Save(lst[i]);
            Utilities.Cnn.CommitTransaction();
          }
        }//for (int i = 0; i < lst.Length; i++)        
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
      Estornar();
    }
    
    private void btnDesmarcarTodos_Click(object sender, EventArgs e)
    {
      CheckMarck(false);
    }

    private void btnMarcarTodos_Click(object sender, EventArgs e)
    {
      CheckMarck(true);
    }
    #endregion
  }
}
