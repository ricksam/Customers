using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsEMP_EMPRESAS
  {
    /*public EMP_EMPRESAS Get_FromDescricao(string EMP_DESCRICAO) 
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add(EMP_DESCRICAO);
      return Get("SELECT * FROM EMP_EMPRESAS WHERE EMP_DESCRICAO = {0}");
    }*/

    public EMP_EMPRESAS Get_FromDescricaoOnLine(string EMP_DESCRICAO_ONLINE)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add(EMP_DESCRICAO_ONLINE);
      return Get("SELECT * FROM EMP_EMPRESAS WHERE EMP_DESCRICAO_ONLINE = {0}");
    }

    public EMP_EMPRESAS[] Search(string s) 
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");
      return GetList("SELECT * FROM EMP_EMPRESAS WHERE EMP_DESCRICAO LIKE {0} OR EMP_DESCRICAO_ONLINE LIKE {0}", 200);
    }
  }
}
