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

namespace Folha_Marcelo
{
  public partial class frmOCR_OCORRENCIA : lib.Visual.Models.frmBaseCadastro
  {
    public frmOCR_OCORRENCIA()
    {
      InitializeComponent();
      ds = new dsOCR_OCORRENCIA(Utilities.Cnn);
    }

    OCR_OCORRENCIA Tab { get; set; }
    dsOCR_OCORRENCIA ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      txtOCR_DESCRICAO.Text = Tab.OCR_DESCRICAO;
      txtOCR_DIAS_ALERTA.AsInt = Tab.OCR_DIAS_ALERTA;
      txtOCR_DIAS_FINAL_ALERTA.AsInt = Tab.OCR_DIAS_FINAL_ALERTA;
      txtOCR_MENSAGEM_ALERTA.Text = Tab.OCR_MENSAGEM_ALERTA;
      txtOCR_DESCRICAO.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new OCR_OCORRENCIA();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<OCR_OCORRENCIA>();
      Carregar();
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.OCR_CODIGO)))
      { ds.Remove(Tab.OCR_CODIGO); }
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

        if (lf[0].Field == "OCR_DESCRICAO")
        { txtOCR_DESCRICAO.Select(); }
        if (lf[0].Field == "OCR_DIAS_ALERTA")
        { txtOCR_DIAS_ALERTA.Select(); }
        if (lf[0].Field == "OCR_MENSAGEM_ALERTA")
        { txtOCR_MENSAGEM_ALERTA.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.OCR_DESCRICAO = txtOCR_DESCRICAO.Text;
      Tab.OCR_DIAS_ALERTA = txtOCR_DIAS_ALERTA.AsInt;
      Tab.OCR_DIAS_FINAL_ALERTA = txtOCR_DIAS_FINAL_ALERTA.AsInt;
      Tab.OCR_MENSAGEM_ALERTA = txtOCR_MENSAGEM_ALERTA.Text;
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
      Grid.AddColumn(new FieldColumn("Descrição", "OCR_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Mensagem", "OCR_MENSAGEM_ALERTA", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("1º Alerta", "OCR_DIAS_ALERTA", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Alerta Final", "OCR_DIAS_FINAL_ALERTA", enmFieldType.Int));
      Grid.AddItems(ds.Search(TextSearch));
    }
    #endregion
  }
}

