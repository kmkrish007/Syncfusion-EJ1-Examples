#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(drpdwnfor.Startup))]
namespace drpdwnfor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
