using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class ALT_ALERTAS : DefaultEntity
  {
    public int ALT_CODIGO { get; set; }
    public int ALT_EMP_CODIGO { get; set; }
    public int ALT_CLB_CODIGO { get; set; }
    public int ALT_HTR_CODIGO { get; set; }
    public int ALT_OCR_CODIGO { get; set; }
    public DateTime ALT_DATA { get; set; }
    public DateTime ALT_DATA_FINAL { get; set; }
    public string ALT_MENSAGEM { get; set; }
    public bool ALT_INATIVO { get; set; }
  }
}
