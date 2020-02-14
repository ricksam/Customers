using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.Url.Scheme.ToUpper() == "HTTP") {
                if (Request.Url.Host.ToUpper() != "LOCALHOST")
                {
                    string link = string.Format("{0}://{1}", "https", Request.Url.Host);
                    Response.Redirect(link);
                }
            }
            //Models.
            return View();
        }

        public ActionResult Cam()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidaUsuario(string codigo)
        {
            Models.Colaboradores model = Models.Colaboradores.FirstOrDefault(new { Senha = codigo });
            return Json(model == null || string.IsNullOrEmpty(model.Nome) ? "" : model.Nome);
        }

        [HttpPost]
        public ActionResult Gravar(string Latitude, string Longitude, string Codigo, string Foto)
        {
            try
            {
                Foto = Foto.Replace("data:image/png;base64,", "").Replace("data:image/jpeg;base64,", "");
                System.Drawing.Image image = lib.Class.ProcessImage.StringToImage(Foto);
                image = RotateImage(image);

                int perc = (240 + 320) * 100 / (image.Width + image.Height);
                image = lib.Class.ProcessImage.ResizeImage(image, perc);

                lib.Class.Conversion cnv = new lib.Class.Conversion();

                Models.Fotos foto = new Models.Fotos();
                foto.Data = SysPoint.Helper.Utility.BrazilianDatetimeNow();
                foto.Foto = lib.Class.ProcessImage.ImageToString(image);
                foto.Save();

                Models.RegistroPonto reg = new Models.RegistroPonto();
                reg.Id_Colaborador = Models.Colaboradores.FirstOrDefault(new { Senha = Codigo }).Id;
                reg.Id_Foto = foto.Id;
                reg.Registro = SysPoint.Helper.Utility.BrazilianDatetimeNow();
                reg.Latitude = cnv.ToDouble(Latitude.Replace(".", ","));
                reg.Longitude = cnv.ToDouble(Longitude.Replace(".", ","));
                reg.Log = "Lat:" + Latitude + "Long:" + Longitude;
                reg.Save();

                return Content(lib.Class.ProcessImage.ImageToString(image));
            }
            catch (Exception ex){
                
                return Content(Foto);
            }
        }

        public System.Drawing.Image RotateImage(System.Drawing.Image img)
        {
            var bmp = new System.Drawing.Bitmap(img);

            using (System.Drawing.Graphics gfx = System.Drawing.Graphics.FromImage(bmp))
            {
                gfx.Clear(System.Drawing.Color.White);
                gfx.DrawImage(img, 0, 0, img.Width, img.Height);
            }

            bmp.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
            return bmp;
        }

        [HttpPost]
        public ActionResult Error(int id = 0)
        {
            return View(SysPoint.Models.LogError.Where(new { Id = id }).FirstOrDefault());
        }


    }
}