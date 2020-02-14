using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsLNC_LANCAMENTO
  {
    public string Lastsearch { get; set; }

    #region public LNC_LANCAMENTO[] Search(string s)
    public LNC_LANCAMENTO[] Search(string s)
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
            SELECT * FROM LNC_LANCAMENTO 
            WHERE 
              LNC_OPR_CODIGO LIKE {0}
              OR LNC_CLB_CODIGO LIKE {0}
              OR LNC_EMP_CODIGO LIKE {0}
              OR LNC_MES LIKE {0}
              OR LNC_ANO LIKE {0}
              OR LNC_REFERENCIA LIKE {0}
              OR LNC_VALOR LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public LNC_LANCAMENTO Get_FromOperacao(int LNC_MES, int LNC_ANO, int LNC_CLB_CODIGO, int LNC_OPR_CODIGO)
    public LNC_LANCAMENTO Get_FromOperacao(int LNC_MES, int LNC_ANO, int LNC_CLB_CODIGO, int LNC_OPR_CODIGO) 
    {
      cnn.QueryParam.Add(LNC_MES);
      cnn.QueryParam.Add(LNC_ANO);
      cnn.QueryParam.Add(LNC_CLB_CODIGO);
      cnn.QueryParam.Add(LNC_OPR_CODIGO);

      return Get(
        @"SELECT * FROM LNC_LANCAMENTO 
          INNER JOIN OPR_OPERACAO ON OPR_CODIGO = LNC_OPR_CODIGO
          WHERE LNC_MES = {0} AND LNC_ANO = {1} AND LNC_CLB_CODIGO = {2} AND LNC_OPR_CODIGO = {3} 
          ORDER BY OPR_TIPO ");
    }
    #endregion

    #region public bool Remove_FromOperacao(int LNC_MES, int LNC_ANO, int LNC_CLB_CODIGO, int LNC_OPR_CODIGO)
    public bool Remove_FromOperacao(int LNC_MES, int LNC_ANO, int LNC_CLB_CODIGO, int LNC_OPR_CODIGO) 
    {
      cnn.QueryParam.Add(LNC_MES);
      cnn.QueryParam.Add(LNC_ANO);
      cnn.QueryParam.Add(LNC_CLB_CODIGO);
      cnn.QueryParam.Add(LNC_OPR_CODIGO);

      return cnn.Exec(
        @"DELETE FROM LNC_LANCAMENTO 
          WHERE LNC_MES = {0} AND LNC_ANO = {1} AND LNC_CLB_CODIGO = {2} AND LNC_OPR_CODIGO = {3}");
    }
    #endregion

    #region public LNC_LANCAMENTO[] GetList_FromHolerite(int LNC_MES, int LNC_ANO, int LNC_CLB_CODIGO)
    public LNC_LANCAMENTO[] GetList_FromHolerite(int LNC_MES, int LNC_ANO, int LNC_CLB_CODIGO) 
    {
      cnn.QueryParam.Add(LNC_MES);
      cnn.QueryParam.Add(LNC_ANO);
      cnn.QueryParam.Add(LNC_CLB_CODIGO);

      return GetList(
        @"SELECT * FROM LNC_LANCAMENTO 
          INNER JOIN OPR_OPERACAO ON OPR_CODIGO = LNC_OPR_CODIGO
          WHERE LNC_MES = {0} AND LNC_ANO = {1} AND LNC_CLB_CODIGO = {2} 
          ORDER BY OPR_TIPO, OPR_NIVEL", 0);

    }
    #endregion

    #region public override LockedField[] GetLockedFields(LNC_LANCAMENTO Tab)
    public override LockedField[] GetLockedFields(LNC_LANCAMENTO Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.LNC_OPR_CODIGO == 0)
      { LockedFields.Add(new LockedField("LNC_OPR_CODIGO", " - Informe o campo LNC_OPR_CODIGO")); }

      if (Tab.LNC_CLB_CODIGO == 0)
      { LockedFields.Add(new LockedField("LNC_CLB_CODIGO", " - Informe o campo LNC_CLB_CODIGO")); }

      if (Tab.LNC_EMP_CODIGO == 0)
      { LockedFields.Add(new LockedField("LNC_EMP_CODIGO", " - Informe o campo LNC_EMP_CODIGO")); }

      if (Tab.LNC_MES == 0)
      { LockedFields.Add(new LockedField("LNC_MES", " - Informe o campo LNC_MES")); }

      if (Tab.LNC_ANO == 0)
      { LockedFields.Add(new LockedField("LNC_ANO", " - Informe o campo LNC_ANO")); }

      if (Tab.LNC_REFERENCIA == 0)
      { LockedFields.Add(new LockedField("LNC_REFERENCIA", " - Informe o campo LNC_REFERENCIA")); }

      if (Tab.LNC_VALOR == 0)
      { LockedFields.Add(new LockedField("LNC_VALOR", " - Informe o campo LNC_VALOR")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

