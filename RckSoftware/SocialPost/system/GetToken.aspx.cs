using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.system
{
  public partial class GetToken : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //Entrada : type=rede_social&callback=retorno
      if (!Page.IsPostBack)
      {
        Carregar();
      }
    }

    #region private string socialpost_type
    private string socialpost_type
    {
      get
      {
        if (Session["socialpost_type"] == null)
        { Session["socialpost_type"] = ""; }
        return Session["socialpost_type"].ToString();
      }

      set
      { Session["socialpost_type"] = value; }
    }
    #endregion

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

    #region private string socialpost_secret
    private string socialpost_secret
    {
      get
      {
        if (Session["socialpost_secret"] == null)
        { Session["socialpost_secret"] = ""; }
        return Session["socialpost_secret"].ToString();
      }

      set
      { Session["socialpost_secret"] = value; }
    }
    #endregion

    private void Carregar()
    {
      socialpost_type = Request.QueryString["type"];
      socialpost_callback = Request.QueryString["callback"];
      socialpost_args = Request.QueryString["args"];

      if (socialpost_type == "twitter")
      {
        /*aaTag.API.Twitter_OAuth oAuth = new aaTag.API.Twitter_OAuth();
        oAuth.CALLBACK = string.Format("{0}system/redirect_twitter.aspx", Utilities.Callback());
        string link = oAuth.GetAuthorizationLink();
        socialpost_secret = oAuth.TokenSecret;
        Response.Redirect(link);*/
      }
      else if (socialpost_type == "facebook")
      {
        Facebook_oAuth oAuth = new Facebook_oAuth(Utilities.Callback() + "SocialPost/system/");
        Response.Redirect(oAuth.GetAuthorizationLink());
      }
      else if (socialpost_type == "foursquare")
      {
        /*aaTag.API.Foursquare_OAuth2 oAuth = new aaTag.API.Foursquare_OAuth2();
        Response.Redirect(oAuth.GetAuthorizationLink());*/
      }
      else if (socialpost_type == "orkut")
      {
        /*aaTag.API.Orkut_OAuth oAuth = new aaTag.API.Orkut_OAuth();
        oAuth.CALLBACK = string.Format("{0}system/redirect_orkut.aspx", Utilities.Callback());
        string link = oAuth.GetAuthorizationLink();
        socialpost_secret = oAuth.TokenSecret;
        Response.Redirect(link);*/
      }
    }
  }
}