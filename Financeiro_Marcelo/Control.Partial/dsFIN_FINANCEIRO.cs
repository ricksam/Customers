using System;
using System.Collections.Generic;
using System.Text;
using lib.Class;

namespace Financeiro_Marcelo
{
  partial class dsFIN_FINANCEIRO
  {
    #region public FIN_FINANCEIRO[] GetList_Receitas(int FIN_EMP_CODIGO, int FIN_FRM_CODIGO, DateTime FIN_DATA)
    public FIN_FINANCEIRO[] GetList_Receitas(int FIN_EMP_CODIGO, int FIN_FRM_CODIGO, DateTime FIN_DATA)
    {
      cnn.QueryParam.Clear();
      cnn.QueryParam.Add(FIN_EMP_CODIGO);
      cnn.QueryParam.Add(FIN_FRM_CODIGO);
      cnn.QueryParam.Add(FIN_DATA, lib.Database.Drivers.enmFieldType.Date);
      return GetList(
        @" select * from FIN_FINANCEIRO 
         inner join CAT_CATEGORIAS ON CAT_CODIGO = FIN_CAT_CODIGO and CAT_TIPO = 'R' 
         inner join PLN_PLANOCONTAS ON PLN_CODIGO = FIN_PLN_CODIGO 
         left outer join CPG_CONTAS_PAGAR ON CPG_FIN_CODIGO = FIN_CODIGO
         left outer join FRN_FORNECEDORES ON CPG_FRN_CODIGO = FRN_CODIGO  
         where FIN_EMP_CODIGO = {0} and FIN_FRM_CODIGO = {1} and FIN_DATA = {2} 
         ORDER BY FIN_CODIGO "
      , 0);
    }
    #endregion

    #region public FIN_FINANCEIRO[] GetList_Despesas(int FIN_EMP_CODIGO, int FIN_FRM_CODIGO, DateTime FIN_DATA)
    public FIN_FINANCEIRO[] GetList_Despesas(int FIN_EMP_CODIGO, int FIN_FRM_CODIGO, DateTime FIN_DATA)
    {
      cnn.QueryParam.Clear();
      cnn.QueryParam.Add(FIN_EMP_CODIGO);
      cnn.QueryParam.Add(FIN_FRM_CODIGO);
      cnn.QueryParam.Add(FIN_DATA, lib.Database.Drivers.enmFieldType.Date);
      return GetList(
        @" select * from FIN_FINANCEIRO 
         inner join CAT_CATEGORIAS ON CAT_CODIGO = FIN_CAT_CODIGO and CAT_TIPO = 'D' 
         inner join PLN_PLANOCONTAS ON PLN_CODIGO = FIN_PLN_CODIGO 
         left outer join CPG_CONTAS_PAGAR ON CPG_FIN_CODIGO = FIN_CODIGO
         left outer join FRN_FORNECEDORES ON CPG_FRN_CODIGO = FRN_CODIGO 
         where FIN_EMP_CODIGO = {0} and FIN_FRM_CODIGO = {1} and FIN_DATA = {2} 
         ORDER BY FIN_CODIGO "
      , 0);
    }
    #endregion

    #region private bool FinanceiroExiste(int FIN_CODIGO, FIN_FINANCEIRO[] NewItems)
    private bool FinanceiroExiste(int FIN_CODIGO, FIN_FINANCEIRO[] NewItems) 
    {
      for (int i = 0; i < NewItems.Length; i++)
      {
        if (NewItems[i].FIN_CODIGO == FIN_CODIGO)
        { return true; }
      }
      return false;
    }
    #endregion

    #region public void RemoveOldItems(FIN_FINANCEIRO[] NewItems, int FIN_EMP_CODIGO, int FIN_FRM_CODIGO, DateTime FIN_DATA)
    /*public void RemoveOldItems(FIN_FINANCEIRO[] NewItems, int FIN_EMP_CODIGO, int FIN_FRM_CODIGO, DateTime FIN_DATA) 
    {
      List<FIN_FINANCEIRO> OldItems = new List<FIN_FINANCEIRO>();
      OldItems.AddRange(GetList_Despesas(FIN_EMP_CODIGO, FIN_FRM_CODIGO, FIN_DATA));
      OldItems.AddRange(GetList_Receitas(FIN_EMP_CODIGO, FIN_FRM_CODIGO, FIN_DATA));

      dsCPG_CONTAS_PAGAR bsCpg = new dsCPG_CONTAS_PAGAR(Utilities.Cnn);
      for (int i = 0; i < OldItems.Count; i++)
      {
        if (!FinanceiroExiste(OldItems[i].FIN_CODIGO, NewItems))
        {
          bsCpg.Remove(bsCpg.Get_FromFinanceiro(OldItems[i].FIN_CODIGO).CPG_CODIGO);
          this.Remove(OldItems[i].FIN_CODIGO); 
        }
      }
    }*/
    #endregion

