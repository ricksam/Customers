using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Email, string Senha)
        {
            try
            {
                SysPoint.Models.Supervisor usuario = SysPoint.Models.Supervisor.FirstOrDefault(new { Email });

                if (usuario != null && usuario.Id != 0)
                {
                    if (usuario.Senha == SysPoint.Helper.Utility.md5(Senha))
                    {
                        Helper.AppContext.Usuario = usuario;
                        return RedirectToAction("Index", "RegistroPonto", new { Data = Helper.Utility.BrazilianDatetimeNow().ToString("dd/MM/yyyy") });
                    }
                    else
                    {
                        throw new Exception("Senha inválida!");
                    }
                }
                else
                {
                    throw new Exception("Usuario não cadastrado!");
                }
            }
            catch (Exception ex)
            {
                TrataErro(ex);
            }

            return View();
        }
    }
}