using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  partial class dsBCN_BAIXA_CONTAS
  {
    public BCN_BAIXA_CONTAS[] GetList_FromEmpresa(int BCN_EMP_CODIGO) 
    {
      string ConCat = cnn.GetConcatFields(
        new string[] { 
          "'Banco:'", "CCN_BANCO", 
          "', Agencia:'", "CCN_AGENCIA", 
          "', Conta:'", "CCN_CONTA" }, "Conta", enmFieldType.String
      );

      this.cnn.QueryParam.Add(ConCat, enmFieldType.Undefined);
      this.cnn.QueryParam.Add(BCN_EMP_CODIGO);

      return GetList(
        @"
          SELECT BCN_BAIXA_CONTAS.*, {0} FROM BCN_BAIXA_CONTAS 
          LEFT OUTER JOIN CCN_CADASTRO_CONTAS ON CCN_CODIGO = BCN_CCN_CODIGO
          WHERE BCN_EMP_CODIGO = {1}          
          ORDER BY BCN_DATA_PGTO DESC, BCN_CODIGO DESC
        ", 0);
    }

    public BCN_BAIXA_CONTAS[] GetList_FromEmpresaACompensar(int BCN_EMP_CODIGO)
    {
      string ConCat = cnn.GetConcatFields(
        new string[] { 
          "'Banco:'", "CCN_BANCO", 
          "', Agencia:'", "CCN_AGENCIA", 
          "', Conta:'", "CCN_CONTA" }, "Conta", enmFieldType.String
      );

      this.cnn.QueryParam.Add(ConCat, enmFieldType.Undefined);
      this.cnn.QueryParam.Add(BCN_EMP_CODIGO);

      return GetList(
        @"
          SELECT BCN_BAIXA_CONTAS.*, {0} FROM BCN_BAIXA_CONTAS 
          INNER JOIN CCN_CADASTRO_CONTAS ON CCN_CODIGO = BCN_CCN_CODIGO
          WHERE BCN_EMP_CODIGO = {1} AND (BCN_COMPENSADO IS NULL OR BCN_COMPENSADO = 0)         
          ORDER BY BCN_DATA_PGTO DESC, BCN_CODIGO DESC
        ", 0);
    }

    public override lib.Class.LockedField[] GetLockedFields(BCN_BAIXA_CONTAS Tab)
    {
      if (Tab.BCN_TIPO_CHEQUE)
      { Tab.BCN_DESCRICAO = ""; }
      else
      {
        Tab.BCN_COMPENSADO = true;
        Tab.BCN_NUMERO_CHEQUE = "";
        Tab.BCN_CCN_CODIGO = 0;
      }

      return base.GetLockedFields(Tab);
    }
  }
}
