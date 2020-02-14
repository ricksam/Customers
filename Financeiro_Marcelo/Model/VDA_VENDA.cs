using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class VDA_VENDA : DefaultEntity
  {
    public int VDA_CODIGO { get; set; }
    public int VDA_FRM_CODIGO { get; set; }
    public string VDA_CNPJ { get; set; }
    public string VDA_EMPRESA { get; set; }
    public DateTime VDA_EMISSAO { get; set; }
    public string VDA_INICIO { get; set; }
    public int VDA_COD_OPERADOR { get; set; }
    public string VDA_OPERADOR { get; set; }
    public int VDA_CUPONS { get; set; }
    public decimal VDA_TOTAL { get; set; }
  }
}
