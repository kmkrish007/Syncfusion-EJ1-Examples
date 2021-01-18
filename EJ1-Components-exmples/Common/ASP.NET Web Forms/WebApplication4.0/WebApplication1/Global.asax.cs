using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;


namespace WebApplication1
{
    public class Global : HttpApplication
    {
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            if (Request.Path.IndexOf(".aspx") != -1) // if the url contains .asmx extention
            {

                SendRequestWithSimpleURL(Context);

                return;
            }
            else
            {


                
            }

        }

        private static void SendRequestWithSimpleURL(HttpContext context)
        {

            int asmx = context.Request.Path.IndexOf(".aspx");
            string path = context.Request.Path.Substring(0, asmx + 5);

            string pathInfo = context.Request.Path.Substring(asmx + 5);
            context.RewritePath(path, pathInfo, context.Request.Url.Query);

        }
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);            

        }
        public static class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                var settings = new FriendlyUrlSettings();
                settings.AutoRedirectMode = RedirectMode.Off;
                routes.EnableFriendlyUrls(settings);
            }
        }
    }
}
