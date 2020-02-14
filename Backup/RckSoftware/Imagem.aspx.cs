using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class Imagem : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string link = "http://www.rcksoftware.com.br/app/security/service.php";
      string postData = string.Format("method=list_image&lastdate={0}&count=1&code={1}&authenticate={2}&camera={3}", Request["lastdate"], Request["code"], Request["authenticate"], Request["camera"]);
      DataImage[] imgs = (new JSON()).Deserialize<DataImage[]>(lib.Class.WebUtils.GetWebResponse(link, postData));

      if (imgs.Length != 0)
      {
        lib.Class.Encryption enc = new lib.Class.Encryption(Request["authenticate"], "/9j4AQSkZJRgBEYD2wOxIPXFhHzMc8tLyUTldvWob3pm+naVfCG1K0iN6qe5r7us=");
        imgs[0].image = enc.Descrypt(imgs[0].image.Replace(" ", "+"));
        Response.Write((new JSON()).Serialize(imgs[0]));
      }
      else 
      { Response.Write("null"); }
    }
  }
}