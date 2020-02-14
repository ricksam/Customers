using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class DPL_DUPLICATAS : DefaultEntity
  {
    public int DPL_CODIGO { get; set; }
    public int DPL_NOT_CODIGO { get; set; }
    public int DPL_FIN_CODIGO { get; set; }
  }
}
