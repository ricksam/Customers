using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual.Components;
using lib.Class;

namespace Folha_Marcelo.FORMS
{
  public partial class frmLancDiarioExpert : lib.Visual.Models.frmDialog
  {
    public frmLancDiarioExpert()
    {
      InitializeComponent();
      Cnv = new Conversion();
      Remuneracao = 1000;
    }

    Conversion Cnv { get; set; }
    int Mes { get; set; }
    int Ano { get; set; }
    int CodColaborador { get; set; }
    decimal Remuneracao { get; set; }

    public void setValue(int Mes, int Ano, int CodColaborador) 
    {
      this.Mes = Mes;
      this.Ano = Ano;
      this.CodColaborador = CodColaborador;
    }

    private void Carregar()
    {
      int ultimoDia = Convert.ToDateTime("01/" + Mes.ToString("00") + "/" + Ano.ToString("0000")).AddMonths(1).AddDays(-1).Day;

      #region Carrega os campos do dia      
      for (int i = 1; i <= ultimoDia; i++)
      {
        DateTime dt = Convert.ToDateTime(String.Format("{0}/{1}/{2}", i.ToString("00"), Mes.ToString("00"), Ano.ToString("0000")));
        sknTextBox txtDia = (sknTextBox)this.Controls.Find("txtDia" + i, true)[0];
        txtDia.Text = i + " " + dt.ToString("dddd", new System.Globalization.CultureInfo("pt-BR"));        
        if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
        { txtDia.ForeColor = Color.DarkRed; }
      }
      #endregion

      #region Carrega combos 
      dsOPR_OPERACAO dsOper = new dsOPR_OPERACAO(Utilities.Cnn);
      for (int i = 1; i <= ultimoDia; i++)
      {
        sknComboBox cmb = (sknComboBox)this.Controls.Find("cmbOperacao" + i, true)[0];
        cmb.Tag = i;
        cmb.DataSource = dsOper.GetList_FromDiario(true);
        cmb.SelectedIndex = -1;
        cmb.Enabled = true;
      }
      #endregion
    }

    private void Calcular(sknComboBox cmb, sknTextBox txt)
    {
      if (cmb.SelectedIndex != -1)
      {
        OPR_OPERACAO opr = ((OPR_OPERACAO)cmb.Items[cmb.SelectedIndex]);
        if (!string.IsNullOrEmpty(opr.OPR_CALCULO))
        {
          txt.Enabled = false;
          CFG_CONFIG cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();

          lib.Class.Calc c = new lib.Class.Calc();
          c.AddVariable(cfg.CFG_CAMPO_REMUNERACAO, Remuneracao);
          c.AddVariable(cfg.CFG_CAMPO_REFERENCIA, 1);
          c.SetExpression(opr.OPR_CALCULO);
          txt.AsDecimal = c.GetResult();
        }
        else
        { txt.Enabled = true; }
      }
    }

    private void frmLancDiarioExpert_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void cmbOperacao_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Delete)
      { ((sknComboBox)sender).SelectedIndex = -1; }
    }

    private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
    {
      sknComboBox cmb = (sknComboBox)sender;
      sknTextBox txt = (sknTextBox)this.Controls.Find("txtValor" + cmb.Tag, true)[0];
      Calcular(((sknComboBox)sender), txt);
    }
  }
}
