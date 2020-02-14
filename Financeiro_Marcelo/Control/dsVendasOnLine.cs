using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  public class dsVendasOnLine
  {
    public dsVendasOnLine() 
    {
      json = new JSON();
    }

    private const string LinkGet = "http://www.rcksoftware.com.br/app/marcelo_vendas/service1.2.php?method=get";
    private const string LinkDel = "http://www.rcksoftware.com.br/app/marcelo_vendas/service1.2.php?method=delete";
    
    private const string sucessfully = "sucessfully";
    JSON json { get; set; }

    public VendasOnLine[] Get() 
    {
      string js = lib.Class.WebUtils.GetWebResponse(LinkGet);
      return json.Deserialize<VendasOnLine[]>(js);
    }

    public bool Delete(int id) 
    {
      string ret = lib.Class.WebUtils.GetWebResponse(LinkDel,"id="+id);
      return (ret == sucessfully);
    }

    /*public int AddReport(string htmlCode) 
    {
      string ret = lib.Class.WebUtils.GetWebResponse(LinkAddReport, "htmlcode=" + UrlEncode(htmlCode));
      return (new lib.Class.Conversion()).ToInt(ret);
    }*/
  }
}
