using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.SocialPost
{
  public partial class Token : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Request.QueryString["token"] == null)
      {
        /*if (Request.QueryString["old_token"] != null)
        {
          string link_LogOut = string.Format("https://www.facebook.com/logout.php?next={0}SocialPost/system/redirect_facebook.aspx/&access_token={1}", Utilities.Callback(), Request.QueryString["old_token"].ToString());
          lib.Class.WebUtils.GetWebResponse(link_LogOut);
        }*/

        string callback = Utilities.Callback() + "SocialPost/Token.aspx";
        string link = "http://www.rcksoftware.com.br/SocialPost/system/GetToken.aspx?type=facebook&callback=" + callback;
        Response.Redirect(link);
      }
      else
      { Response.Write("TOKEN=" + Request.QueryString["token"]); }
    }
  }
}