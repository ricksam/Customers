using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas_Marcelo
{
  public class Config : lib.Class.Configuration
  {
    public Config()
      : base(lib.Visual.Functions.GetDirAppCondig() + "\\Config.xml")
    { }

    public int Sleep { get; set; }
    public string Program { get; set; }
    public string Arguments { get; set; }
  }
}
