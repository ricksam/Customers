using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.system
{
  public partial class Method : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //metodo : type=<rede_social>&token=<token>&secret=<secreto>&method=<metodo>&command=<commando>&args=<args>
      if (!Page.IsPostBack)
      { Carregar(); }
    }

    private void Carregar()
    {
      string Tipo = Request["type"].ToString();
      string token = Request["token"].ToString();
      string secret = Request["secret"] != null ? Request["secret"].ToString() : "";
      string method = Request["method"].ToString();
      string command = Request["command"].ToString();
      string args = Request["args"] != null ? Request["args"].ToString() : "";

      //aaTag.API.enmOAuthMethod Mt = method.ToUpper() == "GET" ? aaTag.API.enmOAuthMethod.GET : aaTag.API.enmOAuthMethod.POST;

      if (Tipo == "twitter")
      {
        /*aaTag.API.Twitter_OAuth oAuth = new aaTag.API.Twitter_OAuth();
        oAuth.Token = token;
        oAuth.TokenSecret = secret;
        Response.Write(oAuth.oAuthWebRequest(Mt, command, args));*/
      }
      else if (Tipo == "facebook")
      {
        Facebook_oAuth oAuth = new Facebook_oAuth(Utilities.Callback() + "SocialPost/system/");
        Response.Write(lib.Class.WebUtils.GetWebResponse(command, args)); //oAuth.WebRequest(Mt, command, args));
      }
      else if (Tipo == "foursquare")
      {
        /*aaTag.API.Foursquare_OAuth2 oAuth = new aaTag.API.Foursquare_OAuth2();
        Response.Write(oAuth.WebRequest(Mt, command, args));*/
      }
      else if (Tipo == "orkut")
      {
        /*aaTag.API.Orkut_OAuth oAuth = new aaTag.API.Orkut_OAuth();
        oAuth.Token = token;
        oAuth.TokenSecret = secret;
        Response.Write(oAuth.postWebRequest(oAuth.Token, oAuth.TokenSecret, command));*/
      }
    }
  }
}