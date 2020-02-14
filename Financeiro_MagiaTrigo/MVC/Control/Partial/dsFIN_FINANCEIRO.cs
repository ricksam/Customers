using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace MagiaTrigo
{
  partial class dsFIN_FINANCEIRO
  {
    public string Lastsearch { get; set; }

    #region public FIN_FINANCEIRO[] Search(string s)
    public FIN_FINANCEIRO[] Search(string s)
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
            SELECT * FROM FIN_FINANCEIRO
            INNER JOIN PLN_PLANO_CONTAS ON PLN_CODIGO = FIN_PLN_CODIGO
            LEFT OUTER JOIN CON_CONTATOS ON CON_CODIGO = FIN_CON_CODIGO 
            WHERE 
              PLN_DESCRICAO LIKE {0}
              OR CON_NOME LIKE {0}
              OR FIN_DOCUMENTO LIKE {0}
              OR FIN_DESCRICAO LIKE {0}
              OR FIN_EMISSAO LIKE {0}
              OR FIN_VENCIMENTO LIKE {0}
              OR FIN_DTPGTO LIKE {0}
              OR FIN_VALOR LIKE {0}
              OR FIN_DTPGTO IS NULL
           ", nr_res);
    }
    #endregion

    public FIN_FINANCEIRO[] GetList_FromAberto() 
    {
      return GetList(
        @"SELECT * FROM FIN_FINANCEIRO
            INNER JOIN PLN_PLANO_CONTAS ON PLN_CODIGO = FIN_PLN_CODIGO 
            LEFT OUTER JOIN CON_CONTATOS ON CON_CODIGO = FIN_CON_CODIGO
            WHERE               
              FIN_DTPGTO IS NULL
          ORDER BY FIN_VENCIMENTO", 200
        );
    }

    public FIN_FINANCEIRO[] GetList_FromBaixado()
    {
      return GetList(
             @"
              SELECT * FROM FIN_FINANCEIRO
              INNER JOIN PLN_PLANO_CONTAS ON PLN_CODIGO = FIN_PLN_CODIGO 
              LEFT OUTER JOIN CON_CONTATOS ON CON_CODIGO = FIN_CON_CODIGO
              WHERE 
                FIN_DTPGTO IS NOT NULL
              ORDER BY FIN_VENCIMENTO", 200
             );
    }

    #region public override LockedField[] GetLockedFields(FIN_FINANCEIRO Tab)
    public override LockedField[] GetLockedFields(FIN_FINANCEIRO Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.FIN_PLN_CODIGO == 0)
      { LockedFields.Add(new LockedField("FIN_PLN_CODIGO", " - Informe o Plano de Contas")); }

      //if (string.IsNullOrEmpty(Tab.FIN_DOCUMENTO))
      //{ LockedFields.Add(new LockedField("FIN_DOCUMENTO", " - Informe o campo FIN_DOCUMENTO")); }

      //if (string.IsNullOrEmpty(Tab.FIN_DESCRICAO))
      //{ LockedFields.Add(new LockedField("FIN_DESCRICAO", " - Informe o campo FIN_DESCRICAO")); }

      //if (Tab.FIN_EMISSAO == DateTime.MinValue)
      //{ LockedFields.Add(new LockedField("FIN_EMISSAO", " - Informe o campo FIN_EMISSAO")); }

      //if (Tab.FIN_VENCIMENTO == DateTime.MinValue)
      //{ LockedFields.Add(new LockedField("FIN_VENCIMENTO", " - Informe o campo FIN_VENCIMENTO")); }

      //if (Tab.FIN_DTPGTO == DateTime.MinValue)
      //{ LockedFields.Add(new LockedField("FIN_DTPGTO", " - Informe o campo FIN_DTPGTO")); }

      if (Tab.FIN_VALOR == 0)
      { LockedFields.Add(new LockedField("FIN_VALOR", " - Informe o Valor")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

