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
  public partial class frmLancResumo : lib.Visual.Models.frmDialog
  {
    public frmLancResumo()
    {
      InitializeComponent();
      Cnv = new lib.Class.Conversion();
    }
        
    #region Fields
    lib.Class.Conversion Cnv { get; set; }
    public LNC_LANCAMENTO Tab { get; set; }
    int Mes { get; set; }
    int Ano { get; set; }
    List<MathField> MathFields { get; set; }
    CFG_CONFIG Cfg { get; set; }
    #endregion

    #region public void SetDefaultValues(int Mes, int Ano, int Remuneracao)
    public void SetDefaultValues(int Mes, int Ano, List<MathField> Fields, CFG_CONFIG Cfg)
    {
      this.Mes = Mes;
      this.Ano = Ano;
      this.MathFields = Fields;
      this.Cfg = Cfg;
    }
    #endregion

    #region private void Carregar()
    private void Carregar()
    {
      cmbOperacao.ValueMember = "OPR_CODIGO";
      cmbOperacao.DisplayMember = "OPR_DESCRICAO";
      cmbOperacao.DataSource = (new dsOPR_OPERACAO(Utilities.Cnn)).GetList_FromDiario(false);

      if (Tab.LNC_OPR_CODIGO != 0)
      { cmbOperacao.SelectedValue = Tab.LNC_OPR_CODIGO; }

      txtValor.AsDecimal = Tab.LNC_VALOR;
      
      if (Tab.LNC_REFERENCIA == 0)
      {
        if (cmbReferencia.Items.Count != 0)
        { cmbReferencia.SelectedIndex = 0; }
        else
        { cmbReferencia.Text = "1"; }
      }
      else 
      { cmbReferencia.Text = Tab.LNC_REFERENCIA.ToString(); }

      cmbOperacao.Enabled = (Tab.LNC_CODIGO == 0);

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

          lib.Class.Calc c = new lib.Class.Calc();
          c.AddVariable(Cfg.CFG_CAMPO_REFERENCIA, Cnv.ToDecimal(cmbReferencia.Text));
          for (int i = 0; i < MathFields.Count; i++)
          { c.AddVariable(MathFields[i].Name, MathFields[i].Value); }

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

      Tab.LNC_MES = Mes;
      Tab.LNC_ANO = Ano;
      Tab.LNC_OPR_CODIGO = (int)cmbOperacao.SelectedValue;
      Tab.LNC_REFERENCIA = Cnv.ToDecimal(cmbReferencia.Text);
      Tab.LNC_VALOR = txtValor.AsDecimal;

      Tab.OPR_DESCRICAO = ((OPR_OPERACAO)cmbOperacao.SelectedItem).OPR_DESCRICAO;
      Tab.TipoOperacao = ((OPR_OPERACAO)cmbOperacao.SelectedItem).TipoOperacao;

      base.OnConfirm();
    }
    #endregion

    #region Events
    private void frmLancResumo_Load(object sender, EventArgs e)
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

  #region public class MathField
  public class MathField
  {
    public MathField(string Name, decimal Value) 
    {
      this.Name = Name;
      this.Value = Value;
    }
    public string Name { get; set; }
    public decimal Value { get; set; }
  }
  #endregion
}
