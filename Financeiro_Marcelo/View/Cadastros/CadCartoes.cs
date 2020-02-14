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

namespace Financeiro_Marcelo
{
  public partial class frmCRT_CARTOES : lib.Visual.Models.frmBaseCadastro
  {
    public frmCRT_CARTOES()
    {
      InitializeComponent();
      ds = new dsCRT_CARTOES(Utilities.Cnn);
    }

    CRT_CARTOES Tab { get; set; }
    dsCRT_CARTOES ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {      
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();

      if (Tab.CRT_EMP_CODIGO != 0)
      { cmbEmpresa.SelectedValue = Tab.CRT_EMP_CODIGO; }
      else
      { cmbEmpresa.SelectedIndex = -1; }

      txtCRT_DESCRICAO.Text = Tab.CRT_DESCRICAO;
      txtCRT_NRDIAS.AsInt = Tab.CRT_NRDIAS;
      txtFecha_NrDias.AsInt = Tab.CRT_NRDIAS;
      txtCRT_VENCIMENTOS.Text = Tab.CRT_VENCIMENTOS;
      txtCRT_TAXA.AsDecimal = Tab.CRT_TAXA;
      if (Tab.CRT_SEMANA != 0)
      { cmbSemana.SelectedIndex = Tab.CRT_SEMANA - 1; }

      txtCRT_NRDIAS.Enabled = false;
      txtCRT_VENCIMENTOS.Enabled = false;

      if (Tab.CRT_SEMANA != 0)
      { rbFechamento.Checked = true; }
      else if (txtCRT_NRDIAS.AsInt != 0)
      { rbApos.Checked = true; }

      if (!string.IsNullOrEmpty(txtCRT_VENCIMENTOS.Text))
      { rbFixo.Checked = true; }

      HabilitaComponentes();

      cmbEmpresa.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new CRT_CARTOES();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<CRT_CARTOES>();
      Carregar();
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.CRT_CODIGO)))
      { ds.Remove(Tab.CRT_CODIGO); }
      base.OnRemoveRecord();
    }
    #endregion

    #region private void HabilitaComponentes()
    private void HabilitaComponentes() 
    {
      cmbSemana.Enabled = rbFechamento.Checked;
      txtFecha_NrDias.Enabled = rbFechamento.Checked;
      txtCRT_NRDIAS.Enabled = rbApos.Checked;
      txtCRT_VENCIMENTOS.Enabled = rbFixo.Checked;
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

        if (lf[0].Field == "CRT_EMP_CODIGO")
        { cmbEmpresa.Select(); }
        if (lf[0].Field == "CRT_DESCRICAO")
        { txtCRT_DESCRICAO.Select(); }
        if (lf[0].Field == "CRT_NRDIAS")
        { txtCRT_NRDIAS.Select(); }
        if (lf[0].Field == "CRT_VENCIMENTOS")
        { txtCRT_VENCIMENTOS.Select(); }
        if (lf[0].Field == "CRT_TAXA")
        { txtCRT_TAXA.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbEmpresa.SelectedIndex != -1)
      { Tab.CRT_EMP_CODIGO = (int)cmbEmpresa.SelectedValue; }
      else 
      { Tab.CRT_EMP_CODIGO = 0; }

      Tab.CRT_DESCRICAO = txtCRT_DESCRICAO.Text;

      if (rbFechamento.Checked)
      {
        Tab.CRT_SEMANA = cmbSemana.SelectedIndex + 1;
        Tab.CRT_NRDIAS = txtFecha_NrDias.AsInt;
      }
      else
      {
        Tab.CRT_SEMANA = 0;
        txtFecha_NrDias.AsInt = 0;
      }

      if (rbApos.Checked)
      { Tab.CRT_NRDIAS = txtCRT_NRDIAS.AsInt; }

      if (!rbFechamento.Checked && !rbApos.Checked)
      { Tab.CRT_NRDIAS = 0; }

      if (rbFixo.Checked)
      { Tab.CRT_VENCIMENTOS = txtCRT_VENCIMENTOS.Text; }
      else
      { Tab.CRT_VENCIMENTOS = ""; }

      Tab.CRT_TAXA = txtCRT_TAXA.AsDecimal;

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
      Grid.AddColumn(new FieldColumn("Empresa", "EMP_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Descrição", "CRT_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Nr. Dias", "CRT_NRDIAS", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Vencimentos", "CRT_VENCIMENTOS", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Taxa", "CRT_TAXA", enmFieldType.Decimal));
      Grid.AddItems(ds.Search(TextSearch));
    }
    
    private void rb_CheckedChanged(object sender, EventArgs e)
    {
      HabilitaComponentes();      
    }
    #endregion
  }
}

