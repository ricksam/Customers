using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class OPR_OPERACAO : DefaultEntity
  {
    public int OPR_CODIGO { get; set; }
    public string OPR_DESCRICAO { get; set; }
    public string OPR_CAMPO { get; set; }
    public string OPR_CALCULO { get; set; }
    public string OPR_OBS { get; set; }
    public string OPR_TIPO { get; set; }
    public bool OPR_DIARIO { get; set; }
    public int OPR_NIVEL { get; set; }
  }
}
