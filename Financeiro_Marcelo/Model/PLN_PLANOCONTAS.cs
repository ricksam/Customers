using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class PLN_PLANOCONTAS : DefaultEntity
  {
    public int PLN_CODIGO { get; set; }
    public int PLN_CAT_CODIGO { get; set; }
    public int PLN_PRIORIDADE { get; set; }
    public string PLN_DESCRICAO { get; set; }
    public bool PLN_OBRIGA_DESCRICAO { get; set; }
    public bool PLN_CONFERENCIA { get; set; }
    public bool PLN_ADICIONA_ITENS { get; set; }
  }
}
