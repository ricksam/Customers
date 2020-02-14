using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class samlController : Controller
    {
        //
        // GET: /saml/

        public ActionResult Index()
        {
            string xlog = "";
            foreach (var item in Request.ServerVariables)
            { xlog += "[" + item.ToString() + "]=" + Request[item.ToString()] + " <br /> "; }
            Response.Write(xlog);

            Response.Write("QueryString:\n");
            for (int i = 0; i < Request.QueryString.Count; i++)
            {
                Response.Write(Request.QueryString.AllKeys[i] + " = " + Request.QueryString[i] + "<br />");
            }
            Response.Write("Forms:\n");
            for (int i = 0; i < Request.Form.Count; i++)
            {
                Response.Write(Request.Form.AllKeys[i] + " = " + Request.Form[i] + "<br />");
            }
            return Content("");
        }
    }
}
