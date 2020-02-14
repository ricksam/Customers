using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RckDatabase;
using System.Net.Mail;
using System.Net;

namespace RckSoftwareMVC.Controllers
{
    public class SISController : Controller
    {
        private lib.Entity.MySQL GetDatabase()
        {
            return new lib.Entity.MySQL(System.Configuration.ConfigurationManager.ConnectionStrings["RCKConnection"].ToString());
        }

        public ActionResult Index(string id = "")
        {
            dsSIS_VER_VERSAO dsModel = new dsSIS_VER_VERSAO(GetDatabase());
            return View("Index", dsModel.Search(id));
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            dsSIS_VER_VERSAO ds = new dsSIS_VER_VERSAO(GetDatabase());
            SIS_VER_VERSAO ver = ds.Get(id);
            ver.Sistemas = ds.ListSistema();
            ver.URLs = ds.ListURL();
            return View(ver);
        }

        [HttpGet]
        public ActionResult Report(int min = 0, int max = 0)
        {
            return View((new dsSIS_VER_VERSAO(GetDatabase())).List_Range(min, max));
            //return View((new dsSIS_VER_VERSAO(GetDatabase())).Get(id));
        }

        [HttpPost]
        public ActionResult Edit(RckDatabase.SIS_VER_VERSAO Model)
        {
            dsSIS_VER_VERSAO dsModel = new dsSIS_VER_VERSAO(GetDatabase());
            dsModel.Save(Model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Remove(int id = 0)
        {
            dsSIS_VER_VERSAO dsModel = new dsSIS_VER_VERSAO(GetDatabase());
            dsModel.Remove(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ViewReport(int id = 0)
        {
            Microsoft.Reporting.WebForms.ReportViewer rv = new Microsoft.Reporting.WebForms.ReportViewer();
            rv.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            rv.LocalReport.ReportEmbeddedResource = "RckSoftwareMVC.RPT.Hubert.rdlc";

            List<Microsoft.Reporting.WebForms.ReportParameter> pl = new List<Microsoft.Reporting.WebForms.ReportParameter>();
            pl.Add(new Microsoft.Reporting.WebForms.ReportParameter("VER_SISTEMA", "Portal Hubert"));

            rv.LocalReport.SetParameters(pl);

            Microsoft.Reporting.WebForms.Warning[] warnings;
            string[] streams;
            string mimeType;
            string encoding;
            string extension;

            byte[] array = rv.LocalReport.Render(
            "Pdf", null, out mimeType, out encoding,
            out extension, out streams, out warnings);

            //Response.ContentType = "application/vnd.ms-excel";
            Response.ContentType = "application/pdf";
            Response.OutputStream.Write(array, 0, array.Length);

            return View();
        }

        public lib.Class.Mail GetSmtp()
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            lib.Class.Mail mail = new lib.Class.Mail(
                "smtp.gmail.com",
                "framework@bluecore.it",
                "bluecore1357",
                true,
                true,
                587);

            //mail.ReplayTo = "framework@bluecore.it";
            return mail;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SendFileToEmail(System.Web.HttpPostedFileBase file, string email)
        {
            if (file != null && file.InputStream != null)
            {
                List<Attachment> list = new List<Attachment>();
                list.Add(new Attachment(file.InputStream, file.FileName));

                lib.Class.Mail mail = GetSmtp();
                mail.SendMailA("Doc Em Anexo", true, email, "Liberação de Sistema", new string[] { "ricardo.sampaio@bluecore.it" }, null, list);

                ViewBag.message_success = "arquivo enviado com sucesso";
                return Index("");
            }

            ViewBag.message_error = "arquivo não enviado";
            return Index("");
        }
    }
}
