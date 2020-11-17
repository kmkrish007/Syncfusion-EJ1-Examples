using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Syncfusion_ASP.NET_Web_Site.Startup))]
namespace Syncfusion_ASP.NET_Web_Site
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
