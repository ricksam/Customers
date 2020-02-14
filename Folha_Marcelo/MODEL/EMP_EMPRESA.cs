using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class EMP_EMPRESA : DefaultEntity
  {
    public int EMP_CODIGO { get; set; }
    public string EMP_NOME { get; set; }
    public bool EMP_INATIVO { get; set; }
    public override string ToString()
    {
      return EMP_NOME;
    }
  }
}
