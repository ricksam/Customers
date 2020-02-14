using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class STATES : DefaultEntity
  {
    public int ID { get; set; }
    public string STATE { get; set; }
    public override string ToString()
    {
      return STATE;
    }
  }
}
