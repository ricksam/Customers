using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Class;

namespace Folha_Marcelo
{
  partial class dsOPR_OPERACAO
  {
    public string Lastsearch { get; set; }
    List<string> ReservedFields { get; set; }

    #region private void LoadReservedField()
    private void LoadReservedField()
    {
      CFG_CONFIG cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();
      ReservedFields = new List<string>();
      ReservedFields.Add(cfg.CFG_CAMPO_REMUNERACAO);
      ReservedFields.Add(cfg.CFG_CAMPO_REMUNERACAO_TOTAL);
      ReservedFields.Add(cfg.CFG_CAMPO_DESCONTO_TOTAL);
      ReservedFields.Add(cfg.CFG_CAMPO_REMUNERACAO_LIQUIDA);
      ReservedFields.Add(cfg.CFG_CAMPO_REFERENCIA);
    }
    #endregion

    #region public OPR_OPERACAO[] GetList_FromDiario(bool OPR_DIARIO)
    public OPR_OPERACAO[] GetList_FromDiario(bool OPR_DIARIO) 
    {
      cnn.QueryParam.Add(OPR_DIARIO);
      return GetList("SELECT * FROM OPR_OPERACAO WHERE OPR_DIARIO = {0}", 0);
    }
    #endregion

    #region public OPR_OPERACAO[] Search(string s)
    public OPR_OPERACAO[] Search(string s)
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
            SELECT * FROM OPR_OPERACAO 
            WHERE 
              OPR_DESCRICAO LIKE {0}
              OR OPR_CAMPO LIKE {0}
              OR OPR_CALCULO LIKE {0}
              OR OPR_OBS LIKE {0}
              OR OPR_TIPO LIKE {0}
              OR OPR_DIARIO LIKE {0}
              OR OPR_NIVEL LIKE {0}
           ", nr_res);
    }
    #endregion

    #region private bool IsReservedField(string FieldName)
    private bool IsReservedField(string FieldName)
    {
      for (int i = 0; i < ReservedFields.Count; i++)
      {
        if (FieldName == ReservedFields[i])
        { return true; }
      }
      return false;
    }
    #endregion

    #region private bool CampoCadastrado(OPR_OPERACAO Tab)
    private bool CampoCadastrado(OPR_OPERACAO Tab)
    {
      cnn.QueryParam.Add(Tab.OPR_CAMPO);
      cnn.QueryParam.Add(Tab.OPR_CODIGO);

      return Get("SELECT * FROM OPR_OPERACAO WHERE OPR_CAMPO = {0} AND OPR_CODIGO <> {1}").OPR_CODIGO != 0;
    }
    #endregion

    #region public override LockedField[] GetLockedFields(OPR_OPERACAO Tab)
    public override LockedField[] GetLockedFields(OPR_OPERACAO Tab)
    {
      LoadReservedField();
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.OPR_DESCRICAO))
      { LockedFields.Add(new LockedField("OPR_DESCRICAO", " - Informe a descrição da operação")); }

      if (string.IsNullOrEmpty(Tab.OPR_CAMPO))
      { LockedFields.Add(new LockedField("OPR_CAMPO", " - Informe o nome do campo calculável para esta operação")); }

      if (IsReservedField(Tab.OPR_CAMPO))
      { LockedFields.Add(new LockedField("OPR_CAMPO", " - O nome deste campo é um nome reservado por configuração")); }

      if (CampoCadastrado(Tab))
      { LockedFields.Add(new LockedField("OPR_CAMPO", " - Campo já cadastrado")); }
      
      if (Tab.OPR_NIVEL == 0)
      { LockedFields.Add(new LockedField("OPR_NIVEL", " - Informe o nível do campo")); }

      return LockedFields.ToArray();
    }
    #endregion
  }
}

