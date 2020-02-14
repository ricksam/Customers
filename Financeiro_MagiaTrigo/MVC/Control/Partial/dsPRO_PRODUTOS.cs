using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace MagiaTrigo
{
  partial class dsPRO_PRODUTOS
  {
    public string Lastsearch { get; set; }

    #region public PRO_PRODUTOS[] Search(string s)
    public PRO_PRODUTOS[] Search(string s)
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
            SELECT * FROM PRO_PRODUTOS 
            WHERE 
              PRO_DESCRICAO LIKE {0}
              OR PRO_QTDE LIKE {0}
              OR PRO_UNIDADE LIKE {0}
              OR PRO_CUSTO LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(PRO_PRODUTOS Tab)
    public override LockedField[] GetLockedFields(PRO_PRODUTOS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.PRO_DESCRICAO))
      { LockedFields.Add(new LockedField("PRO_DESCRICAO", " - Informe a Descrição do Produto")); }

      //if (Tab.PRO_QTDE == 0)
      //{ LockedFields.Add(new LockedField("PRO_QTDE", " - Informe o campo PRO_QTDE")); }

      //if (string.IsNullOrEmpty(Tab.PRO_UNIDADE))
      //{ LockedFields.Add(new LockedField("PRO_UNIDADE", " - Informe o campo PRO_UNIDADE")); }

      //if (Tab.PRO_CUSTO == 0)
      //{ LockedFields.Add(new LockedField("PRO_CUSTO", " - Informe o campo PRO_CUSTO")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

