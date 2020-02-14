using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsEML_EMAIL
  {
    public EML_EMAIL Get_FromContato(string EML_CONTATO) 
    {
      this.cnn.QueryParam.Add(EML_CONTATO);
      return Get("SELECT * FROM EML_EMAIL WHERE EML_CONTATO = {0}");
    }
  }
}
