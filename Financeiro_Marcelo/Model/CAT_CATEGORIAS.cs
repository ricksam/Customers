using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class CAT_CATEGORIAS : DefaultEntity
  {
    public int CAT_CODIGO { get; set; }
    public string CAT_DESCRICAO { get; set; }
    public string CAT_TIPO { get; set; }
  }
}
