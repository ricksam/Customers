using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class NTI_ITENS : DefaultEntity
  {
    public int NTI_CODIGO { get; set; }
    public int NTI_NTF_CODIGO { get; set; }
    public int NTI_PRO_CODIGO { get; set; }
  }
}
