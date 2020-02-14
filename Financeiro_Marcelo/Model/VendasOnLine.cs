using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  public class VendasOnLine
  {
    public int id { get; set; }
    public string cnpj { get; set; }
    public string empresa { get; set; }
    public string emissao { get; set; }
    public string inicio { get; set; }
    public int cod_operador { get; set; }
    public string operador { get; set; }
    public int cupons { get; set; }
    public decimal total { get; set; }
  }
}
