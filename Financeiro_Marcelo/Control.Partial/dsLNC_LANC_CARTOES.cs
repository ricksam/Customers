using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Financeiro_Marcelo
{
  partial class dsLNC_LANC_CARTOES
  {
    public string Lastsearch { get; set; }
    public Conversion cnv = new Conversion();

    #region public LNC_LANC_CARTOES[] Search(string s)
    public LNC_LANC_CARTOES[] Search(string s)
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
            SELECT * FROM LNC_LANC_CARTOES 
            WHERE 
              LNC_CRT_CODIGO LIKE {0}
              OR LNC_EMISSAO LIKE {0}
              OR LNC_VENCIMENTO LIKE {0}
              OR LNC_DATA_PGTO LIKE {0}
              OR LNC_VALOR LIKE {0}
              OR LNC_VALOR_TAXA LIKE {0}
              OR LNC_VALOR_RECEBER LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public LNC_LANC_CARTOES[] GetList_Aberto(int CRT_EMP_CODIGO, DateTime LNC_EMISSAO)
    public LNC_LANC_CARTOES[] GetList(int CRT_EMP_CODIGO, DateTime LNC_EMISSAO)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add(CRT_EMP_CODIGO);
      this.cnn.QueryParam.Add(LNC_EMISSAO, lib.Database.Drivers.enmFieldType.Date);
      return GetList(
          @"
            SELECT * FROM LNC_LANC_CARTOES 
            INNER JOIN CRT_CARTOES ON CRT_CODIGO = LNC_CRT_CODIGO
            WHERE 
              CRT_EMP_CODIGO = {0} AND
              LNC_EMISSAO = {1} 
            ORDER BY LNC_CODIGO
           ", 0);
    }
    #endregion

    #region public LNC_LANC_CARTOES[] GetList_Aberto(int CRT_EMP_CODIGO, DateTime LNC_VENCIMENTO)
    public LNC_LANC_CARTOES[] GetList_Aberto(int CRT_EMP_CODIGO, DateTime LNC_VENCIMENTO)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add(CRT_EMP_CODIGO);
      this.cnn.QueryParam.Add(LNC_VENCIMENTO, lib.Database.Drivers.enmFieldType.Date);
      return GetList(
          @"
            SELECT * FROM LNC_LANC_CARTOES 
            INNER JOIN CRT_CARTOES ON CRT_CODIGO = LNC_CRT_CODIGO
            WHERE 
              CRT_EMP_CODIGO = {0} AND
              LNC_VENCIMENTO <= {1} AND
              LNC_DATA_PGTO IS NULL
            ORDER BY LNC_CODIGO
           ", 0);
    }
    #endregion

    #region public LNC_LANC_CARTOES[] GetList_Pagos(int CRT_EMP_CODIGO, DateTime LNC_DATA_PGTO)
    public LNC_LANC_CARTOES[] GetList_Pagos(int CRT_EMP_CODIGO, DateTime LNC_DATA_PGTO)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add(CRT_EMP_CODIGO);
      this.cnn.QueryParam.Add(LNC_DATA_PGTO, lib.Database.Drivers.enmFieldType.Date);
      return GetList(
          @"
            SELECT * FROM LNC_LANC_CARTOES 
            INNER JOIN CRT_CARTOES ON CRT_CODIGO = LNC_CRT_CODIGO
            WHERE 
              CRT_EMP_CODIGO = {0} AND
              LNC_DATA_PGTO <= {1} AND
              LNC_DATA_PGTO IS NOT NULL
            ORDER BY LNC_DATA_PGTO DESC
           ", 100);
    }
    #endregion

    #region public bool IsDayVencimento(int Dia, string[] Dias)
    public bool IsDayVencimento(int Dia, string[] Dias) 
    {
      for (int i = 0; i < Dias.Length; i++)
      {
        if (Dia == cnv.ToInt(Dias[i]))
        { return true; }
      }
      return false;
    }
    #endregion

    #region public bool IsDayVencimento(DateTime dtVencimento, string Vencimentos)
    public bool IsDayVencimento(DateTime dtVencimento, string Vencimentos)
    {
      if (Vencimentos.IndexOf(',') != -1)
      {
        string[] lstDias = Vencimentos.Split(new char[] { ',' });
        return IsDayVencimento(dtVencimento.Day, lstDias);
      }
      else if (!string.IsNullOrEmpty(Vencimentos))
      {
        int DayTeste = cnv.ToInt(Vencimentos);
        if (DayTeste == 0 || DayTeste > 31)
        { return true; }
        else
        { return dtVencimento.Day == DayTeste; }
      }
      else { return true; }
    }
    #endregion

    #region public void Calcule(LNC_LANC_CARTOES Tab)
    public void Calcule(LNC_LANC_CARTOES Tab) 
    {
      if (Tab.CRT_TAXA == 0)
      { return; }

      Tab.LNC_VALOR_TAXA = Math.Round(Tab.LNC_VALOR * ((decimal)Tab.CRT_TAXA/100M), 2);
      Tab.LNC_VALOR_RECEBER = Tab.LNC_VALOR - Tab.LNC_VALOR_TAXA;

      if (Tab.CRT_NRDIAS != 0)
      {
        Tab.LNC_VENCIMENTO = Tab.LNC_EMISSAO;
        if (Tab.CRT_SEMANA != 0)
        {
          while (Tab.LNC_VENCIMENTO.DayOfWeek != (DayOfWeek)(Tab.CRT_SEMANA - 1))
          { Tab.LNC_VENCIMENTO = Tab.LNC_VENCIMENTO.AddDays(1); }
        }
        Tab.LNC_VENCIMENTO = Tab.LNC_VENCIMENTO.AddDays(Tab.CRT_NRDIAS);         
      }
      else 
      {
        Tab.LNC_VENCIMENTO = Tab.LNC_EMISSAO;
        do
        { Tab.LNC_VENCIMENTO = Tab.LNC_VENCIMENTO.AddDays(1); }
        while (IsDayVencimento(Tab.LNC_VENCIMENTO, Tab.CRT_VENCIMENTOS));
      }

      //Aqui pode ser adicionado tratamento para dias não úteis ou feriados
    }
    #endregion

    #region public override LockedField[] GetLockedFields(LNC_LANC_CARTOES Tab)
    public override LockedField[] GetLockedFields(LNC_LANC_CARTOES Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.LNC_CRT_CODIGO == 0)
      { LockedFields.Add(new LockedField("LNC_CRT_CODIGO", " - Informe o Cartão")); }

      if (Tab.LNC_VALOR == 0)
      { LockedFields.Add(new LockedField("LNC_VALOR", " - Informe o valor")); }

      if (LockedFields.Count == 0)
      { Calcule(Tab); }
            
      if (Tab.LNC_EMISSAO == DateTime.MinValue)
      { LockedFields.Add(new LockedField("LNC_EMISSAO", " - Informe a data de emissão")); }

      if (Tab.LNC_VENCIMENTO == DateTime.MinValue)
      { LockedFields.Add(new LockedField("LNC_VENCIMENTO", " - Informe a data de vencimento")); }
            
      return LockedFields.ToArray();
    }
    #endregion
  }
}

