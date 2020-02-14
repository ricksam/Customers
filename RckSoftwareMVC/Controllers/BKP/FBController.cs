using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
  public class FBController : Controller
  {
    //
    // GET: /FB/

    public static string SessionName = "RckSoftwareSocialNetworkName";

    public ActionResult Index()
    {
      return View();
    }

    private lib.Entity.MySQL GetDatabase()
    {
      string ConnectionString =
          string.Format(
            "Server={0};Database={1};Uid={2};Pwd={3};",
            new object[]
            {
              "187.45.196.220",
              "rcksoftware",
              "rcksoftware",
              "RCK6px2erjr"
            }
          );
      return new lib.Entity.MySQL(ConnectionString);
    }

    public ActionResult authorize(string id)
    {
      Session[SessionName] = id;
      RckSoftwareMVC.SOCIAL_NETWORK sn = (new RckSoftwareMVC.dsSOCIAL_NETWORK(GetDatabase())).Get_FromName(id);
      string link = string.Format("https://graph.facebook.com/oauth/authorize?client_id={0}&redirect_uri={1}&scope={2}", sn.CLIENT_ID, sn.REDIRECT_URI, sn.SCOPE);
      Response.Redirect(link);
      return View();
    }

    public ActionResult access_token(string code)
    {
      string id = Session[SessionName].ToString();
      RckSoftwareMVC.SOCIAL_NETWORK sn = (new RckSoftwareMVC.dsSOCIAL_NETWORK(GetDatabase())).Get_FromName(id);
      string link = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&client_secret={2}&code={3}", sn.CLIENT_ID, sn.REDIRECT_URI, sn.CLIENT_SECRET, code);
      string response = lib.Class.WebUtils.GetWebResponse(link);
      if (response.Length > 0)
      {
        //Store the returned access_token
        System.Collections.Specialized.NameValueCollection qs = HttpUtility.ParseQueryString(response);

        if (qs["access_token"] != null)
        {
          //this.Token = qs["access_token"];
          ViewBag.access_token = qs["access_token"];
        }
      }

      if (!string.IsNullOrEmpty(sn.CALLBACK))
      { Response.Redirect(sn.CALLBACK + code); }

      return View();
    }
  }
}
