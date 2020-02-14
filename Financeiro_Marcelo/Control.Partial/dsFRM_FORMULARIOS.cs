using System;
using System.Collections.Generic;
using System.Text;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  partial class dsFRM_FORMULARIOS 
  {
    public FRM_FORMULARIOS Get(int EMP_CODIGO, int FRM_NUMERO, DateTime FRM_DATA) 
    {
      cnn.QueryParam.Clear();
      cnn.QueryParam.Add(EMP_CODIGO);
      cnn.QueryParam.Add(FRM_NUMERO);
      cnn.QueryParam.Add(FRM_DATA, lib.Database.Drivers.enmFieldType.Date);
      return Get(
        " select * from FRM_FORMULARIOS" +
        " where FRM_EMP_CODIGO = {0} and FRM_NUMERO = {1} and FRM_DATA = {2}"
      );
    }

    public FRM_FORMULARIOS[] GetUltimosFormularios(int FRM_EMP_CODIGO, int Qtde)
    {
      return GetList(
        string.Format(
        " select * from FRM_FORMULARIOS" +
        " inner join EMP_EMPRESAS on EMP_CODIGO = FRM_EMP_CODIGO " +
        " where FRM_EMP_CODIGO = {0} " +
        " order by FRM_DATA desc, FRM_NUMERO desc ", FRM_EMP_CODIGO), Qtde == 0 ? 1000 : Qtde);
    }

    public FRM_FORMULARIOS[] GetList_SemVendas(string s, int FRM_EMP_CODIGO) 
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add(FRM_EMP_CODIGO, enmFieldType.Int);
      this.cnn.QueryParam.Add(this.cnn.GetConvertField("FRM_NUMERO", enmFieldType.String), enmFieldType.Undefined);
      this.cnn.QueryParam.Add("%" + s + "%");
      
      return GetList(
        @" 
         select * from FRM_FORMULARIOS
         inner join EMP_EMPRESAS on EMP_CODIGO = FRM_EMP_CODIGO AND FRM_EMP_CODIGO = {0}
         left outer join VDA_VENDA on VDA_CODIGO IS NULL 
         where
            {1} LIKE {2} OR
            EMP_DESCRICAO LIKE {2} OR
            FRM_DATA LIKE {2}
            
         order by FRM_DATA desc, FRM_NUMERO desc", 100);
    }
  }
}
