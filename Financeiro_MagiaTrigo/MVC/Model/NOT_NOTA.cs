using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class NOT_NOTA : DefaultEntity
  {
    public int NOT_CODIGO { get; set; }
    public int NOT_OPR_CODIGO { get; set; }
    public int NOT_DOCUMENTO { get; set; }
    public DateTime NOT_ENTRADA { get; set; }
    public DateTime NOT_EMISSAO { get; set; }
  }
}
