using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace MagiaTrigo
{
  partial class dsCON_CONTATOS
  {
    public string Lastsearch { get; set; }

    #region public CON_CONTATOS[] Search(string s)
    public CON_CONTATOS[] Search(string s)
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
            SELECT * FROM CON_CONTATOS 
            WHERE 
              CON_NOME LIKE {0}
              OR CON_TEL_RESIDENCIAL LIKE {0}
              OR CON_TEL_CELULAR LIKE {0}
              OR CON_TEL_COMERCIAL LIKE {0}
              OR CON_TEL_FAX LIKE {0}
              OR CON_LOGRADOURO LIKE {0}
              OR CON_NUMERO LIKE {0}
              OR CON_BAIRRO LIKE {0}
              OR CON_CIDADE LIKE {0}
              OR CON_CEP LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(CON_CONTATOS Tab)
    public override LockedField[] GetLockedFields(CON_CONTATOS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.CON_NOME))
      { LockedFields.Add(new LockedField("CON_NOME", " - Informe o Nome")); }      

      return LockedFields.ToArray();
    }
    #endregion
  }
}

