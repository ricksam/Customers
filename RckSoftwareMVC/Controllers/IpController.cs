using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class IpController : Controller
    {
        //
        // GET: /Ip/

        public ActionResult Index()
        {
            ViewBag.ip = GetIpValue();
            ViewBag.log = GetLog();
            return View();
        }

        private string GetIpValue()
        {
            string ipAdd = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ipAdd))
            {
                ipAdd = Request.ServerVariables["REMOTE_ADDR"];
            }

            return ipAdd;
        }

        private string GetLog() {
            string xlog = "";
            foreach (var item in Request.ServerVariables)
            { xlog += "[" + item.ToString() + "]=" + Request[item.ToString()] + " <br /> "; }
            //ViewBag.html = xlog;
            xlog += "Now: " + DateTime.Now + " <br />Utc: " + DateTime.UtcNow;
            return xlog;
        }

        public ActionResult MySql() {
            System.Data.IDbConnection _conn = new MySql.Data.MySqlClient.MySqlConnection("Server=18.229.3.93;Database=gem;Uid=admin;Pwd=RCK6px2erjr;");
            _conn.Open();
            _conn.Close();
            return Content(_conn.State.ToString());
        }
    }
}
