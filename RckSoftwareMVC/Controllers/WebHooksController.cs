using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class WebHooksController : ApiController
    {
        //
        // GET: /WebHooks/

        public static System.Runtime.Caching.ObjectCache Cache { get { return System.Runtime.Caching.MemoryCache.Default; } }

        [System.Web.Http.HttpGet]
        public string get()
        {
            if (Cache["mem.content"] != null)
            {
                return Cache["mem.content"].ToString();
            }
            else {
                return "Cache is empty";
            }            
        }

        [System.Web.Http.HttpPost, System.Web.Http.HttpGet]
        public async Task<string> Invoke(string res) {
            var bytes = await Request.Content.ReadAsByteArrayAsync();
            Cache["mem.content"] = System.Text.Encoding.Default.GetString(bytes);
            return res;
        }

        /*private string GetLog()
        {
            string xlog = Newtonsoft.Json.JsonConvert.SerializeObject(Request);

            xlog += "<h3>ServerVariables</h3>";
            foreach (var item in Request.ServerVariables)
            { xlog += "[" + item.ToString() + "]=" + Request[item.ToString()] + " <br /> "; }

            xlog += "<h3>QueryString</h3>";
            foreach (var item in Request.QueryString)
            { xlog += "[" + item.ToString() + "]=" + Request.QueryString[item.ToString()] + " <br /> "; }

            xlog += "<h3>Form</h3>";
            foreach (var item in Request.Form)
            { xlog += "[" + item.ToString() + "]=" + Request.Form[item.ToString()] + " <br /> "; }

            xlog += "Now: " + DateTime.Now + " <br />Utc: " + DateTime.UtcNow;

            return xlog;
        }*/

    }
}
