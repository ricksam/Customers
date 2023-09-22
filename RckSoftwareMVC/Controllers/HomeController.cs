using lib.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Tokenizer;

namespace RckSoftwareMVC.Controllers
{
    [CompressFilter]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        System.Web.Caching.Cache Cache = new System.Web.Caching.Cache();

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

        public ActionResult Template() {
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

        [HttpPost]
        public ActionResult Req(object data) {
            lib.Class.JSON json = new lib.Class.JSON();
            Cache["data"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")+" "+ json.Serialize(data);
            return Content("ok");
        }

        [HttpPost]
        public ActionResult Form()
        {
            lib.Class.JSON json = new lib.Class.JSON();

            List<string> list = new List<string>();
            foreach (var item in Request.Form)
            { list.Add("[" + item.ToString() + "]=" + Request.Form[item.ToString()]); }

            Cache["data"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + json.Serialize(list);
            return Content("ok");
        }

        [HttpGet]
        public ActionResult lastdata()
        {
            string data = Cache["data"].ToString();
            return Content(data);
        }


        [HttpGet]
        public ActionResult TestJson()
        {
            lib.Class.JSON json = new lib.Class.JSON();
            List<Models.Teste> list = new List<Models.Teste>();
            list.Add(new Models.Teste() { Name = "Linux" });
            list.Add(new Models.Teste() { Name = "Windows" });
            list.Add(new Models.Teste() { Name = "Apple" });
            return Content(json.Serialize( list), "application/json");
        }



        public ActionResult Ads()
        {
            return View();
        }

        public ActionResult Prices() {
            return View();
        }

        [HttpGet]
        public ActionResult Logo() {
            var imageBytes =
                        Convert.FromBase64String("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");
            return File(imageBytes, "image/jpeg");
        }

        public ActionResult Test() {
            try {
                Mail mail = new Mail(
                    "smtp.office365.com",
                    "portalfornecedores@cec.com.br",
                    "59a@3plmHdmIq@ao#",
                    true,
                    true,
                    587);

                mail.SendMail("teste", false, "ricardo.sampaio@bluecore.it", "teste");


                return Content("Ok");
            } catch (Exception ex) {
                return Content(ex.InnerException.Message);
            }
            
        }

        public ActionResult Scale() {
            return View();
        }
    }
}
