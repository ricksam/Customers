using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class ADDRESS : DefaultEntity
  {
    public int ID { get; set; }
    public string ZIPCODE { get; set; }
    public string NAME { get; set; }
    public string NEIGHBORHOOD { get; set; }
    public string CITY { get; set; }
    public string STATE { get; set; }
  }
}
