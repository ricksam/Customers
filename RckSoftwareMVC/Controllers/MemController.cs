using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class MemController : Controller
    {
        //
        // GET: /Mem/

        public static System.Runtime.Caching.ObjectCache Cache { get { return System.Runtime.Caching.MemoryCache.Default; } }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Content = Cache["mem.content"];
            return View("Index");
        }

        [HttpGet]
        public ActionResult Text()
        {
            return Content(Cache["mem.content"].ToString());
        }

        [HttpGet]
        public ActionResult Save() {
            return Index();
        }

        [HttpPost]
        public ActionResult Save(string Content)
        {
            Cache["mem.content"] = Content;
            return RedirectToAction("Index");
        }

    }
}
