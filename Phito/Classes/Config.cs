using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phito
{
  public class Config:lib.Class.Configuration
  {
    public Config()
      : base(lib.Visual.Functions.GetDirAppCondig() + "\\Config.xml")
    { }

    public string Loja { get; set; }
    public int Guiche { get; set; }
    public string PortaImpressora { get; set; }
    public string WebService { get; set; }
  }
}
