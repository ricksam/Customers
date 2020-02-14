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

namespace Financeiro_Marcelo
{
  public partial class CadastroContas : lib.Visual.Models.frmBaseCadastro
  {
    #region public CadastroContas()
    public CadastroContas()
    {
      InitializeComponent();
      bs = new dsCCN_CADASTRO_CONTAS(Utilities.Cnn);
    }
    #endregion

    #region Fields
    CCN_CADASTRO_CONTAS Tab { get; set; }
    dsCCN_CADASTRO_CONTAS bs { get; set; }
    #endregion

    #region Methods
    #region private void Carregar()
    private void Carregar() 
    {
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();
      cmbEmpresa.SelectedValue = Tab.CCN_EMP_CODIGO;
      txtBanco.Text = Tab.CCN_BANCO;
      txtAgencia.Text = Tab.CCN_AGENCIA;
      txtConta.Text = Tab.CCN_CONTA;

      CalculaSaldo();
    }
    #endregion

    #region private void CalculaSaldo()
    private void CalculaSaldo() 
    {
      txtSaldo.AsDecimal = (new dsSDC_SALDO_CONTAS(Utilities.Cnn)).GetSaldoAtual(Tab.CCN_CODIGO);
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      Tab = new CCN_CADASTRO_CONTAS();
      Carregar();
      base.OnNewRecord();
      cmbEmpresa.Select();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      Tab = Grid.GetItem<CCN_CADASTRO_CONTAS>();
      Carregar();
      base.OnAlterRecord(Grid);
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(
        string.Format(
        "Tem certeza que deseja remover esta conta ?")))
      {
        bs.Remove(Tab.CCN_CODIGO);
        base.OnRemoveRecord();
      }
    }
    #endregion
    
    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.CCN_EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
      Tab.CCN_BANCO = txtBanco.Text;
      Tab.CCN_AGENCIA = txtAgencia.Text;
      Tab.CCN_CONTA = txtConta.Text;
      if (bs.Save(Tab))
      { base.OnConfirm(); }
    }
    #endregion
    #endregion

    #region Events
    private void CadastroContas_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Empresa", "EMP_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Banco", "CCN_BANCO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Agencia", "CCN_AGENCIA", enmFieldType.String, 90));
      Grid.AddColumn(new FieldColumn("Conta", "CCN_CONTA", enmFieldType.String, 120));
      Grid.AddItems(bs.Search(TextSearch));
    }

    /*private void btnSaldo_Click(object sender, EventArgs e)
    {
      View.Cadastros.DepositoRetirada DepRet = new View.Cadastros.DepositoRetirada();
      DepRet.Tab = new SDC_SALDO_CONTAS();
      DepRet.Tab.SDC_CCN_CODIGO = Tab.CCN_CODIGO;
      if (DepRet.Exec())
      { CalculaSaldo(); }
    }*/
    #endregion        
  }
}
