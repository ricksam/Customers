using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace MagiaTrigo
{
  partial class dsPLN_PLANO_CONTAS
  {
    public string Lastsearch { get; set; }

    #region public PLN_PLANO_CONTAS[] Search(string s)
    public PLN_PLANO_CONTAS[] Search(string s)
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
            SELECT * FROM PLN_PLANO_CONTAS 
            WHERE 
              PLN_TIPO LIKE {0}
              OR PLN_DESCRICAO LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(PLN_PLANO_CONTAS Tab)
    public override LockedField[] GetLockedFields(PLN_PLANO_CONTAS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.PLN_TIPO))
      { LockedFields.Add(new LockedField("PLN_TIPO", " - Informe o Tipo")); }

      if (string.IsNullOrEmpty(Tab.PLN_DESCRICAO))
      { LockedFields.Add(new LockedField("PLN_DESCRICAO", " - Informe a Descrição")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

