using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    [CompressFilter]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            /*string resp = lib.Class.WebUtils.GetWebResponse("https://www.google.com.br", "");
            if (Request["SERVER_NAME"].ToString().ToUpper().IndexOf("RCKSOFTWARE") != -1)
            { return RedirectToAction("../Rck/Index"); }

            if (Request["SERVER_NAME"].ToString().ToUpper().IndexOf("CONCERTOSCCB") != -1)
            { return RedirectToAction("../CCB/inicio"); }

            string xlog = "";
            foreach (var item in Request.ServerVariables)
            { xlog += "[" + item.ToString() + "]=" + Request[item.ToString()] + " <br /> "; }
            //ViewBag.html = xlog;
            xlog += DateTime.Now + " " + DateTime.UtcNow;
            ViewBag.log = xlog;*/
            //if (!Request.IsSecureConnection)
            //  Response.Redirect(Request.Url.ToString().Replace("http:", "https:"));
            return View();
        }

        public ActionResult Verify()
        {
            return Content(Request.Url.ToString().Replace("http:", "https:"));
        }

        public ActionResult Redirect()
        {
            if (!Request.IsSecureConnection )
            {
                //  Response.Redirect(Request.Url.ToString().Replace("http:", "https:"));
                Response.Redirect("https://www.rcksoftware.com.br");
            }
            return Content("redirecting ...");
        }

        

    public ActionResult Ads()
        {
            return View();
        }

    }
}
