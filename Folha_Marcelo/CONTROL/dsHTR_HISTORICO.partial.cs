using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsHTR_HISTORICO
  {
    public string Lastsearch { get; set; }

    #region public HTR_HISTORICO[] Search(string s)
    public HTR_HISTORICO[] Search(string s)
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
            SELECT * FROM HTR_HISTORICO 
            WHERE 
              HTR_EMP_CODIGO LIKE {0}
              OR HTR_CLB_CODIGO LIKE {0}
              OR HTR_OCR_CODIGO LIKE {0}
              OR HTR_DATA LIKE {0}
              OR HTR_OBSERVACAO LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(HTR_HISTORICO Tab)
    public override LockedField[] GetLockedFields(HTR_HISTORICO Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      //if (Tab.HTR_EMP_CODIGO == 0)
      //{ LockedFields.Add(new LockedField("HTR_EMP_CODIGO", " - Informe o campo HTR_EMP_CODIGO")); }

      //if (Tab.HTR_CLB_CODIGO == 0)
      //{ LockedFields.Add(new LockedField("HTR_CLB_CODIGO", " - Informe o campo HTR_CLB_CODIGO")); }

      if (Tab.HTR_OCR_CODIGO == 0)
      { LockedFields.Add(new LockedField("HTR_OCR_CODIGO", " - Informe o campo ocorrência")); }

      if (Tab.HTR_DATA == DateTime.MinValue)
      { LockedFields.Add(new LockedField("HTR_DATA", " - Informe o campo data")); }

      //if (string.IsNullOrEmpty(Tab.HTR_OBSERVACAO))
      //{ LockedFields.Add(new LockedField("HTR_OBSERVACAO", " - Informe o campo HTR_OBSERVACAO")); }

      return LockedFields.ToArray();
    }
    #endregion

    #region public HTR_HISTORICO[] GetList_FrmEmpClb(int HTR_EMP_CODIGO,int HTR_CLB_CODIGO)
    public HTR_HISTORICO[] GetList_FrmEmpClb(int HTR_CLB_CODIGO) 
    {
      cnn.QueryParam.Add(HTR_CLB_CODIGO);
      return GetList(
        @"
          SELECT 
            HTR_HISTORICO.*,
            OCR_OCORRENCIA.OCR_DESCRICAO,
            EMP_EMPRESA.EMP_NOME
          FROM HTR_HISTORICO 
          INNER JOIN OCR_OCORRENCIA ON OCR_CODIGO = HTR_OCR_CODIGO
          INNER JOIN EMP_EMPRESA ON EMP_CODIGO = HTR_EMP_CODIGO
          WHERE HTR_CLB_CODIGO = {0}
          ORDER BY HTR_DATA, HTR_CODIGO", 0);
    }
    #endregion
  }
}

