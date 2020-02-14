using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class ACS_ACESSO : DefaultEntity
  {
    public int ACS_CODIGO { get; set; }
    public string ACS_NOME { get; set; }
    public string ACS_DESCRICAO { get; set; }
  }
}
