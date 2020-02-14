using System;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    [Helper.AuthorizeUser]
    public class ColaboradoresController : BaseController
    {
        // GET: Colaboradores
        public ActionResult Index()
        {
            return View("Index", Models.Colaboradores.List());
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            return View("Edit", Models.Colaboradores.Find(id) ?? new Models.Colaboradores());
        }

        [HttpGet]
        public ActionResult EditPreview(Models.Colaboradores colaboradores)
        {
            return View("Edit", colaboradores);
        }

        [HttpPost]
        public ActionResult Edit(Models.Colaboradores colaboradores)
        {
            try
            {
                if (colaboradores.Id_Empresa == 0)
                {
                    throw new Exception("O campo empresa é obrigatório!");
                }

                if (colaboradores.Id_Supervisor == 0)
                {
                    throw new Exception("O campo supervisor é obrigatório!");
                }

                colaboradores.Save();
                return Index();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return EditPreview(colaboradores);
            }
        }
    }
}