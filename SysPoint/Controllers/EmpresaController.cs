using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    [Helper.AuthorizeUser]
    public class EmpresaController : BaseController
    {
        // GET: Empresa
        public ActionResult Index()
        {
            return View("Index", Models.Empresa.List());
        }

        public ActionResult Combo(string SelectedItem) {
            ViewBag.Id = "Id_Empresa";
            ViewBag.Name = "Id_Empresa";
            ViewBag.DafeultItem = "Selecione";
            ViewBag.SelectedItem = SelectedItem;
            return View(Models.Empresa.List());
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            return View(Models.Empresa.Find(id) ?? new Models.Empresa());
        }

        [HttpPost]
        public ActionResult Edit(Models.Empresa model)
        {
            model.Save();
            return Index();
        }
    }
}