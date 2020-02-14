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

namespace Financeiro_Marcelo.View
{
  public partial class Saldo : lib.Visual.Models.frmBase
  {
    public Saldo()
    {
      InitializeComponent();
      ds = new dsSDC_SALDO_CONTAS(Utilities.Cnn);
    }

    dsSDC_SALDO_CONTAS ds { get; set; }

    private void Carregar() 
    {
      cmbConta.ValueMember = "CCN_CODIGO";
      cmbConta.DisplayMember = "Descricao";
      cmbConta.DataSource = (new dsCCN_CADASTRO_CONTAS(Utilities.Cnn)).GetList();
      cmbUltimos.SelectedIndex = 0;

      ExibirUltimosRegistros();
    }

    private void ExibirUltimosRegistros() 
    {
      if (cmbConta.SelectedIndex != -1)
      {
        grdSaldo.Clear();
        grdSaldo.AddColumn(new FieldColumn("Data", "SDC_DATA", enmFieldType.DateTime));
        grdSaldo.AddColumn(new FieldColumn("Operação", "SDC_OPERACAO", enmFieldType.String, 180));
        grdSaldo.AddColumn(new FieldColumn("Valor Lanc.", "SDC_VALOR_LANCADO", enmFieldType.Decimal, 120));
        grdSaldo.AddColumn(new FieldColumn("Saldo Atual", "SDC_SALDO_ATUAL", enmFieldType.Decimal, 120));
        grdSaldo.AddColumn(new FieldColumn("Tipo", "SDC_TIPO", enmFieldType.String, 60));
        grdSaldo.AddItems(ds.GetUltimos((int)cmbConta.SelectedValue, (new lib.Class.Conversion()).ToInt(cmbUltimos.Text)));
      }
    }

    private void RegistraDepositoRetirada() 
    {
      View.DepositoRetirada DepRet = new View.DepositoRetirada();
      DepRet.Tab = new SDC_SALDO_CONTAS();
      DepRet.Tab.SDC_CCN_CODIGO = (int)cmbConta.SelectedValue;
      if (DepRet.Exec())
      { ExibirUltimosRegistros(); }
    }

    #region Events
    private void Saldo_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void btnSaldo_Click(object sender, EventArgs e)
    {
      RegistraDepositoRetirada();
    }
    
    private void cmbConta_SelectedIndexChanged(object sender, EventArgs e)
    {
      ExibirUltimosRegistros();
    }

    private void cmbUltimos_SelectedIndexChanged(object sender, EventArgs e)
    {
      ExibirUltimosRegistros();
    }
    
    private void sknButton1_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this.MdiParent, "Saldo");
    }
    #endregion
  }
}
