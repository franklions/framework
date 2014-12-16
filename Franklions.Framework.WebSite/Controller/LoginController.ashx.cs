using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Franklions.Framework.WebSite.Controller
{
    /// <summary>
    /// Summary description for LoginController
    /// </summary>
    public class LoginController : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string action = context.Request.QueryString["action"];
            switch (action.ToLower())
            { 
                case"login":
                    LoginAction(context);
                    break;
                    
            }

            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        private void LoginAction(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Redirect("../admin/member.html");
        }

       

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}