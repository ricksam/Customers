using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RckSoftwareMVC;

namespace RckSoftwareMVC.Controllers
{
  public class SNKController : Controller
  {
    //
    // GET: /snk/

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

    public ActionResult Index()
    {
      return RedirectToAction("List");
    }

    public ActionResult List()
    {
      return View("List", (new RckSoftwareMVC.dsSOCIAL_NETWORK(GetDatabase())).List());
    }

    public ActionResult Editar(int ID)
    {
      return View((new RckSoftwareMVC.dsSOCIAL_NETWORK(GetDatabase())).Get(ID));
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Editar(RckSoftwareMVC.SOCIAL_NETWORK md)
    {
      (new RckSoftwareMVC.dsSOCIAL_NETWORK(GetDatabase())).Save(md);
      return View(md);
    }

    public ActionResult Remover(int ID)
    {
      (new RckSoftwareMVC.dsSOCIAL_NETWORK(GetDatabase())).Remove(new SOCIAL_NETWORK() { ID = ID });
      return List();
    }

  }
}
