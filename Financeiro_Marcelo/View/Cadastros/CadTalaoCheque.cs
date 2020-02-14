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
using lib.Class;
using lib.Visual;

namespace Financeiro_Marcelo.View.Cadastros
{
  public partial class CadTalaoCheque : lib.Visual.Models.frmBaseCadastro
  {
    public CadTalaoCheque()
    {
      InitializeComponent();
      ds = new dsTAL_TALAO_CHEQUE(Utilities.Cnn);
    }

    TAL_TALAO_CHEQUE Tab { get; set; }
    dsTAL_TALAO_CHEQUE ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();
            
      txtInicio.AsInt = Tab.TAL_INICIO;
      txtFim.AsInt = Tab.TAL_FIM;
      txtAtual.AsInt = Tab.TAL_ATUAL;

      if (Tab.TAL_EMP_CODIGO != 0)
      { cmbEmpresa.SelectedValue = Tab.TAL_EMP_CODIGO; }

      if (Tab.TAL_CCN_CODIGO != 0)
      { cmbContas.SelectedValue = Tab.TAL_CCN_CODIGO; }
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      Tab = new TAL_TALAO_CHEQUE();
      Carregar();
      base.OnNewRecord();
      txtInicio.Select();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      Tab = Grid.GetItem<TAL_TALAO_CHEQUE>();
      Carregar();
      base.OnAlterRecord(Grid);
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.TAL_CODIGO)))
      { ds.Remove(Tab.TAL_CODIGO); }
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

        if (lf[0].Field == "TAL_EMP_CODIGO")
        { cmbEmpresa.Select(); }
        else if (lf[0].Field == "TAL_CCN_CODIGO")
        { cmbContas.Select(); }
        else if (lf[0].Field == "TAL_INICIO")
        { txtInicio.Select(); }
        else if (lf[0].Field == "TAL_FIM")
        { txtFim.Select(); }        
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Conversion cnv = new Conversion();
      if (cmbEmpresa.SelectedIndex != -1)
      { Tab.TAL_EMP_CODIGO = cnv.ToInt(cmbEmpresa.SelectedValue); }

      if (cmbContas.SelectedIndex != -1)
      { Tab.TAL_CCN_CODIGO = cnv.ToInt(cmbContas.SelectedValue); }

      Tab.TAL_INICIO = txtInicio.AsInt;
      Tab.TAL_FIM = txtFim.AsInt;
      Tab.TAL_ATUAL = txtAtual.AsInt;
      if (!FaltaPreencher())
      {
        ds.Save(Tab);
        base.OnConfirm();
      }
    }
    #endregion

    #region Events
    private void Talao_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Empresa", "EMP_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Início", "TAL_INICIO", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Fim", "TAL_FIM", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Atual", "TAL_ATUAL", enmFieldType.Int));
      Grid.AddItems(ds.Search(TextSearch));
    }
    #endregion

    #region private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbEmpresa.SelectedIndex != -1)
      {
        cmbContas.DisplayMember = "Descricao";
        cmbContas.ValueMember = "CCN_CODIGO";
        cmbContas.DataSource = (new dsCCN_CADASTRO_CONTAS(Utilities.Cnn)).GetList_FromEmpresa((int)cmbEmpresa.SelectedValue);
      }
    }
    #endregion
  }
}
