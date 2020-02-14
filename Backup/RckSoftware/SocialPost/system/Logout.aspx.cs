using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.system
{
  public partial class Logout : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //string type = Request["type"];
      string token = Request["token"];
      socialpost_callback = Request["callback"];

      string link = string.Format("https://www.facebook.com/logout.php?next={0}SocialPost/system/&access_token={1}", Utilities.Callback(), token);
      Response.Redirect(link);
    }

    #region private string socialpost_callback
    private string socialpost_callback
    {
      get
      {
        if (Session["socialpost_callback"] == null)
        { Session["socialpost_callback"] = ""; }
        return Session["socialpost_callback"].ToString();
      }

      set
      { Session["socialpost_callback"] = value; }
    }
    #endregion
  }
}