using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Helper
{
    public class AuthorizeUser : AuthorizeAttribute
    {
        bool AllowAnonymous = false;
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var actionDescriptor = httpContext.Items["ActionDescriptor"] as ActionDescriptor;
            if (actionDescriptor != null)
            {
                AuthorizeUser attribute = GetAuthorizePublicAttribute(actionDescriptor);
                if (attribute.AllowAnonymous)
                    return true;
            }


            if (!Helper.AppContext.UsuarioLogado)
            {
                httpContext.Response.Redirect("/Login/Index");
                return false;
            }
            return true;
        }

        private AuthorizeUser GetAuthorizePublicAttribute(ActionDescriptor actionDescriptor)
        {
            AuthorizeUser result = null;

            // Check if the attribute exists on the action method
            result = (AuthorizeUser)actionDescriptor
                .GetCustomAttributes(attributeType: typeof(AuthorizeUser), inherit: true)
                .SingleOrDefault();

            if (result != null)
            {
                return result;
            }

            // Check if the attribute exists on the controller
            result = (AuthorizeUser)actionDescriptor
                .ControllerDescriptor
                .GetCustomAttributes(attributeType: typeof(AuthorizeUser), inherit: true)
                .SingleOrDefault();

            return result;
        }
    }
}