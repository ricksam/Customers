using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace MagiaTrigo
{
  partial class dsNOT_NOTA
  {
    public string Lastsearch { get; set; }

    #region public NOT_NOTA[] Search(string s)
    public NOT_NOTA[] Search(string s)
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
            SELECT * FROM NOT_NOTA 
            WHERE 
              NOT_OPR_CODIGO LIKE {0}
              OR NOT_DOCUMENTO LIKE {0}
              OR NOT_ENTRADA LIKE {0}
              OR NOT_EMISSAO LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(NOT_NOTA Tab)
    public override LockedField[] GetLockedFields(NOT_NOTA Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.NOT_OPR_CODIGO == 0)
      { LockedFields.Add(new LockedField("NOT_OPR_CODIGO", " - Informe a Operacao")); }

      //if (Tab.NOT_DOCUMENTO == 0)
      //{ LockedFields.Add(new LockedField("NOT_DOCUMENTO", " - Informe o campo NOT_DOCUMENTO")); }

      //if (Tab.NOT_ENTRADA == DateTime.MinValue)
      //{ LockedFields.Add(new LockedField("NOT_ENTRADA", " - Informe o campo NOT_ENTRADA")); }

      //if (Tab.NOT_EMISSAO == DateTime.MinValue)
      //{ LockedFields.Add(new LockedField("NOT_EMISSAO", " - Informe o campo NOT_EMISSAO")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

