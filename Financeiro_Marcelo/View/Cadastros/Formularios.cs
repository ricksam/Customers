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

namespace Financeiro_Marcelo.View.Cadastros
{
  public partial class Formularios : lib.Visual.Models.frmBase
  {
    public Formularios()
    {
      InitializeComponent();

      Config = new Config();
      dsEmp = new dsEMP_EMPRESAS(Utilities.Cnn);

      try
      { Config.Open(); }
      catch (Exception ex)
      { Utilities.FormError.ShowError(ex); }
    }

    dsEMP_EMPRESAS dsEmp { get; set; }
    Config Config { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      try
      {        
        ExibeEmpresas();
        CarregaUltimosLancamentos();
      }
      catch (Exception ex)
      { Utilities.FormError.ShowError(ex); }
    }
    #endregion

    #region private void ExibeEmpresas()
    private void ExibeEmpresas()
    {
      cmbEmpresa.SelectedIndexChanged -= new EventHandler(cmbEmpresa_SelectedIndexChanged);
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DataSource = dsEmp.GetList();
      cmbEmpresa.SelectedIndexChanged += new EventHandler(cmbEmpresa_SelectedIndexChanged);

    }
    #endregion

    #region private void ExibeUltimosLancamentos(VW_ULTIMOS_LANCAMENTOS[] lst)
    private void ExibeUltimosLancamentos(FRM_FORMULARIOS[] lst)
    {
      int idx = 0;
      if (lstLancamentos.SelectedRows.Count != 0)
      { idx = lstLancamentos.SelectedRows[0].Index; }

      lstLancamentos.Clear();
      lstLancamentos.AddColumn(new FieldColumn("Empresa", "EMP_DESCRICAO", enmFieldType.String, 200));
      lstLancamentos.AddColumn(new FieldColumn("Nro. Formulário", "FRM_NUMERO", enmFieldType.String, 90));
      lstLancamentos.AddColumn(new FieldColumn("Data", "FRM_DATA", enmFieldType.Date, 90));
      lstLancamentos.AddColumn(new FieldColumn("Resultado", "Resultado", enmFieldType.Decimal));
      lstLancamentos.AddColumn(new FieldColumn("Compras", "FRM_TOTCOMPRAS", enmFieldType.Decimal));
      lstLancamentos.AddColumn(new FieldColumn("Bloqueado", "FRM_BLOQUEADO", enmFieldType.Bool));
      if (lst.Length != 0)
      { lstLancamentos.AddItems(lst); }

      if (lstLancamentos.Rows.Count > idx)
      { lstLancamentos.Rows[idx].Selected = true; }
    }
    #endregion

    #region private void CarregaUltimosLancamentos()
    private void CarregaUltimosLancamentos()
    {
      if (cmbEmpresa.SelectedIndex != -1)
      {
        FRM_FORMULARIOS[] lst = (new dsFRM_FORMULARIOS(Utilities.Cnn)).GetUltimosFormularios(
          ((EMP_EMPRESAS)cmbEmpresa.SelectedItem).EMP_CODIGO,
          Config.NrFormulariosTelaInicial);
        ExibeUltimosLancamentos(lst);
      }
    }
    #endregion

    #region private void SelecionaLancamento()
    private void SelecionaLancamento()
    {
      if (lstLancamentos.SelectedRows.Count != 0)
      {
        FRM_FORMULARIOS Frm = lstLancamentos.GetItem<FRM_FORMULARIOS>();
        txtNrFormulario.AsInt = Frm.FRM_NUMERO;
        txtData.AsDateTime = Frm.FRM_DATA;
      }
    }
    #endregion

    #region private void EditarLancamentos()
    private void EditarLancamentos()
    {
      if (cmbEmpresa.SelectedValue == null)
      { return; }

      Financeiro f = new Financeiro();
      f.Vda = null;
      f.Frm = (new dsFRM_FORMULARIOS(Utilities.Cnn)).Get((int)cmbEmpresa.SelectedValue, txtNrFormulario.AsInt, txtData.AsDateTime);

      if (txtData.AsDateTime == DateTime.MinValue || txtNrFormulario.AsInt == 0)
      {
        Msg.Information("Informe o número do formulário e a data");
        txtData.Select();
        return;
      }

      //Isto parece estar repetido porém serve para novos formulário
      f.Frm.FRM_EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
      f.Frm.FRM_NUMERO = txtNrFormulario.AsInt;
      f.Frm.FRM_DATA = txtData.AsDateTime;

      if (f.Frm.FRM_BLOQUEADO && !Utilities.Liberar())
      { return; }

      f.Exec();

      CarregaUltimosLancamentos();

      cmbEmpresa.Select();
    }
    #endregion

    #region private void ExcluirFormulário()
    private void ExcluirFormulário()
    {
      if (lstLancamentos.SelectedRows.Count != 0)
      {
        FRM_FORMULARIOS Frm = lstLancamentos.GetItem<FRM_FORMULARIOS>();
        if ((new dsFIN_FINANCEIRO(Utilities.Cnn)).FormularioTemFinanceiro(Frm.FRM_CODIGO))
        {
          Msg.Warning("Só é possível excluir formulários vazios!");
          return;
        }

        (new dsFRM_FORMULARIOS(Utilities.Cnn)).Remove(Frm.FRM_CODIGO);
        CarregaUltimosLancamentos();
      }
    }
    #endregion

    #region Events
    private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaUltimosLancamentos();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      EditarLancamentos();
    }

    private void lstLancamentos_DoubleClick(object sender, EventArgs e)
    {
      SelecionaLancamento();
      EditarLancamentos();
    }

    private void lstLancamentos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { EditarLancamentos(); }
    }

    private void lstLancamentos_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      SelecionaLancamento();
    }

    private void exibirRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      List<SqlWebReport.ParamQuery> lst = new List<SqlWebReport.ParamQuery>();
      lst.Add(new SqlWebReport.ParamQuery(lstLancamentos.GetItem<FRM_FORMULARIOS>().FRM_CODIGO.ToString(), SqlWebReport.FieldType.Int));
      Utilities.ExibeReport(this.MdiParent, "Formulario", lst);
    }

    private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ExcluirFormulário();
    }
    #endregion

    private void Formularios_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void sknButton1_Click(object sender, EventArgs e)
    {
      if (lstLancamentos.SelectedRows.Count != 0)
      { 
        List<SqlWebReport.ParamQuery> Params = new List<SqlWebReport.ParamQuery>();
        Params.Add(new SqlWebReport.ParamQuery(lstLancamentos.GetItem<FRM_FORMULARIOS>().FRM_CODIGO, SqlWebReport.FieldType.Int));
        Utilities.ExibeReport(this.MdiParent, "Item_Formulario", Params);
      }
    }
  }
}
