using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.system
{
  public partial class GetInfo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //getinfo : type=<rede_social>&token=<token>&secret=<secreto>
      if (!Page.IsPostBack)
      { Carregar(); }
    }

    private void Carregar()
    {
      string type = Request["type"].ToString();
      string token = Request["token"].ToString();
      string secret = Request["secret"].ToString();

      string link = "";
      //if (type == "twitter")
      //{ link = string.Format("{0}system/Method.aspx?type=twitter&token={1}&secret={2}&method=GET&command=http://twitter.com/account/verify_credentials.json", Utilities.Callback(), token, secret); }
      //else 
      if (type == "facebook")
      { link = string.Format("https://graph.facebook.com/me?access_token={0}", token); }
      //else if (type == "foursquare")
      //{ link = string.Format("https://api.foursquare.com/v2/users/self?oauth_token={0}", token); }
      //else if (type == "orkut")
      //{
      //  string cmbOrkut = "[{\"params\":{\"groupId\":\"@self\",\"userId\":\"@me\"},\"id\":\"1-p.g\",\"method\":\"people.get\"}]";
      //  link = string.Format("{0}system/Method.aspx?type=orkut&token={1}&secret={2}&method=GET&command={3}", Utilities.Callback(), token, secret, cmbOrkut);
      //}

      if (!string.IsNullOrEmpty(link))
      { Response.Write(lib.Class.WebUtils.GetWebResponse(link)); }
    }
  }
}