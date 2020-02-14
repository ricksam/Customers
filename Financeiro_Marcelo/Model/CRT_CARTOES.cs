using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class CRT_CARTOES : DefaultEntity
  {
    public int CRT_CODIGO { get; set; }
    public int CRT_EMP_CODIGO { get; set; }
    public string CRT_DESCRICAO { get; set; }
    public int CRT_NRDIAS { get; set; }
    public int CRT_SEMANA { get; set; }
    public string CRT_VENCIMENTOS { get; set; }
    public decimal CRT_TAXA { get; set; }    
  }
}
