using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsEMP_EMPRESA
  {
    public string Lastsearch { get; set; }

    #region public EMP_EMPRESA[] Search(string s)
    public EMP_EMPRESA[] Search(string s)
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
            SELECT * FROM EMP_EMPRESA 
            WHERE 
              EMP_NOME LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(EMP_EMPRESA Tab)
    public override LockedField[] GetLockedFields(EMP_EMPRESA Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.EMP_NOME))
      { LockedFields.Add(new LockedField("EMP_NOME", " - Informe o nome da empresa")); }

      return LockedFields.ToArray();
    }
    #endregion

    #region public EMP_EMPRESA[] GetList_FromAtivas()
    public EMP_EMPRESA[] GetList_FromAtivas() 
    {
      return GetList("SELECT * FROM EMP_EMPRESA WHERE EMP_INATIVO = 0 OR EMP_INATIVO IS NULL", 0);
    }
    #endregion
  }
}

