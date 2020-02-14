using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class HTR_HISTORICO : DefaultEntity
  {
    public int HTR_CODIGO { get; set; }
    public int HTR_EMP_CODIGO { get; set; }
    public int HTR_CLB_CODIGO { get; set; }
    public int HTR_OCR_CODIGO { get; set; }
    public DateTime HTR_DATA { get; set; }
    public string HTR_OBSERVACAO { get; set; }
  }
}
