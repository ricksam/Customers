using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    public class SysPointController : Controller
    {
        // GET: SysPoint
        public ActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }
    }
}