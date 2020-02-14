using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_Marcelo
{
  partial class ALT_ALERTAS
  {
    public string OCR_DESCRICAO { get; set; }
    public string EMP_NOME { get; set; }
    public string CLB_NOME { get; set; }
    public DateTime CLB_DTNASC { get; set; }

    public override string ToString()
    {
      return ALT_DATA.ToString("dd/MM/yy") + " " + ALT_MENSAGEM;
    }
  }
}
