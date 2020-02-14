using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsTAL_TALAO_CHEQUE
  {
    lib.Class.Conversion Cnv = new lib.Class.Conversion();

    #region public TAL_TALAO_CHEQUE[] Search(string s)
    public TAL_TALAO_CHEQUE[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      int val = Cnv.ToInt(s);

      if (val == 0) 
      {
        this.cnn.QueryParam.Add("%" + s + "%");
        return GetList(
          @"SELECT * FROM TAL_TALAO_CHEQUE
          INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = TAL_EMP_CODIGO
          WHERE 
            EMP_DESCRICAO LIKE {0}", 200);
      }
      else
      {        
        this.cnn.QueryParam.Add(val);
        this.cnn.QueryParam.Add("%" + s + "%");
        return GetList(
          @"SELECT * FROM TAL_TALAO_CHEQUE
          INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = TAL_EMP_CODIGO
          WHERE 
            EMP_DESCRICAO LIKE {1} OR
            TAL_INICIO = {0} OR
            TAL_FIM = {0} OR
            TAL_ATUAL = {0}", 200);
      }
    }
    #endregion

    #region public TAL_TALAO_CHEQUE Get_FromEmpresa(int TAL_EMP_CODIGO)
    public TAL_TALAO_CHEQUE Get_FromEmpresa(int TAL_EMP_CODIGO, int TAL_CCN_CODIGO) 
    {
      this.cnn.QueryParam.Add(TAL_EMP_CODIGO);
      this.cnn.QueryParam.Add(TAL_CCN_CODIGO);
      return Get(
        @"SELECT * FROM TAL_TALAO_CHEQUE 
          WHERE 
          TAL_EMP_CODIGO = {0} AND
          TAL_CCN_CODIGO = {1} AND
          TAL_ATUAL < TAL_FIM");
    }
    #endregion

    public override lib.Class.LockedField[] GetLockedFields(TAL_TALAO_CHEQUE Tab)
    {
      List<lib.Class.LockedField> lst = new List<lib.Class.LockedField>();
      if (Tab.TAL_EMP_CODIGO == 0)
      { lst.Add(new lib.Class.LockedField("TAL_EMP_CODIGO", "Informe a empresa")); }
      if (Tab.TAL_CCN_CODIGO == 0)
      { lst.Add(new lib.Class.LockedField("TAL_CCN_CODIGO", "Informe uma conta")); }
      return base.GetLockedFields(Tab);
    }
  }
}
