using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Class;
using lib.Visual;
using Financeiro_Marcelo;

namespace Financeiro_Marcelo.Fechamento
{
  public partial class Balanco : lib.Visual.Models.frmDialog
  {
    #region Constructor
    public Balanco()
    {
      InitializeComponent();
      bsBal = new dsBAL_BALANCO(Utilities.Cnn);
      Cnv = new Conversion();
    }
    #endregion

    #region Fields
    dsBAL_BALANCO bsBal { get; set; }
    Conversion Cnv { get; set; }
    #endregion

    #region Methods
    private void Carregar()
    {
      //Carregar ultimos fechamentos
      cmbEmpresas.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresas.ValueMember = "EMP_CODIGO";
      cmbEmpresas.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();
      
      cmbEmpresas.SelectedIndex = -1;

      ExibeFechamentosEmpresa();
      txtApuracao.AsDateTime = DateTime.Now;
    }

    private void ExibeFechamentosEmpresa()
    {
      bool EmpSel = (cmbEmpresas.SelectedIndex != -1);
      if (EmpSel)
      {
        cmbFechamentoAnterior.DisplayMember = "BAL_DATA";
        cmbFechamentoAnterior.ValueMember = "BAL_DATA";
        cmbFechamentoAnterior.DataSource = bsBal.GetList_UltimosFechamentos((int)cmbEmpresas.SelectedValue);        
      }

      cmbFechamentoAnterior.Enabled = EmpSel;
      txtApuracao.Enabled = EmpSel;
      txtEstoqueFinal.Enabled = EmpSel;
    }

    private void PesquisaCompras() 
    {
      List<SqlWebReport.ParamQuery> parList = new List<SqlWebReport.ParamQuery>();

      txtEstoqueInicial.AsDecimal = 0;
      if (cmbFechamentoAnterior.SelectedIndex != -1)
      {
        BAL_BALANCO BalAnt = ((BAL_BALANCO)cmbFechamentoAnterior.SelectedItem);
        txtEstoqueInicial.AsDecimal = BalAnt.BAL_ESTOQUE_FINAL;
        parList.Add(new SqlWebReport.ParamQuery(BalAnt.BAL_DATA, SqlWebReport.FieldType.Date));
      }
      else
      { parList.Add(new SqlWebReport.ParamQuery(DateTime.Now, SqlWebReport.FieldType.Date)); }

      parList.Add(new SqlWebReport.ParamQuery(txtApuracao.AsDateTime, SqlWebReport.FieldType.Date));
      parList.Add(new SqlWebReport.ParamQuery(cmbEmpresas.SelectedValue, SqlWebReport.FieldType.Int));

      string SwrVal = Utilities.GetSwr("Balanco_Compras", parList);
      txtCompras.AsDecimal = Cnv.ToDecimal(SwrVal);
      CalculaCMV();
    }
    
    private void CalculaCMV()
    {
      txtCMV.AsDecimal = (txtCompras.AsDecimal + txtEstoqueInicial.AsDecimal) - txtEstoqueFinal.AsDecimal;
    }

    protected override void OnConfirm()
    {
      PesquisaCompras();
      CalculaCMV();

      if (!Msg.Question(
        string.Format(
          "Tem certeza que deseja gerar o balanço para o período entre {0} até {1}?",
          Cnv.ToDateTime(cmbFechamentoAnterior.Text).AddDays(1).ToString("dd/MM/yyyy"),
          txtApuracao.AsDateTime.ToString("dd/MM/yyyy"))
        ))
      { return; }

      BAL_BALANCO Bal = new BAL_BALANCO();
      if (cmbFechamentoAnterior.SelectedIndex != -1)
      {
        BAL_BALANCO BalAnt = ((BAL_BALANCO)cmbFechamentoAnterior.SelectedItem);
        Bal.BAL_ANTERIOR = BalAnt.BAL_CODIGO;
        Bal.BAL_ESTOQUE_INICIAL = BalAnt.BAL_ESTOQUE_FINAL;
        Bal.BAL_INICIO = BalAnt.BAL_DATA.AddDays(1);
      }

      Bal.BAL_EMP_CODIGO = (int)cmbEmpresas.SelectedValue;
      Bal.BAL_ESTOQUE_FINAL = txtEstoqueFinal.AsDecimal;
      Bal.BAL_COMPRAS = txtCompras.AsDecimal;
      Bal.BAL_DATA = txtApuracao.AsDateTime;
      Bal.BAL_CMV = txtCMV.AsDecimal;
      bsBal.Save(Bal);

      Utilities.ExibeReport("Balanco");
      //Msg.Information("Balanço gerado com sucesso!");
      //base.OnConfirm();
    }
    #endregion

    #region Events
    private void cmbFechamentoAnterior_SelectedIndexChanged(object sender, EventArgs e)
    {
      PesquisaCompras();
    }

    private void txtEstoqueFinal_TextChanged(object sender, EventArgs e)
    {
      CalculaCMV();
    }

    private void Balanco_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
    {
      ExibeFechamentosEmpresa();
    }
    
    private void txtApuracao_Leave(object sender, EventArgs e)
    {
      PesquisaCompras();
    }

    private void txtEstoqueFinal_Leave(object sender, EventArgs e)
    {
      PesquisaCompras();
    }
    #endregion

    private void sknButton1_Click(object sender, EventArgs e)
    {
      UltimosBalancos u = new UltimosBalancos();
      u.ShowDialog();
    }
  }
}
