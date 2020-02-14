using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    [Helper.AuthorizeUser]
    public class RegistroPontoController : BaseController
    {
        // GET: Registros
        public ActionResult Index(string Data = "", string Local = "", string Colaborador = "")
        {
            ViewBag.Data = Data;
            ViewBag.Local = Local;
            ViewBag.Colaborador = Colaborador;
            return View("Index", Models.RegistroPonto.List(Data, Local, Colaborador));
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            return View(Models.RegistroPonto.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Models.RegistroPonto model)
        {
            model.Save();
            return Index();
        }

        public ActionResult Data(string id ="", string name ="", string selected = "", string onchange = "")
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewBag.selected = selected;
            ViewBag.onchange = onchange;
            return View("Combo", Models.RegistroPonto.ListDatas());
        }

        public ActionResult Local(string id = "", string name = "", string selected = "", string onchange = "")
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewBag.selected = selected;
            ViewBag.onchange = onchange;
            return View("Combo", new List<string>());
        }

        public ActionResult Colaborador(string id = "", string name = "", string selected = "", string onchange = "")
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewBag.selected = selected;
            ViewBag.onchange = onchange;
            return View("Combo", Models.RegistroPonto.ListColaboradores());
        }

        public ActionResult Map()
        {
            return View(Models.RegistroPonto.ListCoordenadas(Helper.Utility.BrazilianDatetimeNow()));
        }
    }
}