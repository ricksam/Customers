using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class ACU_ACESSO_USUARIO : DefaultEntity
  {
    public int ACU_ACS_CODIGO { get; set; }
    public int ACU_USU_CODIGO { get; set; }
  }
}
