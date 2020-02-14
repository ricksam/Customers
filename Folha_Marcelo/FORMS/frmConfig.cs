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

namespace Folha_Marcelo.FORMS
{
  public partial class frmConfig : lib.Visual.Models.frmDialog
  {
    public frmConfig()
    {
      InitializeComponent();
      ds = new dsCFG_CONFIG(Utilities.Cnn);
    }

    CFG_CONFIG Tab { get; set; }
    dsCFG_CONFIG ds { get; set; }
    
    private void Carregar()
    {
      Tab = ds.Get();
      txtEmailAlerta.Text = Tab.CFG_EMAIL_ALERTA;
      txtAlertaAviversario.Text = Tab.CFG_ALERTA_ANIVERSARIO;
      txtCFG_CAMPO_REMUNERACAO.Text = Tab.CFG_CAMPO_REMUNERACAO;
      txtCFG_CAMPO_REMUNERACAO_TOTAL.Text = Tab.CFG_CAMPO_REMUNERACAO_TOTAL;
      txtCFG_CAMPO_DESCONTO_TOTAL.Text = Tab.CFG_CAMPO_DESCONTO_TOTAL;
      txtCFG_CAMPO_REMUNERACAO_LIQUIDA.Text = Tab.CFG_CAMPO_REMUNERACAO_LIQUIDA;
      txtCFG_CAMPO_REFERENCIA.Text = Tab.CFG_CAMPO_REFERENCIA;

      if (!string.IsNullOrEmpty(Tab.CFG_OCORRENCIAS_AUTOMATICAS))
      {
        Conversion cnv = new Conversion();
        dsOCR_OCORRENCIA dsOcr = new dsOCR_OCORRENCIA(Utilities.Cnn);
        string[] CodOcorrencias = Tab.CFG_OCORRENCIAS_AUTOMATICAS.Split(new char[] { ',' });
        for (int i = 0; i < CodOcorrencias.Length; i++)
        { txtOcorrencias.Text += (!string.IsNullOrEmpty(txtOcorrencias.Text) ? "," : "") + dsOcr.Get(cnv.ToInt(CodOcorrencias[i])).OCR_DESCRICAO; }
      }

      txtCFG_CAMPO_REMUNERACAO.Select();
    }



    private bool FaltaPreencher()
    {
      LockedField[] lf = ds.GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "CFG_CAMPO_REMUNERACAO")
        { txtCFG_CAMPO_REMUNERACAO.Select(); }
        else if (lf[0].Field == "CFG_CAMPO_REMUNERACAO_TOTAL")
        { txtCFG_CAMPO_REMUNERACAO_TOTAL.Select(); }
        else if (lf[0].Field == "CFG_CAMPO_DESCONTO_TOTAL")
        { txtCFG_CAMPO_DESCONTO_TOTAL.Select(); }
        else if (lf[0].Field == "CFG_CAMPO_REMUNERACAO_LIQUIDA")
        { txtCFG_CAMPO_REMUNERACAO_LIQUIDA.Select(); }
        else if (lf[0].Field == "CFG_CAMPO_REFERENCIA")
        { txtCFG_CAMPO_REFERENCIA.Select(); }
      }

      return lf.Length != 0;
    }



    protected override void OnConfirm()
    {
      Tab.CFG_ALERTA_ANIVERSARIO = txtAlertaAviversario.Text;
      Tab.CFG_EMAIL_ALERTA = txtEmailAlerta.Text;
      Tab.CFG_CAMPO_REMUNERACAO = txtCFG_CAMPO_REMUNERACAO.Text;
      Tab.CFG_CAMPO_REMUNERACAO_TOTAL = txtCFG_CAMPO_REMUNERACAO_TOTAL.Text;
      Tab.CFG_CAMPO_DESCONTO_TOTAL = txtCFG_CAMPO_DESCONTO_TOTAL.Text;
      Tab.CFG_CAMPO_REMUNERACAO_LIQUIDA = txtCFG_CAMPO_REMUNERACAO_LIQUIDA.Text;
      Tab.CFG_CAMPO_REFERENCIA = txtCFG_CAMPO_REFERENCIA.Text;

      dsOCR_OCORRENCIA dsOcr = new dsOCR_OCORRENCIA(Utilities.Cnn);
      string[] Ocorrencias = txtOcorrencias.Text.Split(new char[] { ',' });
      Tab.CFG_OCORRENCIAS_AUTOMATICAS = "";
      for (int i = 0; i < Ocorrencias.Length; i++)
      { Tab.CFG_OCORRENCIAS_AUTOMATICAS += (!string.IsNullOrEmpty(Tab.CFG_OCORRENCIAS_AUTOMATICAS) ? "," : "") + dsOcr.Get_FromDescricao(Ocorrencias[i]).OCR_CODIGO.ToString(); }

      if (!FaltaPreencher())
      {
        ds.Save(Tab);
        base.OnConfirm();
      }
    }

    private void frmConfig_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void Ocorrencias_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Descrição", "OCR_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Mensagem", "OCR_MENSAGEM_ALERTA", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("1º Alerta", "OCR_DIAS_ALERTA", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Alerta Final", "OCR_DIAS_FINAL_ALERTA", enmFieldType.Int));
      Grid.AddItems((new dsOCR_OCORRENCIA(Utilities.Cnn)).Search(TextSearch));
    }

    private void button1_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery f = new lib.Visual.Forms.FormQuery();
      f.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(Ocorrencias_Search);
      if (f.Exec())
      { txtOcorrencias.Text += (!string.IsNullOrEmpty(txtOcorrencias.Text) ? "," : "") + f.Grid.GetField("OCR_DESCRICAO").ToString(); }
    }
  }
}
