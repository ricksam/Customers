using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsLCD_LANCAMENTO_DIARIO
  {
    public string Lastsearch { get; set; }

    #region public LCD_LANCAMENTO_DIARIO[] Search(string s)
    public LCD_LANCAMENTO_DIARIO[] Search(string s)
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
            SELECT * FROM LCD_LANCAMENTO_DIARIO 
            WHERE 
              LCD_OPR_CODIGO LIKE {0}
              OR LCD_CLB_CODIGO LIKE {0}
              OR LCD_EMP_CODIGO LIKE {0}
              OR LCD_DESCRICAO LIKE {0}
              OR LCD_DATA LIKE {0}
              OR LCD_REFERENCIA LIKE {0}
              OR LCD_VALOR LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public LCD_LANCAMENTO_DIARIO[] GetList_FromOperacao(int Mes, int Ano, int LCD_CLB_CODIGO, int LCD_OPR_CODIGO)
    public LCD_LANCAMENTO_DIARIO[] GetList_FromOperacao(int Mes, int Ano, int LCD_CLB_CODIGO, int LCD_OPR_CODIGO)
    {
      cnn.QueryParam.Add(Mes);
      cnn.QueryParam.Add(Ano);
      cnn.QueryParam.Add(LCD_CLB_CODIGO);
      cnn.QueryParam.Add(LCD_OPR_CODIGO);

      return GetList(
        @"SELECT * FROM LCD_LANCAMENTO_DIARIO 
          INNER JOIN OPR_OPERACAO ON OPR_CODIGO = LCD_OPR_CODIGO
          WHERE LCD_MES = {0} AND LCD_ANO = {1} AND LCD_CLB_CODIGO = {2} AND LCD_OPR_CODIGO = {3}", 0);
    }
    #endregion

    #region public LCD_LANCAMENTO_DIARIO[] GetList_FromHolerite(int Mes, int Ano, int LCD_CLB_CODIGO)
    public LCD_LANCAMENTO_DIARIO[] GetList_FromHolerite(int Mes, int Ano, int LCD_CLB_CODIGO) 
    {
      cnn.QueryParam.Add(Mes);
      cnn.QueryParam.Add(Ano);
      cnn.QueryParam.Add(LCD_CLB_CODIGO);

      return GetList(
        @"SELECT * FROM LCD_LANCAMENTO_DIARIO 
          INNER JOIN OPR_OPERACAO ON OPR_CODIGO = LCD_OPR_CODIGO
          WHERE LCD_MES = {0} AND LCD_ANO = {1} AND LCD_CLB_CODIGO = {2} ORDER BY LCD_DIA", 0);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(LCD_LANCAMENTO_DIARIO Tab)
    public override LockedField[] GetLockedFields(LCD_LANCAMENTO_DIARIO Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.LCD_OPR_CODIGO == 0)
      { LockedFields.Add(new LockedField("LCD_OPR_CODIGO", " - Informe a Operação")); }

      if (Tab.LCD_CLB_CODIGO == 0)
      { LockedFields.Add(new LockedField("LCD_CLB_CODIGO", " - Informe o Colaborador")); }

      if (Tab.LCD_EMP_CODIGO == 0)
      { LockedFields.Add(new LockedField("LCD_EMP_CODIGO", " - Informe a Loja")); }
            
      if (Tab.LCD_DATA == DateTime.MinValue)
      { LockedFields.Add(new LockedField("LCD_DATA", " - Informe a data do lançamento")); }
            
      return LockedFields.ToArray();
    }
    #endregion
  }
}

