using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsOCR_OCORRENCIA
  {
    public string Lastsearch { get; set; }

    public OCR_OCORRENCIA[] Search(string s)
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
            SELECT * FROM OCR_OCORRENCIA 
            WHERE 
              OCR_DESCRICAO LIKE {0}
              OR OCR_DIAS_ALERTA LIKE {0}
           ", nr_res);
    }
    
    public override LockedField[] GetLockedFields(OCR_OCORRENCIA Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.OCR_DESCRICAO))
      { LockedFields.Add(new LockedField("OCR_DESCRICAO", " - Informe o campo descrição")); }

      //if (Tab.OCR_DIAS_ALERTA == 0)
      //{ LockedFields.Add(new LockedField("OCR_DIAS_ALERTA", " - Informe a quantidade de dias para exibir um alerta")); }

      return LockedFields.ToArray();
    }

    public OCR_OCORRENCIA Get_FromDescricao(string OCR_DESCRICAO) 
    {
      cnn.QueryParam.Add(OCR_DESCRICAO);
      return Get("SELECT * FROM OCR_OCORRENCIA WHERE OCR_DESCRICAO = {0}");
    }
  }
}

