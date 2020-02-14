using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SysPoint.Models;

namespace SysPoint.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View("Index", Supervisor.List());
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            return View(Supervisor.Find(id) ?? new Supervisor());
        }

        [HttpPost]
        public ActionResult Edit(Supervisor model, string NovaSenha)
        {
            if (!string.IsNullOrEmpty(NovaSenha.Trim()))
            { model.Senha = Helper.Utility.md5(NovaSenha); }

            model.Save();
            return Index();
        }

        public ActionResult Combo(string Id, string Name, string SelectedItem)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.DafeultItem = "Selecione";
            ViewBag.SelectedItem = SelectedItem;
            return View(Supervisor.List());
        }
    }
}