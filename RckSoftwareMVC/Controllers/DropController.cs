using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class DropController : Controller
    {
        //
        // GET: /Drop/

        public ActionResult Index()
        {
            /*Helper.AzureHelper azureHelper = new Helper.AzureHelper();
            var Files = azureHelper.List("files");
            return View("Index", Files);*/

            string[] Files = System.IO.Directory.GetFiles(Server.MapPath("~/download"));
            for (int i = 0; i < Files.Length; i++)
            {
                Files[i] = System.IO.Path.GetFileName(Files[i]);
            }
            return View("Index", Files);
        }

        [HttpPost]
        public ActionResult RemoveFile(string file)
        {
            /*Helper.AzureHelper azureHelper = new Helper.AzureHelper();
            await azureHelper.Delete("files", file);*/
            
            string[] Files = System.IO.Directory.GetFiles(Server.MapPath("~/download"));
            foreach (var item in Files)
            {
                if (System.IO.Path.GetFileName(item) == file)
                {
                    System.IO.File.Delete(item);
                }
            }
            return Content("ok");
        }

        public ActionResult AddFile(System.Web.HttpPostedFileBase file)
        {
            //Helper.AzureHelper azureHelper = new Helper.AzureHelper();
            //await azureHelper.Upload("files", file.FileName, true, file.InputStream);
            string dir = Server.MapPath("~/download");
            string filename = file.FileName;
            string PathFull = string.Format("{0}\\{1}", dir, filename);
            file.SaveAs(PathFull);
            return RedirectToAction("Index", "Drop");
        }

    }
}
