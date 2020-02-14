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

namespace Folha_Marcelo.VIEW
{
  public partial class frmPendencias : lib.Visual.Models.frmBase
  {
    #region public frmPendencias()
    public frmPendencias()
    {
      InitializeComponent();
      ds = new dsALT_ALERTAS(Utilities.Cnn);
    }
    #endregion

    dsALT_ALERTAS ds { get; set; }
    ALT_ALERTAS Tab { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      cmbOcorrencia.ValueMember = "OCR_CODIGO";
      cmbOcorrencia.DisplayMember = "OCR_DESCRICAO";
      cmbOcorrencia.DataSource = (new dsOCR_OCORRENCIA(Utilities.Cnn)).GetList();
      cmbOcorrencia.SelectedIndex = -1;

      grdAlertas.Clear();
      grdAlertas.AddColumn(new FieldColumn("1º Alerta", "ALT_DATA", enmFieldType.Date));
      grdAlertas.AddColumn(new FieldColumn("Data Final", "ALT_DATA_FINAL", enmFieldType.Date));
      grdAlertas.AddColumn(new FieldColumn("Empresa", "EMP_NOME", enmFieldType.Date));
      grdAlertas.AddColumn(new FieldColumn("Nome", "CLB_NOME", enmFieldType.Date));
      grdAlertas.AddColumn(new FieldColumn("Mensagem", "ALT_MENSAGEM", enmFieldType.String));
      grdAlertas.AddColumn(new FieldColumn("Origem", "OCR_DESCRICAO", enmFieldType.String));
      grdAlertas.AddItems(ds.GetList_FrmAtivos());
      ExibeDadosAlerta();
    }
    #endregion
    
    #region private void EncerrarAlerta()
    private void EncerrarAlerta() 
    {
      Tab.ALT_INATIVO = true;
      ds.Save(Tab);
    }
    #endregion

    #region private void NovaOcorrencia()
    private void NovaOcorrencia() 
    {
      btnEncerrarAlertaNovaOcorrencia.Enabled = false;
      try
      {
        if (cmbOcorrencia.SelectedIndex == -1)
        {
          lib.Visual.Msg.Warning("Informe uma nova ocorrência");
          return;
        }

        dsHTR_HISTORICO dsHst = new dsHTR_HISTORICO(Utilities.Cnn);
        HTR_HISTORICO h = new HTR_HISTORICO();
        h.HTR_DATA = DateTime.Now;
        h.HTR_EMP_CODIGO = Tab.ALT_EMP_CODIGO;
        h.HTR_CLB_CODIGO = Tab.ALT_CLB_CODIGO;
        h.HTR_OCR_CODIGO = (int)cmbOcorrencia.SelectedValue;
        h.HTR_OBSERVACAO = txtObservacao.Text;
        
        ItemAlerta f = new ItemAlerta();
        f.Tab = Utilities.GeraNovoAlerta(h);

        if (f.Tab.ALT_DATA != DateTime.MinValue && f.Exec())
        {
          try
          {
            Utilities.Cnn.BeginTransaction();
            dsHst.Save(h);

            dsALT_ALERTAS dsAlt = new dsALT_ALERTAS(Utilities.Cnn);
            dsAlt.Remove_FromOCR(h.HTR_CLB_CODIGO, h.HTR_OCR_CODIGO);
            dsAlt.Save(f.Tab);

            Utilities.Cnn.CommitTransaction();
          }
          catch
          { Utilities.Cnn.RollbackTransaction(); }
        }
        else
        { dsHst.Save(h); }
      }
      catch 
      { btnEncerrarAlertaNovaOcorrencia.Enabled = true; }
    }
    #endregion

    #region private void EncerrarAlertaNovaOcorrencia()
    private void EncerrarAlertaNovaOcorrencia() 
    {
      if (cmbOcorrencia.SelectedIndex == -1)
      {
        lib.Visual.Msg.Warning("Informe uma nova ocorrência");
        return;
      }

      EncerrarAlerta();
      NovaOcorrencia();
    }
    #endregion

    #region private void ExibeDadosAlerta()
    private void ExibeDadosAlerta()
    {
      if (grdAlertas.SelectedRows.Count != 0 && grdAlertas.SelectedRows[0].Index != -1)
      {
        Tab = grdAlertas.GetItem<ALT_ALERTAS>();

        txtAlerta.Text = Tab.ALT_DATA.ToString("dd/MM/yyyy") + " - " + Tab.ALT_MENSAGEM;
        txtEmpresa.Text = Tab.EMP_NOME;
        txtColaborador.Text = Tab.CLB_NOME;
        txtDataNascimento.Text = Tab.CLB_DTNASC.ToString("dd/MM/yyyy");
        txtOcorrencia.Text = Tab.OCR_DESCRICAO;
        btnEncerrarAlerta.Enabled = true;
        btnNovaOcorrencia.Enabled = true;
        btnEncerrarAlertaNovaOcorrencia.Enabled = true;
      }
      else
      {
        btnEncerrarAlerta.Enabled = false;
        btnNovaOcorrencia.Enabled = false;
        btnEncerrarAlertaNovaOcorrencia.Enabled = false;
      }
    }
    #endregion

    #region Events
    private void frmPendencias_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    
    private void grdAlertas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      ExibeDadosAlerta();
    }

    private void grdAlertas_KeyUp(object sender, KeyEventArgs e)
    {
      ExibeDadosAlerta();
    }
    
    private void btnEncerrarAlerta_Click(object sender, EventArgs e)
    {
      EncerrarAlerta();
      Carregar();
    }
    
    private void btnNovaOcorrencia_Click(object sender, EventArgs e)
    {
      NovaOcorrencia();
      Carregar();
    }

    private void btnEncerrarAlertaNovaOcorrencia_Click(object sender, EventArgs e)
    {
      EncerrarAlertaNovaOcorrencia();
      Carregar();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      List<SqlWebReport.ParamQuery> l = new List<SqlWebReport.ParamQuery>();
      l.Add(new SqlWebReport.ParamQuery(Tab.ALT_CLB_CODIGO, SqlWebReport.FieldType.Int));
      Utilities.ExibeReport(this.ParentForm, "Historico", l);
    }
    #endregion
  }
}
