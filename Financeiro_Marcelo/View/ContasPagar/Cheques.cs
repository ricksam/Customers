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

namespace Financeiro_Marcelo.View.ContasPagar
{
  public partial class Cheques : lib.Visual.Models.frmBase
  {
    public Cheques()
    {
      InitializeComponent();
      dsBcn = new dsBCN_BAIXA_CONTAS(Utilities.Cnn);
      dsCpg = new dsCPG_CONTAS_PAGAR(Utilities.Cnn);
    }

    dsBCN_BAIXA_CONTAS dsBcn { get; set; }
    dsCPG_CONTAS_PAGAR dsCpg { get; set; }

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
        grdCheques.Clear();
        grdLancamentos.Clear();
        grdCheques.AddColumn(new FieldColumn("Compensar", "BCN_COMPENSADO", enmFieldType.Bool, 70));
        grdCheques.AddColumn(new FieldColumn("Conta", "Conta", enmFieldType.String, 300));
        grdCheques.AddColumn(new FieldColumn("Nr. Cheque", "BCN_NUMERO_CHEQUE", enmFieldType.String, 80));
        grdCheques.AddColumn(new FieldColumn("Dt. Pgto", "BCN_DATA_PGTO", enmFieldType.Date));
        grdCheques.AddColumn(new FieldColumn("Valor", "BCN_VALOR", enmFieldType.Decimal));
        grdCheques.AddItems(dsBcn.GetList_FromEmpresaACompensar((int)cmbEmpresa.SelectedValue));
      }
    }

    private void CarregaContas()
    {
      if (grdCheques.SelectedRows.Count != 0)
      {
        grdLancamentos.Clear();
        grdLancamentos.AddColumn(new FieldColumn("Categoria", "CAT_DESCRICAO", enmFieldType.String, 120));
        grdLancamentos.AddColumn(new FieldColumn("Plano Contas", "PLN_DESCRICAO", enmFieldType.String, 120));
        grdLancamentos.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String, 120));
        grdLancamentos.AddColumn(new FieldColumn("Entrada", "FIN_DATA", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Emissão", "FIN_EMISSAO", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Vencimento", "CPG_VENCIMENTO", enmFieldType.Date));
        grdLancamentos.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal));
        grdLancamentos.AddItems(dsCpg.GetList_FromBaixa(grdCheques.GetItem<BCN_BAIXA_CONTAS>().BCN_CODIGO));
      }
    }

    private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregarBaixas();
    }

    private void Cheques_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void grdCheques_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      CarregaContas();
    }

    private void btnCompensar_Click(object sender, EventArgs e)
    {
      if (cmbEmpresa.SelectedIndex == -1)
      {
        Msg.Warning("Selecione uma empresa");
        cmbEmpresa.Select();
        return;
      }

      BCN_BAIXA_CONTAS[] BcnList = grdCheques.GetItems<BCN_BAIXA_CONTAS>();
      List<int> CodComp = new List<int>();
      for (int i = 0; i < BcnList.Length; i++)
      {
        if (BcnList[i].BCN_COMPENSADO) 
        {
          CodComp.Add(BcnList[i].BCN_CODIGO);
          BcnList[i].BCN_DATA_COMPENSACAO = DateTime.Now;
          dsBcn.Save(BcnList[i]);
        }
      }

      string strparam = "";
      for (int i = 0; i < CodComp.Count; i++)
      { strparam += CodComp[i].ToString() + (i != CodComp.Count - 1 ? "," : ""); }

      //List<SqlWebReport.ParamQuery> lst = new List<SqlWebReport.ParamQuery>();
      //lst.Add(new SqlWebReport.ParamQuery(strparam, enmFieldType.String));
      //Utilities.ExibeReport("ChequesCompensados",lst);

      CarregarBaixas();
    }

    private void grdCheques_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      BCN_BAIXA_CONTAS Bcn = grdCheques.GetItem<BCN_BAIXA_CONTAS>();
      Bcn.BCN_COMPENSADO = !Bcn.BCN_COMPENSADO;
      grdCheques.AlterItem(Bcn);
    }
  }
}
