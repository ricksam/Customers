using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysZoo
{
  public class EpsonCommand
  {
    public string Center(string s, int size)
    {
      size = size - s.Length;
      int sizeini = size / 2;
      int sizefim = size - sizeini;
      return "".PadLeft(sizeini) + s + "".PadLeft(sizefim); 
    }

    public string ExtOn()
    {
      return (new string(new char[] { ((char)0x1D), '!', ((char)17), ((char)0xA) }));
    }

    public string ExtOff()
    {
      return (new string(new char[] { ((char)0x1D), '!', ((char)0), ((char)0xA) }));
    }

    public string BlackOn()
    {
      return (new string(new char[] { ((char)0x1D), 'B', ((char)1), ((char)0xA) }));
    }

    public string BlackOff()
    {
      return (new string(new char[] { ((char)0x1D), 'B', ((char)0), ((char)0xA) }));
    }

    public string Black(string s)
    { return BlackOn() + s + BlackOff(); }

    public string Extended(string s)
    { return ExtOn() + s + ExtOff(); }

    public string Guillotine()
    {
      //PRINT #1," AAAAA";
      //PRINT #1,CHR$(&H1B);"d";CHR$(5);
      //PRINT #1,CHR$(&H1B);"m"; ←Cut paper
      //PRINT #1," BBBBB";
      //PRINT #1,CHR$(&H1B);"d";CHR$(5);
      //PRINT #1,CHR$(&H1B);"i"; ←Cut paper all

      return (new string(new char[] { ((char)0x1B), 'd', ((char)5) })) + 
        (new string(new char[] { ((char)0x1B), 'm' }));
    }

    public string Pulse()
    {
      return (new string(new char[] { ((char)0x1B), 'p', ((char)0), ((char)25), ((char)250) }));
    }

    public string Barcode(string code)
    {
      //PRINT #1, CHR$(&H1D);"h";CHR$(80); ←Set height
      //PRINT #1, CHR$(&H1D);"H";CHR$(2); ←Select print position
      //PRINT #1, CHR$(&H1D);"f";CHR$(0); ←Select font
      //PRINT #1, CHR$(&H1D);"k";CHR$(2); ←Print bar code
      //PRINT #1, "496595707379";CHR$(0);
      //PRINT #1, CHR$(&HA);
      //PRINT #1, CHR$(&H1D);"f";CHR$(1); ←Select font
      //PRINT #1, CHR$(&H1D);"k";CHR$(2); ←Print bar code
      //PRINT #1, "496595707379";CHR$(0);

      return (new string(new char[]{
        ((char)0x1d),'h',((char)80), //Select height
        ((char)0x1d),'H',((char)2), //Select print position
        ((char)0x1d),'f',((char)0), //Select font
        ((char)0x1d),'k',((char)2) //Select barcode
      }) + code +
      new string(new char[]{
        ((char)0),
      }));
    } 
  }
}
