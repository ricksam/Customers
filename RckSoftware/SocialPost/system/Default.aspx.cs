using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.system
{
  public partial class redirect_facebook : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      { Carregar(); }
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

    #region private string socialpost_args
    private string socialpost_args
    {
      get
      {
        if (Session["socialpost_args"] == null)
        { Session["socialpost_args"] = ""; }
        return Session["socialpost_args"].ToString();
      }

      set
      { Session["socialpost_args"] = value; }
    }
    #endregion

    private void Carregar()
    {
      if (Request["code"] != null)
      {
        Facebook_oAuth oAuth = new Facebook_oAuth(Utilities.Callback() + "SocialPost/system/");
        string token = oAuth.GetAccessToken(Request["code"]);
        if (string.IsNullOrEmpty(socialpost_args))
        { Response.Redirect(string.Format("{0}?type=facebook&token={1}", socialpost_callback, token)); }
        else
        { Response.Redirect(string.Format("{0}?type=facebook&token={1}&{2}", socialpost_callback, token, socialpost_args)); }
      }
      else if (socialpost_callback != null)
      { Response.Redirect(socialpost_callback); }
      else
      {
        Response.Write("code=null");
        if (socialpost_callback != null)
        { Response.Redirect(socialpost_callback); }
      }
    }
  }
}