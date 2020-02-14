using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  partial class dsCPG_CONTAS_PAGAR
  {
    public string Lastsearch { get; set; }
    public CPG_CONTAS_PAGAR Get_FromFinanceiro(int CPG_FIN_CODIGO) 
    {
      return Get("SELECT * FROM CPG_CONTAS_PAGAR WHERE CPG_FIN_CODIGO = " + CPG_FIN_CODIGO);
    }

    #region public CPG_CONTAS_PAGAR[] Search(string s)
    public CPG_CONTAS_PAGAR[] Search(string s) 
    {
      int nr_res = 5;// < 5 ? s.Length : 100;

      if (s == Lastsearch)
      { nr_res = 100; }
      else
      { Lastsearch = s; }

      return GetList(
        string.Format(
        @"
          SELECT * FROM CPG_CONTAS_PAGAR 
          INNER JOIN FIN_FINANCEIRO ON FIN_CODIGO = CPG_FIN_CODIGO          
          INNER JOIN CAT_CATEGORIAS ON CAT_CODIGO = FIN_CAT_CODIGO
          INNER JOIN PLN_PLANOCONTAS ON PLN_CODIGO = FIN_PLN_CODIGO
          INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = FIN_EMP_CODIGO 
          LEFT OUTER JOIN FRN_FORNECEDORES ON FRN_CODIGO = CPG_FRN_CODIGO         
          LEFT OUTER JOIN FRM_FORMULARIOS ON FRM_CODIGO = FIN_FRM_CODIGO
          WHERE 
            (
            EMP_DESCRICAO LIKE {0}
            OR FRN_NOME LIKE {0}
            OR CAT_DESCRICAO LIKE {0}
            OR PLN_DESCRICAO LIKE {0}
            OR FIN_DESCRICAO LIKE {0}
            OR CPG_DOCUMENTO LIKE {0}
            OR FIN_EMISSAO LIKE {0} 
            OR FIN_DATA LIKE {0}
            OR CPG_VENCIMENTO LIKE {0}
            OR {1} LIKE {0}
            )
            AND CPG_BCN_CODIGO IS NULL
          ORDER BY CPG_VENCIMENTO, EMP_DESCRICAO, CAT_DESCRICAO, PLN_DESCRICAO
        ",
        cnn.dbu.Quoted("%" + s + "%"),
        cnn.GetConvertField("FIN_VALOR", enmFieldType.String)
        ), nr_res
      );
    }
    #endregion

    public CPG_CONTAS_PAGAR[] Consulta(string s)
    {
      this.cnn.QueryParam.Add("%" + s + "%");
      this.cnn.QueryParam.Add(cnn.GetConvertField("FIN_VALOR", enmFieldType.String), enmFieldType.Undefined);
      return GetList(
        @"
          SELECT 
            CPG_CODIGO,
            EMP_DESCRICAO, CAT_DESCRICAO, PLN_DESCRICAO, FIN_DESCRICAO,
            FRM_NUMERO, CPG_DOCUMENTO, BCN_NUMERO_CHEQUE, 
            CCN_BANCO, CCN_AGENCIA, CCN_CONTA,
            FIN_EMISSAO, FIN_DATA, CPG_VENCIMENTO, FIN_DATA_PGTO,
            FIN_VALOR 
          FROM CPG_CONTAS_PAGAR
          INNER JOIN FIN_FINANCEIRO ON FIN_CODIGO = CPG_FIN_CODIGO
          INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = FIN_EMP_CODIGO
          INNER JOIN CAT_CATEGORIAS ON CAT_CODIGO = FIN_CAT_CODIGO
          INNER JOIN PLN_PLANOCONTAS ON PLN_CODIGO = FIN_PLN_CODIGO
          LEFT OUTER JOIN FRM_FORMULARIOS ON FRM_CODIGO = FIN_FRM_CODIGO
          LEFT OUTER JOIN BCN_BAIXA_CONTAS ON BCN_CODIGO = CPG_BCN_CODIGO
          LEFT OUTER JOIN CCN_CADASTRO_CONTAS ON CCN_CODIGO = BCN_CCN_CODIGO
          WHERE 
            (
            EMP_DESCRICAO LIKE {0}
            OR CAT_DESCRICAO LIKE {0}
            OR PLN_DESCRICAO LIKE {0}
            OR FIN_DESCRICAO LIKE {0}
            OR FRM_NUMERO LIKE {0}
            OR CPG_DOCUMENTO LIKE {0}
            OR BCN_NUMERO_CHEQUE LIKE {0}
            OR CCN_BANCO LIKE {0}
            OR CCN_AGENCIA LIKE {0}
            OR CCN_CONTA LIKE {0}
            OR FIN_EMISSAO LIKE {0} 
            OR FIN_DATA LIKE {0}
            OR CPG_VENCIMENTO LIKE {0}
            OR BCN_DATA_PGTO LIKE {0}
            OR {1} LIKE {0}
            )", 100
      );
    }

    public override LockedField[] GetLockedFields(CPG_CONTAS_PAGAR Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();
      if (Tab.CPG_VENCIMENTO == DateTime.MinValue)
      { LockedFields.Add(new LockedField("CPG_VENCIMENTO", " - Informe a data de vencimento")); }

      return LockedFields.ToArray();
    }
        
    public CPG_CONTAS_PAGAR[] GetList_EmAberto(int CPG_EMP_CODIGO, DateTime CPG_VENCIMENTO)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add(CPG_EMP_CODIGO);
      this.cnn.QueryParam.Add(CPG_VENCIMENTO, enmFieldType.Date);
      return GetList(
        @"SELECT * FROM CPG_CONTAS_PAGAR 
          INNER JOIN FIN_FINANCEIRO ON FIN_CODIGO = CPG_FIN_CODIGO
          INNER JOIN CAT_CATEGORIAS ON CAT_CODIGO = FIN_CAT_CODIGO
          INNER JOIN PLN_PLANOCONTAS ON PLN_CODIGO = FIN_PLN_CODIGO
          INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = FIN_EMP_CODIGO
          LEFT OUTER JOIN FRM_FORMULARIOS ON FRM_CODIGO = FIN_FRM_CODIGO
          LEFT OUTER JOIN FRN_FORNECEDORES ON FRN_CODIGO = CPG_FRN_CODIGO
          WHERE 
             CPG_EMP_CODIGO = {0}
             AND CPG_VENCIMENTO <= {1}
             AND CPG_BCN_CODIGO IS NULL
          ORDER BY CPG_VENCIMENTO, EMP_DESCRICAO, CAT_DESCRICAO, PLN_DESCRICAO"
        , 0);
    }

    public CPG_CONTAS_PAGAR[] GetList_FromBaixa(int CPG_BCN_CODIGO) 
    {
      this.cnn.QueryParam.Add(CPG_BCN_CODIGO);
      return GetList(
        @"SELECT * FROM CPG_CONTAS_PAGAR 
          INNER JOIN FIN_FINANCEIRO ON FIN_CODIGO = CPG_FIN_CODIGO
          INNER JOIN CAT_CATEGORIAS ON CAT_CODIGO = FIN_CAT_CODIGO
          INNER JOIN PLN_PLANOCONTAS ON PLN_CODIGO = FIN_PLN_CODIGO
          INNER JOIN EMP_EMPRESAS ON EMP_CODIGO = FIN_EMP_CODIGO
          WHERE CPG_BCN_CODIGO = {0}
          ORDER BY CPG_VENCIMENTO DESC, EMP_DESCRICAO, CAT_DESCRICAO, PLN_DESCRICAO"
        , 0);
    }

    public void Remover_FromBaixa(int CPG_BCN_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CPG_CONTAS_PAGAR";
      this.sb.AddField("CPG_BCN_CODIGO", null);
      this.cnn.Exec(this.sb.getUpdate("WHERE CPG_BCN_CODIGO = " + CPG_BCN_CODIGO));
    }

    public void Remove_FromFinanceiro(int CPG_FIN_CODIGO) 
    {
      this.sb.Clear();
      this.sb.Table = "CPG_CONTAS_PAGAR";
      this.cnn.Exec(this.sb.getDelete("WHERE CPG_FIN_CODIGO = " + CPG_FIN_CODIGO));
    }
  }
}
