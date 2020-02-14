using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class FNI_FINANCEIRO_ITEM : DefaultEntity
  {
    public FNI_FINANCEIRO_ITEM() 
    {
      this.FNI_QTDE = 1;
    }

    public int FNI_CODIGO { get; set; }
    public int FNI_FIN_CODIGO { get; set; }
    public string FNI_DESCRICAO { get; set; }
    public decimal FNI_QTDE { get; set; }
    public decimal FNI_VALOR_TOTAL { get; set; }
    public decimal FNI_VALOR_UNITARIO { get; set; }
    public string FNI_EXPRESSAO { get; set; }
  }
}
