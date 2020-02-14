using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public class EMP_EMPRESAS : DefaultEntity
  {
    public int EMP_CODIGO { get; set; }
    public string EMP_DESCRICAO { get; set; }
    public string EMP_CNPJ { get; set; }
    public string EMP_DESCRICAO_ONLINE { get; set; }
  }
}
