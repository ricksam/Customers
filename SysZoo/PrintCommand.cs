using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysZoo
{
  public class PrintCommand
  {
    char[] h = new char[] { ((char)10), ((char)13), ((char)14) };
    char[] eh = new char[] { ((char)20), ((char)10), ((char)13) };

    char[] e = new char[] { ((char)27), ((char)14) };
    char[] ee = new char[] { ((char)27), ((char)20) };

    char[] b = new char[] { ((char)27), ((char)69) };
    char[] eb = new char[] { ((char)27), ((char)70) };

    char[] gl = new char[] { ((char)27), ((char)119) }; //#27 + #119 (total); #27 + #109 (parcial);

    char[] pl = new char[] { ((char)27), ((char)112) };

    public string cr = "\r\n";
    public string ln = ((char)10).ToString();
    public string bl = ((char)07).ToString();

    public string Header(string s)
    { return (new string(h)) + s + (new string(eh)); }

    public string Extended(string s)
    { return (new string(e)) + s + (new string(ee)); }

    public string Bold(string s)
    { return (new string(b)) + s + (new string(eb)); }

    public string Guillotine()
    {
      return new string(gl);
    }

    public string Pulse()
    {
      return new string(pl);
    }
  }
}
