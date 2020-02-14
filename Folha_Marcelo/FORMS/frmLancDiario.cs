using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folha_Marcelo.FORMS
{
  public partial class frmLancDiario : lib.Visual.Models.frmDialog
  {
    public frmLancDiario()
    {
      InitializeComponent();
      Cnv = new lib.Class.Conversion();
    }

    lib.Class.Conversion Cnv { get; set; }
    public LCD_LANCAMENTO_DIARIO Tab { get; set; }
    int Mes { get; set; }
    int Ano { get; set; }
    decimal Remuneracao { get; set; }

    #region public void SetDefaultValues(int Mes, int Ano, int Remuneracao)
    public void SetDefaultValues(int Mes, int Ano, decimal Remuneracao)
    {
      this.Mes = Mes;
      this.Ano = Ano;
      this.Remuneracao = Remuneracao;
      lblMesAno.Text = string.Format("{0}/{1}", Mes, Ano); 
    }
    #endregion

    #region private void Carregar()
    private void Carregar() 
    {
      cmbOperacao.ValueMember = "OPR_CODIGO";
      cmbOperacao.DisplayMember = "OPR_DESCRICAO";
      cmbOperacao.DataSource = (new dsOPR_OPERACAO(Utilities.Cnn)).GetList_FromDiario(true);

      txtDescricao.Text = Tab.LCD_DESCRICAO;

      if (Tab.LCD_DATA != DateTime.MinValue)
      { txtDia.AsInt = Tab.LCD_DATA.Day; }
      else
      { txtDia.AsInt = DateTime.Now.Day; }

      if (Tab.LCD_OPR_CODIGO != 0)
      { cmbOperacao.SelectedValue = Tab.LCD_OPR_CODIGO; }

      txtValor.AsDecimal = Tab.LCD_VALOR;

      if (Tab.LCD_REFERENCIA == 0)
      {
        if (cmbReferencia.Items.Count != 0)
        { cmbReferencia.SelectedIndex = 0; }
        else
        { cmbReferencia.Text = "1"; }
      }
      else 
      { cmbReferencia.Text = Tab.LCD_REFERENCIA.ToString(); }

      cmbOperacao.Enabled = (Tab.LCD_CODIGO == 0);

      Calcular();
    }
    #endregion

    #region private void Calcular()
    private void Calcular() 
    {
      if (cmbOperacao.SelectedIndex != -1) 
      {
        OPR_OPERACAO opr = ((OPR_OPERACAO)cmbOperacao.Items[cmbOperacao.SelectedIndex]);
        if (!string.IsNullOrEmpty(opr.OPR_CALCULO))
        {
          txtValor.Enabled = false;
          CFG_CONFIG cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();

          lib.Class.Calc c = new lib.Class.Calc();
          c.AddVariable(cfg.CFG_CAMPO_REMUNERACAO, Remuneracao);
          c.AddVariable(cfg.CFG_CAMPO_REFERENCIA, Cnv.ToDecimal(cmbReferencia.Text));
          c.SetExpression(opr.OPR_CALCULO);
          txtValor.AsDecimal = c.GetResult();
        }
        else 
        { txtValor.Enabled = true; }
      }
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbOperacao.SelectedIndex == -1)
      {
        lib.Visual.Msg.Warning("Selecione uma operação");
        return;
      }

      Tab.LCD_DESCRICAO = txtDescricao.Text;
      Tab.LCD_DIA = txtDia.AsInt;
      Tab.LCD_MES = Mes;
      Tab.LCD_ANO = Ano;
      Tab.LCD_DATA = Cnv.ToDateTime(string.Format("{0}/{1}/{2}", Tab.LCD_DIA, Tab.LCD_MES, Tab.LCD_ANO));
      Tab.LCD_OPR_CODIGO = (int)cmbOperacao.SelectedValue;
      Tab.LCD_REFERENCIA = Cnv.ToDecimal(cmbReferencia.Text);
      Tab.LCD_VALOR = txtValor.AsDecimal;

      Tab.OPR_DESCRICAO = ((OPR_OPERACAO)cmbOperacao.SelectedItem).OPR_DESCRICAO;
      Tab.TipoOperacao = ((OPR_OPERACAO)cmbOperacao.SelectedItem).TipoOperacao;

      base.OnConfirm();

    }
    #endregion

    #region Events
    private void frmLancDiario_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void cmbReferencia_TextChanged(object sender, EventArgs e)
    {
      Calcular();
    }

    private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
    {
      Calcular();
    }

    private void txtValor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F2 && txtValor.Enabled)
      {
        Expressao ex = new Expressao();
        ex.ShowDialog();
        txtValor.AsDecimal = ex.Result();
        txtValor.Select();
        e.Handled = true;
      }
    }
    #endregion
  }
}
