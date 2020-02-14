using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class PLN_PLANO_CONTAS : DefaultEntity
  {
    public int PLN_CODIGO { get; set; }
    public string PLN_TIPO { get; set; }
    public string PLN_DESCRICAO { get; set; }
  }
}
