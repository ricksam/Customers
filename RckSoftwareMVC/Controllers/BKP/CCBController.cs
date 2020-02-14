using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
  public class CCBController : Controller
  {
    //
    // GET: /CCB/

    public ActionResult Index()
    {
      return View("Index");
    }

    public ActionResult Inicio()
    {
      return Index();
    }

    public ActionResult Sobre()
    {
      return View("Sobre");
    }

    public ActionResult Hinos()
    {
      return View("Hinos");
    }

    public ActionResult Aplicativos()
    {
      return View("Aplicativos");
    }

    [HttpGet]
    public ActionResult Contato()
    {
      return View("Contato");
    }

    [HttpPost]
    public ActionResult Contato(string nome, string comum, string email, string fone, string mensagem)
    {
      try
      {
        if (System.Configuration.ConfigurationManager.AppSettings["EMAIL_SMTP"] != null)
        {
          lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();
          mail.SendMail(string.Format(
            @"Nome:{0}<br />
              Comum:{1}<br />
              Email:{2}<br />
              Phone:{3}<br />
              Message:{4}<br />", nome, comum, email, fone, mensagem), true, "jricksam@gmail.com", "Contato RCK Software");
        }
      }
      catch { }

      lib.Class.WebUtils.GetWebResponse("https://docs.google.com/forms/d/1aQPKhjtoO5HU03yXKpvilJW_i5Y8yufg0iwqmOp9lPE/formResponse",
        string.Format(
        "entry.846015168={0}&entry.624286691={1}&entry.1586893303={2}&entry.1849223306={3}&entry.13667275={4}",
        nome, comum, email, fone, mensagem
        ));
      ViewBag.success = "success";
      return View("Contato");
    }

    public ActionResult Coro03()
    {
      return View();
    }

    public ActionResult Hino106()
    {
      return View();
    }

    public ActionResult Hino120()
    {
      return View();
    }

    public ActionResult Hino208()
    {
      return View();
    }

    public ActionResult Hino321()
    {
      return View();
    }

    public ActionResult Hino341()
    {
      return View();
    }

    public ActionResult Hino424()
    {
      return View();
    }

    public ActionResult Hino454()
    {
      return View();
    }
  }
}
