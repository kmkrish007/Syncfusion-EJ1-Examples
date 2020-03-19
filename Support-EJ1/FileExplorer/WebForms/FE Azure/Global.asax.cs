#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Syncfusion.Licensing;

namespace SyncfusionASPNETApplication9
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
	    //Syncfusion Licensing Register
	    SyncfusionLicenseProvider.RegisterLicense("MDAxQDMxMzYyZTM0MmUzMGhHc3d2djZVQjVUcDFyWHRPTk9nVlM1aFN0SXQ3OG1aRkZybElmUG1IaFk9");
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            System.Web.Http.GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional });
        }
    }
}