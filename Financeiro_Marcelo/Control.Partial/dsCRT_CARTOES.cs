using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Financeiro_Marcelo
{
  partial class dsCRT_CARTOES
  {
    public string Lastsearch { get; set; }

    #region public CRT_CARTOES[] Search(string s)
    public CRT_CARTOES[] Search(string s)
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
            SELECT * FROM CRT_CARTOES
            INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = CRT_EMP_CODIGO 
            WHERE 
              EMP_DESCRICAO LIKE {0}
              OR CRT_DESCRICAO LIKE {0}
              OR CRT_NRDIAS LIKE {0}
              OR CRT_VENCIMENTOS LIKE {0}
              OR CRT_TAXA LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public CRT_CARTOES[] GetList_FromEmpresa(int CRT_EMP_CODIGO)
    public CRT_CARTOES[] GetList_FromEmpresa(int CRT_EMP_CODIGO)
    {
      cnn.QueryParam.Clear();
      cnn.QueryParam.Add(CRT_EMP_CODIGO);
      return GetList(
        @"  SELECT * FROM CRT_CARTOES
            INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = CRT_EMP_CODIGO 
            WHERE 
              CRT_EMP_CODIGO= {0}              
           ", 0
        );
    }
    #endregion

    #region public override LockedField[] GetLockedFields(CRT_CARTOES Tab)
    public override LockedField[] GetLockedFields(CRT_CARTOES Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.CRT_EMP_CODIGO == 0)
      { LockedFields.Add(new LockedField("CRT_EMP_CODIGO", " - Informe o campo empresa")); }

      if (string.IsNullOrEmpty(Tab.CRT_DESCRICAO))
      { LockedFields.Add(new LockedField("CRT_DESCRICAO", " - Informe o campo descrição")); }

      if (Tab.CRT_NRDIAS == 0 && string.IsNullOrEmpty(Tab.CRT_VENCIMENTOS))
      { LockedFields.Add(new LockedField("CRT_NRDIAS", " - Informe um dos campos referente ao vencimento")); }
      
      if (Tab.CRT_TAXA == 0)
      { LockedFields.Add(new LockedField("CRT_TAXA", " - Informe o campo taxa")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

