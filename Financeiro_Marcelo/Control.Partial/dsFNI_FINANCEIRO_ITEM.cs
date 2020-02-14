using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Financeiro_Marcelo
{
  partial class dsFNI_FINANCEIRO_ITEM
  {
    public string Lastsearch { get; set; }

    #region public FNI_FINANCEIRO_ITEM[] Search(string s)
    public FNI_FINANCEIRO_ITEM[] Search(string s)
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
            SELECT * FROM FNI_FINANCEIRO_ITEM 
            WHERE 
              FNI_FIN_CODIGO LIKE {0}
              OR FNI_DESCRICAO LIKE {0}
              OR FNI_QTDE LIKE {0}
              OR FNI_VALOR_TOTAL LIKE {0}
              OR FNI_VALOR_UNITARIO LIKE {0}
              OR FNI_EXPRESSAO LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public FNI_FINANCEIRO_ITEM[] Get_FromDescricao(string s)
    public string[] GetListName_FromDescricao(string s)
    {
      try
      {
        this.cnn.QueryParam.Clear();
        this.cnn.QueryParam.Add("%" + s + "%");
        System.Data.DataTable dt = cnn.GetDataTable(
            @"SELECT FNI_DESCRICAO FROM FNI_FINANCEIRO_ITEM 
            WHERE 
              FNI_DESCRICAO LIKE {0}
            GROUP BY FNI_DESCRICAO");
        string[] arr = new string[dt.Rows.Count];
        for (int i = 0; i < dt.Rows.Count; i++)
        { arr[i] = dt.Rows[i]["FNI_DESCRICAO"].ToString(); }
        return arr;
      }
      catch { return new string[] { }; }
    }
    #endregion

    public string[] GetDescricaoList() 
    {
      System.Data.DataTable dt = cnn.GetDataTable("SELECT FNI_DESCRICAO FROM FNI_FINANCEIRO_ITEM GROUP BY FNI_DESCRICAO ORDER BY FNI_DESCRICAO");
      string[] list = new string[dt.Rows.Count];
      for (int i = 0; i < dt.Rows.Count; i++)
      { list[i] = dt.Rows[i][0].ToString(); }
      return list;
    }

    public void CorrigirItem(string Old, string New) 
    {      
      cnn.QueryParam.Add(New);
      cnn.QueryParam.Add(Old);
      cnn.Exec("UPDATE FNI_FINANCEIRO_ITEM SET FNI_DESCRICAO = {0} WHERE FNI_DESCRICAO = {1}");
    }

    #region public FNI_FINANCEIRO_ITEM[] GetList_FromFIN(int FNI_FIN_CODIGO)
    public FNI_FINANCEIRO_ITEM[] GetList_FromFIN(int FNI_FIN_CODIGO) 
    {
      cnn.QueryParam.Add(FNI_FIN_CODIGO);
      return GetList("SELECT * FROM FNI_FINANCEIRO_ITEM WHERE FNI_FIN_CODIGO = {0}", 0);
    }
    #endregion

    #region public decimal CalculaValorUnitario(decimal Total, decimal Qtde)
    public decimal CalculaValorUnitario(decimal Total, decimal Qtde) 
    {
      if (Qtde != 0)
      { return Total / Qtde; }
      else
      { return 0; }
    }
    #endregion

    #region public override LockedField[] GetLockedFields(FNI_FINANCEIRO_ITEM Tab)
    public override LockedField[] GetLockedFields(FNI_FINANCEIRO_ITEM Tab)
    {
      Tab.FNI_VALOR_UNITARIO = CalculaValorUnitario(Tab.FNI_VALOR_TOTAL, Tab.FNI_QTDE);

      List<LockedField> LockedFields = new List<LockedField>();
            
      if (string.IsNullOrEmpty(Tab.FNI_DESCRICAO))
      { LockedFields.Add(new LockedField("FNI_DESCRICAO", " - Informe a Descrição")); }

      if (Tab.FNI_QTDE == 0)
      { LockedFields.Add(new LockedField("FNI_QTDE", " - Informe a Quantidade")); }

      if (Tab.FNI_VALOR_TOTAL == 0)
      { LockedFields.Add(new LockedField("FNI_VALOR_TOTAL", " - Informe o Total")); }
            
      return LockedFields.ToArray();
    }
    #endregion
  }
}

