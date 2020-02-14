using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace FileExplorer_WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
          RouteTable.Routes.MapHttpRoute(
          name: "Action",
          routeTemplate: "fileExplorer/{controller}/{action}/{id}",
          defaults: new { id = System.Web.Http.RouteParameter.Optional }
          );
         
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Request.Headers.AllKeys.Contains("Origin") && Request.HttpMethod == "OPTIONS")
            {
                Response.StatusCode = 200;
                Response.End();
            }
        }
    }
}
