using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class OPR_OPERACAO : DefaultEntity
  {
    public int OPR_CODIGO { get; set; }
    public string OPR_DESCRICAO { get; set; }
    public int OPR_PLN_CODIGO { get; set; }
    public int OPR_ADDESTOQUE { get; set; }
  }
}
