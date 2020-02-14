using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace WsPhito
{
  public class JSON
  {
    public string Serialize(object o)
    {
      System.Text.StringBuilder txt = new System.Text.StringBuilder();
      JavaScriptSerializer jav = new JavaScriptSerializer();
      jav.Serialize(o, txt);
      return txt.ToString();
    }

    public T Deserialize<T>(string s)
    {
      JavaScriptSerializer jav = new JavaScriptSerializer();
      return jav.Deserialize<T>(s);
    }
  }
}
