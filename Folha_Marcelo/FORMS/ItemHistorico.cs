using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folha_Marcelo
{
  public partial class ItemHistorico : lib.Visual.Models.frmEdit
  {
    public ItemHistorico()
    {
      InitializeComponent();
      Tab = new HTR_HISTORICO();
    }

    public HTR_HISTORICO Tab { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      cmbOcorrencias.DisplayMember = "OCR_DESCRICAO";
      cmbOcorrencias.ValueMember = "OCR_CODIGO";
      cmbOcorrencias.DataSource = (new dsOCR_OCORRENCIA(Utilities.Cnn)).GetList();

      if (Tab.HTR_DATA == DateTime.MinValue)
      { dtData.Value = DateTime.Now;  }
      else
      { dtData.Value = Tab.HTR_DATA; }
      cmbOcorrencias.SelectedValue = Tab.HTR_OCR_CODIGO;
      txtObservacao.Text = Tab.HTR_OBSERVACAO;
    }
    #endregion

    #region public bool FaltaPreencher()
    public bool FaltaPreencher()
    {
      lib.Class.LockedField[] lf = (new dsHTR_HISTORICO(Utilities.Cnn)).GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        lib.Visual.Msg.Warning("Verifique os campos abaixo:\n" + xMsg);
      }
      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbOcorrencias.SelectedIndex == -1) 
      {
        lib.Visual.Msg.Warning("Informe a ocorrência");
        return;
      }
      Tab.HTR_DATA = dtData.Value;
      Tab.HTR_OCR_CODIGO = (int)cmbOcorrencias.SelectedValue;
      Tab.HTR_OBSERVACAO = txtObservacao.Text;
      Tab.OCR_DESCRICAO = cmbOcorrencias.Text;

      if (!FaltaPreencher())
      { base.OnConfirm(); }
    }
    #endregion

    #region Events
    private void ItemHistorico_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    #endregion
  }
}
