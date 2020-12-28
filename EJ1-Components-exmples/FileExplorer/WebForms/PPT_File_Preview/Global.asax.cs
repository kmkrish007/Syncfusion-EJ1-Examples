using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Routing;

namespace ComboBox
{
    //public class Global : HttpApplication
    //{
    //    //void Application_Start(object sender, EventArgs e)
    //    //{
    //    //    // Code that runs on application startup
    //    //    RouteConfig.RegisterRoutes(RouteTable.Routes);
    //    //    BundleConfig.RegisterBundles(BundleTable.Bundles);
    //    //}

    //}
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            System.Web.Http.GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional });
        }
    }
}