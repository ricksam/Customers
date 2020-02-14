using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsALT_ALERTAS
  {
    public string Lastsearch { get; set; }

    #region public ALT_ALERTAS[] Search(string s)
    public ALT_ALERTAS[] Search(string s)
    {
      int nr_res = 5;

      if (s == Lastsearch)
      { nr_res = 100; }
      else
      { Lastsearch = s; }

      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");
      return GetList(
          @"
            SELECT * FROM ALT_ALERTAS 
            WHERE 
              ALT_EMP_CODIGO LIKE {0}
              OR ALT_CLB_CODIGO LIKE {0}
              OR ALT_HTR_CODIGO LIKE {0}
              OR ALT_OCR_CODIGO LIKE {0}
              OR ALT_DATA LIKE {0}
              OR ALT_MENSAGEM LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(ALT_ALERTAS Tab)
    public override LockedField[] GetLockedFields(ALT_ALERTAS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      //if (Tab.ALT_EMP_CODIGO == 0)
      //{ LockedFields.Add(new LockedField("ALT_EMP_CODIGO", " - Informe o campo ALT_EMP_CODIGO")); }

      //if (Tab.ALT_CLB_CODIGO == 0)
      //{ LockedFields.Add(new LockedField("ALT_CLB_CODIGO", " - Informe o campo ALT_CLB_CODIGO")); }

      //if (Tab.ALT_HTR_CODIGO == 0)
      //{ LockedFields.Add(new LockedField("ALT_HTR_CODIGO", " - Informe o campo ALT_HTR_CODIGO")); }

      //if (Tab.ALT_OCR_CODIGO == 0)
      //{ LockedFields.Add(new LockedField("ALT_OCR_CODIGO", " - Informe o campo ALT_OCR_CODIGO")); }

      if (Tab.ALT_DATA == DateTime.MinValue)
      { LockedFields.Add(new LockedField("ALT_DATA", " - Informe o campo data")); }

      if (string.IsNullOrEmpty(Tab.ALT_MENSAGEM))
      { LockedFields.Add(new LockedField("ALT_MENSAGEM", " - Informe o campo mensagem")); }

      return LockedFields.ToArray();
    }
    #endregion

    #region public ALT_ALERTAS[] GetList_FrmAtivos()
    public ALT_ALERTAS[] GetList_FrmAtivos()
    {
      return GetList(
          @"
          SELECT 
            ALT_ALERTAS.*, 
            EMP_EMPRESA.EMP_NOME,
            CLB_COLABORADOR.CLB_NOME,
            CLB_COLABORADOR.CLB_DTNASC,
            OCR_OCORRENCIA.OCR_DESCRICAO 
          FROM ALT_ALERTAS 
          INNER JOIN EMP_EMPRESA ON EMP_CODIGO = ALT_EMP_CODIGO
          INNER JOIN CLB_COLABORADOR ON CLB_CODIGO = ALT_CLB_CODIGO
          LEFT OUTER JOIN OCR_OCORRENCIA ON OCR_CODIGO = ALT_OCR_CODIGO 
          WHERE ALT_INATIVO = 0 OR ALT_INATIVO IS NULL
          ORDER BY ALT_DATA_FINAL, ALT_DATA, ALT_CODIGO", 0);
    }
    #endregion

    #region public ALT_ALERTAS[] GetAlertas_Hoje(DateTime dt)
    public ALT_ALERTAS[] GetAlertas_Hoje(DateTime dt)
    {
      cnn.QueryParam.Add(dt, lib.Database.Drivers.enmFieldType.Date);
      return GetList(
          @"
          SELECT 
            ALT_ALERTAS.*, 
            EMP_EMPRESA.EMP_NOME,
            CLB_COLABORADOR.CLB_NOME,
            OCR_OCORRENCIA.OCR_DESCRICAO 
          FROM ALT_ALERTAS 
          INNER JOIN EMP_EMPRESA ON EMP_CODIGO = ALT_EMP_CODIGO
          INNER JOIN CLB_COLABORADOR ON CLB_CODIGO = ALT_CLB_CODIGO
          LEFT OUTER JOIN OCR_OCORRENCIA ON OCR_CODIGO = ALT_OCR_CODIGO 
          WHERE (ALT_INATIVO = 0 OR ALT_INATIVO IS NULL) AND (ALT_DATA = {0} OR ALT_DATA_FINAL = {0})", 0);
    }
    #endregion

    #region public HTR_HISTORICO[] GetList_FrmEmpClb(int HTR_EMP_CODIGO,int HTR_CLB_CODIGO)
    public ALT_ALERTAS[] GetList_FrmEmpClb(int ALT_CLB_CODIGO)
    {
      cnn.QueryParam.Add(ALT_CLB_CODIGO);
      return GetList(
          @"
          SELECT 
            ALT_ALERTAS.*,
            OCR_OCORRENCIA.OCR_DESCRICAO
          FROM ALT_ALERTAS 
          LEFT OUTER JOIN OCR_OCORRENCIA ON OCR_CODIGO = ALT_OCR_CODIGO 
          WHERE (ALT_INATIVO = 0 OR ALT_INATIVO IS NULL) AND ALT_CLB_CODIGO = {0}
          ORDER BY ALT_DATA_FINAL, ALT_DATA, ALT_CODIGO", 0);
    }
    #endregion

    #region public bool Remove_FromOCR(int ALT_OCR_CODIGO)
    public bool Remove_FromOCR(int ALT_CLB_CODIGO, int ALT_OCR_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "ALT_ALERTAS";
      return this.cnn.Exec(this.sb.getDelete(
        string.Format(
        "where ALT_CLB_CODIGO = {0} AND ALT_OCR_CODIGO = {1}", 
        ALT_CLB_CODIGO, ALT_OCR_CODIGO)));
    }
    #endregion
  }
}

