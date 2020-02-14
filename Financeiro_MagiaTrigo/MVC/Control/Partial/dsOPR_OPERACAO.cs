using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace MagiaTrigo
{
  partial class dsOPR_OPERACAO
  {
    public string Lastsearch { get; set; }

    #region public OPR_OPERACAO[] Search(string s)
    public OPR_OPERACAO[] Search(string s)
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
            SELECT * FROM OPR_OPERACAO
            LEFT OUTER JOIN PLN_PLANO_CONTAS ON PLN_CODIGO = OPR_PLN_CODIGO 
            WHERE 
              OPR_DESCRICAO LIKE {0}
              OR OPR_PLN_CODIGO LIKE {0}
              OR OPR_ADDESTOQUE LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(OPR_OPERACAO Tab)
    public override LockedField[] GetLockedFields(OPR_OPERACAO Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.OPR_DESCRICAO))
      { LockedFields.Add(new LockedField("OPR_DESCRICAO", " - Informe a Descrição")); }

      //if (Tab.OPR_PLN_CODIGO == 0)
      //{ LockedFields.Add(new LockedField("OPR_PLN_CODIGO", " - Informe o Plano de Contas")); }

      //if (Tab.OPR_ADDESTOQUE == 0)
      //{ LockedFields.Add(new LockedField("OPR_ADDESTOQUE", " - Informe o campo OPR_ADDESTOQUE")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

