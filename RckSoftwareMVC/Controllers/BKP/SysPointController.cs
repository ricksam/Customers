using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class SysPointController : Controller
    {
        //
        // GET: /SysPoint/

        public ActionResult Index()
        {
            //Models.
            return View();
        }

        public ActionResult Cam() {
            return View();
        }

        public ActionResult Test() {
            return View();
        }

        [HttpPost]
        public ActionResult Gravar(string Latitude, string Longitude, string Codigo, string Foto) 
        {
            try
            {
                Foto = Foto.Replace("data:image/png;base64,", "").Replace("data:image/jpeg;base64,", "");
                System.Drawing.Image image = lib.Class.ProcessImage.StringToImage(Foto);
                image = RotateImage(image);
                return Content(lib.Class.ProcessImage.ImageToString(image));
            }
            catch { return Content(Foto); }
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

        public ActionResult ListUsuarios() 
        {
            return View();
        }

        public ActionResult EditUsuario(int id = 0) 
        {
            return View();
        }

        public ActionResult RegistroPonto(int id = 0) 
        {
            return View();
        }
    }
}
