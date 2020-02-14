using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class USU_USUARIOS : DefaultEntity
  {
    public int USU_CODIGO { get; set; }
    public string USU_NOME { get; set; }
    public string USU_SENHA { get; set; }
    public string USU_ADMIN { get; set; }
  }
}
