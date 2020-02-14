using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsCCN_CADASTRO_CONTAS
  {
    public CCN_CADASTRO_CONTAS[] Search(string s) 
    {
      return GetList(
        string.Format(
        @"
          SELECT * FROM CCN_CADASTRO_CONTAS 
          INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = CCN_EMP_CODIGO
          WHERE 
            CCN_BANCO LIKE {0}
            OR CCN_AGENCIA LIKE {0}
            OR CCN_CONTA LIKE {0}
            OR EMP_DESCRICAO LIKE {0}
          ORDER BY EMP_DESCRICAO, CCN_BANCO
        ",
        cnn.dbu.Quoted("%" + s + "%")), 0
      );
    }

    public CCN_CADASTRO_CONTAS[] GetList_FromEmpresa(int CCN_EMP_CODIGO)
    {
      this.cnn.QueryParam.Add(CCN_EMP_CODIGO);
      return GetList(" SELECT * FROM CCN_CADASTRO_CONTAS WHERE CCN_EMP_CODIGO = {0} ", 0);
    }
  }
}
