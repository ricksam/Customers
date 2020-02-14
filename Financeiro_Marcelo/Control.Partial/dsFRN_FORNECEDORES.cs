using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsFRN_FORNECEDORES
  {
    public FRN_FORNECEDORES[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");
      return GetList(
        @"SELECT * FROM FRN_FORNECEDORES 
          WHERE FRN_NOME LIKE {0}
          ORDER BY FRN_NOME", 200);
    }

    #region private bool CNPJ_Exists(string CNPJ, int FRN_CODIGO)
    private bool CNPJ_Exists(string CNPJ, int FRN_CODIGO)
    {
      return Get(
        string.Format(
          "SELECT * FROM FRN_FORNECEDORES WHERE FRN_CNPJ = {0} AND FRN_CODIGO <> {1}",
          cnn.dbu.Quoted(CNPJ),
          FRN_CODIGO)
        ).FRN_CODIGO != 0;
    }
    #endregion

    #region private string GetNumeros(string CNPJ)
    private string GetNumeros(string CNPJ) 
    {
      string s = "";
      for (int i = 0; i < CNPJ.Length; i++)
      {
        if (char.IsNumber(CNPJ[i]))
        { s += CNPJ[i].ToString(); }
      }
      return s;
    }
    #endregion

    public override lib.Class.LockedField[] GetLockedFields(FRN_FORNECEDORES Tab)
    {
      List<lib.Class.LockedField> lst = new List<lib.Class.LockedField>();

      string nCNPJ = GetNumeros(Tab.FRN_CNPJ);
      if (!string.IsNullOrEmpty(nCNPJ) && CNPJ_Exists(Tab.FRN_CNPJ, Tab.FRN_CODIGO))
      { lst.Add(new lib.Class.LockedField("FRN_CNPJ", " - Já existe outro fornecedor com o mesmo CNPJ")); }

      return lst.ToArray();
    }
  }
}
