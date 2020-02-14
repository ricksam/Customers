using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class EML_EMAIL : DefaultEntity
  {
    public int EML_CODIGO { get; set; }
    public string EML_CONTATO { get; set; }
  }
}
