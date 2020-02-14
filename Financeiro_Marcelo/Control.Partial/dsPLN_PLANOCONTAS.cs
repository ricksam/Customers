using System;
using System.Collections.Generic;
using System.Text;
using lib.Class;

namespace Financeiro_Marcelo
{
  partial class dsPLN_PLANOCONTAS
  {
    #region public PLN_PLANOCONTAS[] GetList(int PLN_CAT_CODIGO)
    public PLN_PLANOCONTAS[] GetList(int PLN_CAT_CODIGO)
    {
      return GetList("select * from PLN_PLANOCONTAS where PLN_CAT_CODIGO = " + PLN_CAT_CODIGO.ToString(), 0);
    }
    #endregion

    #region private bool PlanoExiste(int PLN_CODIGO, PLN_PLANOCONTAS[] Plns)
    private bool PlanoExiste(int PLN_CODIGO, PLN_PLANOCONTAS[] Plns) 
    {
      for (int i = 0; i < Plns.Length; i++)
      {
        if (Plns[i].PLN_CODIGO == PLN_CODIGO)
        { return true; }
      }
      return false;
    }
    #endregion

    #region public void RemoveOldItems(PLN_PLANOCONTAS[] NewItens, int PLN_CAT_CODIGO)
    public void RemoveOldItems(PLN_PLANOCONTAS[] NewItens, int PLN_CAT_CODIGO) 
    {
      PLN_PLANOCONTAS[] Plns = GetList(PLN_CAT_CODIGO);
      for (int i = 0; i < Plns.Length; i++)
      {
        if (!PlanoExiste(Plns[i].PLN_CODIGO, NewItens))
        { this.Remove(Plns[i].PLN_CODIGO); }
      }
    }
    #endregion

    public override LockedField[] GetLockedFields(PLN_PLANOCONTAS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();
      if (string.IsNullOrEmpty(Tab.PLN_DESCRICAO))
      { LockedFields.Add(new LockedField("PLN_DESCRICAO", " - A descrição não pode ser vazia.")); }

      return base.GetLockedFields(Tab);
    }

    /*#region partial void GetPartialLockedFields(PLN_PLANOCONTAS Tab, List<LockedField> LockedFields)
    partial void GetPartialLockedFields(PLN_PLANOCONTAS Tab, List<LockedField> LockedFields) 
    {
      
    }
    #endregion*/
  }
}
