using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Class;
using lib.Database.Query;
using lib.Database.Drivers;
using lib.Visual;

namespace MagiaTrigo
{
  public partial class frmOperacao : lib.Visual.Models.frmBaseCadastro
  {
    public frmOperacao()
    {
      InitializeComponent();
      ds = new dsOPR_OPERACAO(Utilities.Cnn);
    }

    OPR_OPERACAO Tab { get; set; }
    dsOPR_OPERACAO ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      cmbPlanoContas.DisplayMember="PLN_DESCRICAO";
      cmbPlanoContas.ValueMember = "PLN_CODIGO";
      cmbPlanoContas.DataSource = (new dsPLN_PLANO_CONTAS(Utilities.Cnn)).GetList();

      txtDescricao.Text = Tab.OPR_DESCRICAO;
      cbFinanceiro.Checked = Tab.OPR_PLN_CODIGO != 0;
      if (Tab.OPR_PLN_CODIGO != 0)
      { cmbPlanoContas.SelectedValue = Tab.OPR_PLN_CODIGO; }
      txtAdicionarEstoque.AsInt = Tab.OPR_ADDESTOQUE;
      txtDescricao.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new OPR_OPERACAO();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<OPR_OPERACAO>();
      Carregar();      
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.OPR_CODIGO)))
      { ds.Remove(Tab.OPR_CODIGO); }
      base.OnRemoveRecord();
    }
    #endregion

    #region private bool FaltaPreencher()
    private bool FaltaPreencher()
    {
      LockedField[] lf = ds.GetLockedFields(Tab);

      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "OPR_DESCRICAO")
        { txtDescricao.Select(); }
        if (lf[0].Field == "OPR_PLN_CODIGO")
        { cmbPlanoContas.Select(); }
        if (lf[0].Field == "OPR_ADDESTOQUE")
        { txtAdicionarEstoque.Select(); }
      }
      else if (cbFinanceiro.Checked && cmbPlanoContas.SelectedIndex == -1)
      {
        Msg.Warning("É necessário informar um plano de contas quando está marcado para lançar no financeiro");
        return true;
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.OPR_DESCRICAO = txtDescricao.Text;
      if (cmbPlanoContas.SelectedIndex != -1)
      { Tab.OPR_PLN_CODIGO = (int)cmbPlanoContas.SelectedValue; }

      if (!cbFinanceiro.Checked)
      { Tab.OPR_PLN_CODIGO = 0; }

      Tab.OPR_ADDESTOQUE = txtAdicionarEstoque.AsInt;
      if (!FaltaPreencher())
      {
        ds.Save(Tab);
        base.OnConfirm();
      }
    }
    #endregion

    #region Events
    private void Form_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Operação", "OPR_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Plano de Contas", "PLN_DESCRICAO", enmFieldType.String));
      Grid.AddItems(ds.Search(TextSearch));
    }

    private void cbFinanceiro_CheckedChanged(object sender, EventArgs e)
    {
      cmbPlanoContas.Enabled = cbFinanceiro.Checked;
    }
    #endregion    
  }
}

