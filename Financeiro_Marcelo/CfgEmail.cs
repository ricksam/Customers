using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  [Serializable]
  public class CfgEmail
  {
    public string Servidor { get; set; }
    public string Usuario { get; set; }
    public string Senha { get; set; }
    public bool HabilitaSSL { get; set; }
    public bool RequerAutenticacao { get; set; }
    public int Porta { get; set; }
  }
}