    #region public bool FormularioTemFinanceiro(int FIN_FRM_CODIGO)
    public bool FormularioTemFinanceiro(int FIN_FRM_CODIGO) 
    {
      return cnn.Sql("SELECT COUNT(FIN_CODIGO) FROM FIN_FINANCEIRO WHERE FIN_FRM_CODIGO = " + FIN_FRM_CODIGO).ToInt() != 0;
    }
    #endregion

    #region public bool EmpresaTemFinanceiro(int FIN_EMP_CODIGO)
    public bool EmpresaTemFinanceiro(int FIN_EMP_CODIGO)
    {
      return cnn.Sql("SELECT COUNT(FIN_CODIGO) FROM FIN_FINANCEIRO WHERE FIN_EMP_CODIGO = " + FIN_EMP_CODIGO).ToInt() != 0;
    }
    #endregion

    #region public bool CategoriaTemFinanceiro(int FIN_CAT_CODIGO)
    public bool CategoriaTemFinanceiro(int FIN_CAT_CODIGO)
    {
      return cnn.Sql("SELECT COUNT(FIN_CODIGO) FROM FIN_FINANCEIRO WHERE FIN_CAT_CODIGO = " + FIN_CAT_CODIGO).ToInt() != 0;
    }
    #endregion

    #region public bool PlanoContasTemFinanceiro(int FIN_PLN_CODIGO)
    public bool PlanoContasTemFinanceiro(int FIN_PLN_CODIGO)
    {
      return cnn.Sql("SELECT COUNT(FIN_CODIGO) FROM FIN_FINANCEIRO WHERE FIN_PLN_CODIGO = " + FIN_PLN_CODIGO).ToInt() != 0;
    }
    #endregion

    #region public override LockedField[] GetLockedFields(FIN_FINANCEIRO Tab)
    public override LockedField[] GetLockedFields(FIN_FINANCEIRO Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.FIN_EMP_CODIGO == 0)
      { LockedFields.Add(new LockedField("FIN_EMP_CODIGO", " - Informe a empresa")); }

      if (Tab.FIN_CAT_CODIGO == 0)
      { LockedFields.Add(new LockedField("FIN_CAT_CODIGO", " - Informe a categoria")); }

      if (Tab.FIN_PLN_CODIGO == 0)
      { LockedFields.Add(new LockedField("FIN_PLN_CODIGO", " - Informe o plano de contas")); }

      if (Tab.FIN_EMISSAO == DateTime.MinValue)
      { LockedFields.Add(new LockedField("FIN_EMISSAO", " - Informe a data de emissão")); }

      if (Tab.FIN_DATA == DateTime.MinValue)
      { LockedFields.Add(new LockedField("FIN_DATA", " - Informe a data de entrada")); }
            
      if (Tab.PLN_OBRIGA_DESCRICAO && string.IsNullOrEmpty(Tab.FIN_DESCRICAO))
      {
        LockedFields.Add(new LockedField("PLN_OBRIGA_DESCRICAO",
          string.Format(
            " - O plano de contas {0} exige que seja informado uma descrição",
            Tab.PLN_DESCRICAO)
          )
        );
      }

      if (Tab.FIN_VALOR_NOTA == 0)
      { Tab.FIN_VALOR_NOTA = Tab.FIN_VALOR; }

      //if (Tab.FIN_VALOR == 0)
      //{ LockedFields.Add(new LockedField("FIN_VALOR", " - Informe o valor")); }
            
      return LockedFields.ToArray();
    }
    #endregion

    #region protected override void OnFillItem(FIN_FINANCEIRO Tab)
    protected override void OnFillItem(FIN_FINANCEIRO Tab)
    {
      if (Tab.FIN_EMISSAO == DateTime.MinValue)
      { Tab.FIN_EMISSAO = Tab.FIN_DATA; }

      if (Tab.CPG_VENCIMENTO == DateTime.MinValue)
      { Tab.CPG_VENCIMENTO = Tab.FIN_DATA; }
            
      base.OnFillItem(Tab);
    }
    #endregion    
  }
}
