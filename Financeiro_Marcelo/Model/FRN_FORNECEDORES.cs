using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class FRN_FORNECEDORES : DefaultEntity
  {
    public int FRN_CODIGO { get; set; }
    public string FRN_NOME { get; set; }
    public string FRN_CNPJ { get; set; }
    public string FRN_TELEFONE { get; set; }
  }
}
