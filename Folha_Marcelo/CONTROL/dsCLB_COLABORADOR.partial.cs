using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsCLB_COLABORADOR
  {
    public string Lastsearch { get; set; }

    #region public CLB_COLABORADOR[] Search(string s)
    public CLB_COLABORADOR[] Search(string s)
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
            SELECT * FROM CLB_COLABORADOR 
            WHERE 
              CLB_EMP_CODIGO LIKE {0}
              OR CLB_NOME LIKE {0}
              OR CLB_FONE LIKE {0}
              OR CLB_RECADO LIKE {0}
              OR CLB_LOGRADOURO LIKE {0}
              OR CLB_NUMERO LIKE {0}
              OR CLB_BAIRRO LIKE {0}
              OR CLB_CIDADE LIKE {0}
              OR CLB_ESTADO LIKE {0}
              OR CLB_CEP LIKE {0}
              OR CLB_OBS LIKE {0}
              OR CLB_FOTO LIKE {0}
              OR CLB_SALARIO LIKE {0}
           ", nr_res);
    }
    #endregion

    #region public CLB_COLABORADOR GetList_FromEmpresa(int CLB_EMP_CODIGO)
    public CLB_COLABORADOR[] GetList_FromEmpresa(int CLB_EMP_CODIGO)
    {
      cnn.QueryParam.Add(CLB_EMP_CODIGO);
      return GetList("SELECT * FROM CLB_COLABORADOR WHERE CLB_EMP_CODIGO = {0} AND CLB_INATIVO = 0", 0);
    }
    #endregion

    #region public override LockedField[] GetLockedFields(CLB_COLABORADOR Tab)
    public override LockedField[] GetLockedFields(CLB_COLABORADOR Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.CLB_EMP_CODIGO == 0)
      { LockedFields.Add(new LockedField("CLB_EMP_CODIGO", " - Informe o campo empresa")); }

      if (string.IsNullOrEmpty(Tab.CLB_NOME))
      { LockedFields.Add(new LockedField("CLB_NOME", " - Informe o nome do colaborador")); }

      if (Tab.CLB_SALARIO == 0)
      { LockedFields.Add(new LockedField("CLB_SALARIO", " - Informe o salário atual do colaborador")); }

      if (Tab.CLB_DTNASC == DateTime.MinValue)
      { LockedFields.Add(new LockedField("CLB_DTNASC", " - Informe a data de nascimento")); }

      if (!string.IsNullOrEmpty(Tab.CLB_CPF) && CPFExiste(Tab.CLB_CPF, Tab.CLB_CODIGO))
      { LockedFields.Add(new LockedField("CLB_CPF", " - Este CPF já existe em outro cadastro")); }

      if (!string.IsNullOrEmpty(Tab.CLB_RG) && RGExiste(Tab.CLB_RG, Tab.CLB_CODIGO))
      { LockedFields.Add(new LockedField("CLB_RG", " - Este RG já existe em outro cadastro")); }

      return LockedFields.ToArray();
    }
    #endregion

    #region private bool CPFExiste(string CPF, int CLB_CODIGO)
    private bool CPFExiste(string CPF, int CLB_CODIGO) 
    {
      cnn.QueryParam.Add(CPF);
      cnn.QueryParam.Add(CLB_CODIGO);
      return cnn.Sql("SELECT COUNT(CLB_CODIGO) FROM CLB_COLABORADOR WHERE CLB_CPF = {0} AND CLB_CODIGO <> {1} ").ToInt() != 0;
    }
    #endregion

    #region private bool RGExiste(string CPF, int CLB_CODIGO)
    private bool RGExiste(string RG, int CLB_CODIGO)
    {
      cnn.QueryParam.Add(RG);
      cnn.QueryParam.Add(CLB_CODIGO);
      return cnn.Sql("SELECT COUNT(CLB_CODIGO) FROM CLB_COLABORADOR WHERE CLB_RG = {0} AND CLB_CODIGO <> {1} ").ToInt() != 0;
    }
    #endregion
  }
}

