using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace RckSoftwareMVC.Controllers
{
    [CompressFilter]
    public class RckController : Controller
    {
        //
        // GET: /Rck/
        public static System.Runtime.Caching.ObjectCache Cache { get { return System.Runtime.Caching.MemoryCache.Default; } }

        private lib.Entity.MySQL GetDatabase()
        {
            string ConnectionString =
                string.Format(
                  "Server={0};Database={1};Uid={2};Pwd={3};",
                  new object[]
                  {
              "187.45.196.220",
              "rcksoftware",
              "rcksoftware",
              "RCK6px2erjr"
                  }
                );
            return new lib.Entity.MySQL(ConnectionString);
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nome, string email, string fone, string mensagem)
        {
            if (!string.IsNullOrEmpty(nome) 
                && !string.IsNullOrEmpty(email) 
                && !string.IsNullOrEmpty(fone) 
                && !string.IsNullOrEmpty(mensagem)
                && IsEmail(email)
                && IsPhone(fone))
            {
                lib.Class.WebUtils.GetWebResponse("https://docs.google.com/forms/u/0/d/e/1FAIpQLSftcNvxNsOIg0rY-E6cDUq3I44PRxOgYA6G-rr5VI4rPNh2BQ/formResponse",
                  string.Format(
                  "entry.190167070={0}&entry.380772653={1}&entry.51949988={2}&entry.1170329346={3}",
                  nome, email, fone, mensagem
                  ));
            }

            ViewBag.success = "success";
            return View();
        }

        private bool IsEmail(string text) {
            return (text.Contains("@") && text.Contains("."));
        }

        private bool IsPhone(string text)
        {
            return lib.Class.Utils.GetNumbers(text).Length>=8;
        }

        /*[HttpGet]
        public ActionResult ViewCache()
        {
            if (Cache["list"] == null)
            {
                Cache["list"] = new List<CacheItem>();
            }

            string resp = "";
            var items = ((List<CacheItem>)Cache["list"]);
            foreach (var item in items)
            {
                resp += string.Format("{0} - {1}<br />", item.Email, item.Souce);
            }
            return Content(resp);
        }*/

        [HttpGet]
        public ActionResult UrlReferrer()
        {
            return Content((new Helpers.JSON()).Serialize(Request.UrlReferrer));
        }

        public ActionResult TesteEmail()
        {

            if (System.Configuration.ConfigurationManager.AppSettings["EMAIL_SMTP"] != null)
            {
                lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();
                mail.SendMail(string.Format(
                  @"Nome:{0}<br />
              Email:{1}<br />
              Phone:{2}<br />
              Message:{3}<br />", "ricardo", "jricksam@gmail.com", "15996455614", "teste email"), true, "jricksam@gmail.com", "Contato RCK Software");
            }

            return View();
        }

        public ActionResult Ads()
        {
            return View();
        }

        public ActionResult EnviaKeepAlive(string id)
        {
            lib.Entity.MySQL db = GetDatabase();
            dsKPA_KEEP_ALIVE ds = new dsKPA_KEEP_ALIVE(db);

            KPA_KEEP_ALIVE kpa = new KPA_KEEP_ALIVE();
            kpa.KPA_IDENTIFICACAO = id;

            db.DbConnection.Open();
            System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
            try
            {
                ds.Save(kpa, transaction);

                if (kpa.KPA_CODIGO == 0)
                { kpa.KPA_CODIGO = db.ReturnLastID(transaction).ToInt(); }

                transaction.Commit();
            }
            catch
            { transaction.Rollback(); }
            finally
            {
                if (db.DbConnection.State != System.Data.ConnectionState.Closed)
                { db.DbConnection.Close(); }
            }

            return Content(kpa.KPA_CODIGO.ToString());
        }

        public ActionResult TestaConexaoMySQL()
        {
            lib.Entity.MySQL db = new lib.Entity.MySQL("Server=187.45.196.220;Database=rcksoftware;Uid=rcksoftware;Pwd=RCK6px2erjr;");
            return Content(db.GetTables().ToString());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Arquivo(string a = "", string type = "", string filename = "")
        {
            a = a.Replace("[", "<");
            a = a.Replace("]", ">");
            a = a.Replace("href", "");

            string attachment = "attachment; filename=" + filename;
            string contentType = "application/ms-excel";
            System.Text.Encoding contentEncoding = System.Text.Encoding.Default;

            if (type == "doc")
            {
                contentType = "application/msword";
                contentEncoding = System.Text.Encoding.UTF8;
            }

            Response.ClearContent();
            Response.AddHeader("content-disposition", attachment);
            Response.ContentType = contentType;
            Response.ContentEncoding = contentEncoding;
            Response.Write(a);
            Response.End();

            /*if (System.Configuration.ConfigurationManager.AppSettings["EMAIL_SMTP"] != null)
            {
                string decoded = System.Text.Encoding.UTF8.GetString(GetBytes(a));
                System.IO.MemoryStream ms = new System.IO.MemoryStream(GetBytes(decoded));

                List<Attachment> list = new List<Attachment>();
                list.Add(new Attachment(ms, "report.doc"));

                lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();
                mail.SendMailA("DOC", true, "jricksam@gmail.com", "Contato RCK Software",null, null, list);
            }*/

            return Content("");
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }

    /*public class CacheItem
    {
        public string Email { get; set; }
        public string Souce { get; set; }
    }*/
}
