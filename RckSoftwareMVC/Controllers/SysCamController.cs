using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class SysCamController : Controller
    {
        //
        // GET: /SysCam/

        public ActionResult Index(
             string method = "",
             string authenticate = "",
             string camera = "",
             string date = "",
             string lastdate = "",
             string count = "",
             string code = "")
        {
            lib.Class.JSON json = new lib.Class.JSON();

            if (method == "send_image")
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                int idx = 0;
                while (true)
                {
                    string field = string.Format("image{0}", idx);
                    if (Request[field] == null)
                    {
                        break;
                    }

                    sb.Append(Request[field]);
                    idx++;
                }
                //return Content(json.Serialize(send_image(sb.ToString(), camera, authenticate)), "application/json");
                send_image(sb.ToString(), camera, authenticate);
                return Content("sucessfully", "application/json");
            }

            if (method == "delete_image")
            {
                return Content(json.Serialize(delete_image(date, authenticate)), "application/json");
            }

            if (method == "count_frames")
            {
                return Content(json.Serialize(count_frames(camera, authenticate)), "application/json");
            }

            if (method == "list_image")
            {
                return Content(json.Serialize(list_image(lastdate, count, code, camera, authenticate)), "application/json");
            }

            if (method == "list_date")
            {
                return Content(json.Serialize(list_date(count, authenticate)), "application/json");
            }

            if (method == "list_cameras")
            {
                return Content(json.Serialize(list_cameras(authenticate)), "application/json");
            }

            if (method == "last_image")
            {
                return Content(json.Serialize(last_image(authenticate)), "application/json");
            }

            return Admin();
        }



        public async void send_image(string image, string camera, string authenticate)
        {
            RckSoftwareMVC.Models.SysCam.DataImage data = new Models.SysCam.DataImage();
            data.image = image;
            data.camera = camera;
            data.date = DateTime.Now.ToString("yyyy-MM-dd");
            data.Save();
        }

        public string delete_image(string date, string authenticate)
        {
            RckSoftwareMVC.Models.SysCam.DataImage.Delete(date);
            return "";
        }

        public int count_frames(string camera, string authenticate)
        {
            return RckSoftwareMVC.Models.SysCam.DataImage.Count(new { camera }); //Images.Count(q => q.camera == camera);
        }

        public RckSoftwareMVC.Models.SysCam.DataImage[] list_image(string lastdate, string count, string code, string camera, string authenticate)
        {
            return RckSoftwareMVC.Models.SysCam.DataImage.List(lastdate, camera, Convert.ToInt32(code), Convert.ToInt32(count)).ToArray();
        }

        public string[] list_date(string count, string authenticate)
        {
            return RckSoftwareMVC.Models.SysCam.DataImage.GroupData(Convert.ToInt32(count));// Images.GroupBy(q => q.date).Select(q => q.Key).OrderByDescending(q => q).Take(Convert.ToInt32(count)).ToArray();
        }

        public string[] list_cameras(string authenticate)
        {
            return RckSoftwareMVC.Models.SysCam.DataImage.GroupCamera();  //Images.Select(q => q.camera).ToArray();
        }

        public string last_image(string authenticate)
        {
            return RckSoftwareMVC.Models.SysCam.DataImage.Last().image; //Images.LastOrDefault()?.image;
        }

        /*************************************************************/

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string Login, string Senha)
        {
            Session["SysCam"] = lib.Class.Encryption.getSHA1Bytes(Login) + "_" +
                  lib.Class.Encryption.getSHA1Bytes(Senha);

            return RedirectToAction("Admin");
        }

        public ActionResult Admin() {
            if (Session["SysCam"] == null)
            {
                return Login();
            }

            return View("Admin");
        }

        public ActionResult ListaDatas(string data) {
            string[] list = list_date("100", "");
            ViewBag.data = data;
            return View(list);
        }

        public ActionResult ListaCameras()
        {
            string[] list = list_cameras("");
            if (Session["SysCam_CameraSelecionada"] == null && list.Length > 0)
            {
                Session["SysCam_CameraSelecionada"] = list[0];
            }
            return View(list);
        }

        public ActionResult ExibeImagens(string data) {
            string key = Session["SysCam"].ToString();
            string camera = Session["SysCam_CameraSelecionada"].ToString();

            lib.Class.Encryption enc = new lib.Class.Encryption(key, "/9j4AQSkZJRgBEYD2wOxIPXFhHzMc8tLyUTldvWob3pm+naVfCG1K0iN6qe5r7us=" + '\n');
            RckSoftwareMVC.Models.SysCam.DataImage[] list = list_image(data, "100", "0", camera, "");
            foreach (var item in list)
            {
                item.image = enc.descrypt(item.image.Replace(" ", "+"));
            }
            return View(list);
        }

    }
}
