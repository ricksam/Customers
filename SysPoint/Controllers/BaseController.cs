using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            var Exception = filterContext.Exception;
            //var ActionName = filterContext.RouteData.Values["action"].ToString();
            //var ControllerName = filterContext.RouteData.Values["controller"].ToString();

            var e = this.RouteData.Values;
            string controllerName = (string)e["controller"];
            string actionName = (string)e["action"];

            string Method = string.Format("/{0}/{1}", controllerName, actionName);

            string parametros = GetParamRequest();

            int Id = SysPoint.Models.LogError.GravaLogErro(Method, parametros, (SysPoint.Helper.AppContext.UsuarioLogado ? SysPoint.Helper.AppContext.Usuario.Id : 0), Exception);

            Response.Clear();
            var sb = new System.Text.StringBuilder();
            sb.Append("<html>");
            sb.AppendFormat("<body onload='document.forms[0].submit()'>");
            sb.AppendFormat("<form action='/Home/Error' method='post'>");

            sb.AppendFormat("<input type='hidden' name='id' value='{0}'>", Id);

            sb.Append("</form>");
            sb.Append("</body>");
            sb.Append("</html>");
            Response.Write(sb.ToString());
            Response.End();

            base.OnException(filterContext);
        }

        public string GetMethodRequest()
        {
            return SysPoint.Helper.Utility.Request.Url.AbsoluteUri;
        }

        public string GetParamRequest()
        {
            string parametros = "";

            foreach (var item in System.Web.HttpContext.Current.Request.QueryString.AllKeys)
            { parametros += string.Format("&{0}={1}", item, this.HttpContext.Request[item]); }


            foreach (var item in this.HttpContext.Request.Form.AllKeys)
            { parametros += string.Format("&{0}={1}", item, this.HttpContext.Request.Form[item]); }

            return parametros;
        }

        public void SetMessageInfo(string message)
        {
            ViewBag.message_info = message;
        }

        public void SetMessageSuccess(string message)
        {
            ViewBag.message_success = message;
        }

        public void SetMessageError(string message)
        {
            ViewBag.message_error = message;
        }

        public void TrataErro(Exception ex)
        {
            try
            {
                SetMessageError(ex.Message);
                /*if (ex is Bokaboka.Domain.ExceptionDomain)
                {
                    SetMessageError(ex.Message);
                }
                else
                {
                    // Grava Log
                    Bokaboka.Domain.ExceptionDomain.GravaLogErro(
                        GetMethodRequest(),
                        GetParamRequest(),
                        ex);

                    SetMessageError(KeepAlive.Helper.AppContext.ERRO_PADRAO);
                }*/
            }
            catch
            {

            }
        }
    }
}