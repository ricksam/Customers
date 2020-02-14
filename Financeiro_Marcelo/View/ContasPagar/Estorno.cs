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
  public partial class Estorno : lib.Visual.Models.frmBase
  {
    public Estorno()
    {
      InitializeComponent();
      bsBcn = new dsBCN_BAIXA_CONTAS(Utilities.Cnn);
      bsCpg = new dsCPG_CONTAS_PAGAR(Utilities.Cnn);
    }

    dsBCN_BAIXA_CONTAS bsBcn { get; set; }
    dsCPG_CONTAS_PAGAR bsCpg { get; set; }

    private void Carregar() 
    {
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();      
    }

    private void CarregarBaixas() 
    {
      if (cmbEmpresa.SelectedIndex != -1)
      {
        grdEstorno.Clear();
        grdLancamentos.Clear();
        grdEstorno.AddColumn(new FieldColumn("Compensado", "BCN_COMPENSADO", enmFieldType.Bool, 70));
        grdEstorno.AddColumn(new FieldColumn("Conta", "Conta", enmFieldType.String, 300));
        grdEstorno.AddColumn(new FieldColumn("Nr. Cheque", "BCN_NUMERO_CHEQUE", enmFieldType.String, 80));
        grdEstorno.AddColumn(new FieldColumn("Descrição", "BCN_DESCRICAO", enmFieldType.String, 120));
        grdEstorno.AddColumn(new FieldColumn("Dt. Pgto", "BCN_DATA_PGTO", enmFieldType.Date));
        grdEstorno.AddColumn(new FieldColumn("Dt. Compens.", "BCN_DATA_COMPENSACAO", enmFieldType.Date));
        grdEstorno.AddColumn(new FieldColumn("Valor", "BCN_VALOR", enmFieldType.Decimal, 90));
        grdEstorno.AddItems(bsBcn.GetList_FromEmpresa((int)cmbEmpresa.SelectedValue));
      }
    }

    private void CarregaContas() 
    {
      if (grdEstorno.SelectedRows.Count != 0)
      {
        grdLancamentos.Clear();
        grdLancamentos.AddColumn(new FieldColumn("Categoria", "CAT_DESCRICAO", enmFieldType.String, 120));
        grdLancamentos.AddColumn(new FieldColumn("Plano Contas", "PLN_DESCRICAO", enmFieldType.String, 120));
        grdLancamentos.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String, 120));
        grdLancamentos.AddColumn(new FieldColumn("Entrada", "FIN_DATA", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Emissão", "FIN_EMISSAO", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Vencimento", "CPG_VENCIMENTO", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal));
        grdLancamentos.AddItems(bsCpg.GetList_FromBaixa(grdEstorno.GetItem<BCN_BAIXA_CONTAS>().BCN_CODIGO));
      }
    }

    private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregarBaixas();
    }

    private void btnEstornar_Click(object sender, EventArgs e)
    {
      if (cmbEmpresa.SelectedIndex == -1)
      {
        Msg.Warning("Selecione uma empresa");
        cmbEmpresa.Select();
        return;
      }

      if (grdEstorno.SelectedRows.Count == 0)
      {
        Msg.Warning("Selecione uma baixa para estornar");
        grdEstorno.Select();
        return;
      }
      else 
      {
        BCN_BAIXA_CONTAS Bcn = grdEstorno.GetItem<BCN_BAIXA_CONTAS>();
        string Baixa = string.Format("\n Conta:{0}\n Nr. Cheque:{1}\n Valor:{2}",
          Bcn.Conta,
          Bcn.BCN_NUMERO_CHEQUE,
          Bcn.BCN_VALOR
          );

        if (Msg.Question(string.Format("Tem certeza que deseja estornar a baixa {0}", Baixa))) 
        {
          Utilities.Cnn.BeginTransaction();
          try
          {
            bsCpg.Remover_FromBaixa(Bcn.BCN_CODIGO);
            bsBcn.Remove(Bcn.BCN_CODIGO);

            #region Lança registro saldo
            dsSDC_SALDO_CONTAS dsSaldo = new dsSDC_SALDO_CONTAS(Utilities.Cnn);
            dsSaldo.Save(dsSaldo.CreateSalto("ESTORNO DE CONTAS", enmTipoSaldoContas.Credito, Bcn.BCN_CCN_CODIGO, Bcn.BCN_VALOR));
            #endregion

            Utilities.Cnn.CommitTransaction();
                        
          }
          catch (Exception ex) 
          {
            Utilities.Cnn.RollbackTransaction();
            Utilities.FormError.ShowError(ex);
          }
          CarregarBaixas();
        }
      }
    }

    private void Estorno_Load(object sender, EventArgs e)
    {
      Carregar();
    }
        
    private void grdEstorno_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      CarregaContas();
    }
  }
}
