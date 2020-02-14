using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace WsPhito
{
  public partial class ATD_ATENDIMENTO 
  {
    public int ATD_CODIGO { get; set; }
    public DateTime ATD_ABERTURA { get; set; }
    public string ATD_LOJA { get; set; }
    public string ATD_ASSUNTO { get; set; }
    public int ATD_GUICHE { get; set; }
    public string ATD_SENHA { get; set; }
    public bool ATD_PREFERENCIAL { get; set; }
    public DateTime ATD_INICIO { get; set; }
    public DateTime ATD_FIM { get; set; }
    public bool ATD_CONCLUIDO { get; set; }
  }
}
