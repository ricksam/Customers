using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsVDA_VENDA
  {
    #region public VDA_VENDA Get_LocalizaVenda(VendasOnLine VdaOn)
    public VDA_VENDA Get_LocalizaVenda(VendasOnLine VdaOn)
    {
      if (!string.IsNullOrEmpty(VdaOn.inicio))
      {
        this.cnn.QueryParam.Add(VdaOn.emissao, lib.Database.Drivers.enmFieldType.Date);
        this.cnn.QueryParam.Add(VdaOn.empresa);
        this.cnn.QueryParam.Add(VdaOn.inicio);
        this.cnn.QueryParam.Add(VdaOn.cod_operador);

        return Get(
            @"
            select * from VDA_VENDA 
            where 
              VDA_EMISSAO = {0} and
              VDA_EMPRESA = {1} and
              VDA_INICIO = {2} and
              VDA_COD_OPERADOR = {3} 
          ");
      }
      else 
      {
        this.cnn.QueryParam.Add(VdaOn.emissao, lib.Database.Drivers.enmFieldType.Date);
        this.cnn.QueryParam.Add(VdaOn.empresa);
        this.cnn.QueryParam.Add(VdaOn.cod_operador);

        return Get(
            @"
            select * from VDA_VENDA 
            where 
              VDA_EMISSAO = {0} and
              VDA_EMPRESA = {1} and
              VDA_COD_OPERADOR = {2} 
          ");
      }
    }
    #endregion

    #region public VDA_VENDA[] GetList_SemFormulario()
    public VDA_VENDA[] GetList_SemFormulario() 
    {
      //return GetList("SELECT * FROM VDA_VENDA WHERE VDA_FRM_CODIGO IS NULL OR VDA_FRM_CODIGO = 0", 0);
      return GetList(
        @"
        SELECT 
          VDA_CNPJ,
          VDA_EMPRESA,
          VDA_EMISSAO,  
          VDA_COD_OPERADOR,
          VDA_OPERADOR,
          MIN(VDA_INICIO) AS VDA_INICIO,
          SUM(VDA_CUPONS) AS VDA_CUPONS,
          SUM(VDA_TOTAL) AS VDA_TOTAL
        FROM VDA_VENDA 
        WHERE 
          (VDA_FRM_CODIGO IS NULL OR VDA_FRM_CODIGO = 0)
          AND
          (VDA_COD_OPERADOR IS NOT NULL AND VDA_COD_OPERADOR <> 0)
        GROUP BY 
          VDA_CNPJ,
          VDA_EMPRESA,
          VDA_EMISSAO,  
          VDA_COD_OPERADOR,
          VDA_OPERADOR
        ORDER BY           
          VDA_EMISSAO DESC"
      , 0);
    }
    #endregion

    #region public bool SaveNrForm(VDA_VENDA Tab)
    public bool SaveNrForm(VDA_VENDA Tab) 
    {
      this.sb.Clear();
      this.sb.Table = "VDA_VENDA";

      this.sb.AddField("VDA_FRM_CODIGO", Tab.VDA_FRM_CODIGO);

      this.cnn.QueryParam.Add(Tab.VDA_EMPRESA);
      this.cnn.QueryParam.Add(Tab.VDA_EMISSAO, lib.Database.Drivers.enmFieldType.Date);
      this.cnn.QueryParam.Add(Tab.VDA_COD_OPERADOR);

      return this.cnn.Exec(
        this.sb.getUpdate(
          @"
            where 
              VDA_EMPRESA = {0} AND 
              VDA_EMISSAO = {1} AND 
              VDA_COD_OPERADOR = {2}
          "
        )
      );
    }
    #endregion

    #region public bool ExisteVendaEsteMes()
    public bool ExisteVendaEsteMes() 
    {
      return cnn.Sql(
        @"
        SELECT COUNT(VDA_CODIGO) FROM VDA_VENDA 
        WHERE 
          EXTRACT(MONTH FROM VDA_EMISSAO) = EXTRACT(MONTH FROM NOW())
          AND EXTRACT(YEAR FROM VDA_EMISSAO) = EXTRACT(YEAR FROM NOW())
          AND EXTRACT(DAY FROM VDA_EMISSAO) <> EXTRACT(DAY FROM NOW())"
        ).ToInt() != 0;
    }
    #endregion
  }
}
