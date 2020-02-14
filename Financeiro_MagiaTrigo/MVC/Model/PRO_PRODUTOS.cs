using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class PRO_PRODUTOS : DefaultEntity
  {
    public int PRO_CODIGO { get; set; }
    public string PRO_DESCRICAO { get; set; }
    public decimal PRO_QTDE { get; set; }
    public string PRO_UNIDADE { get; set; }
    public decimal PRO_CUSTO { get; set; }
    public decimal PRO_PRECO { get; set; }
  }
}
