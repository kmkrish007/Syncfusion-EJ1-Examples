using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyncfusionMvcApplication3.Startup))]
namespace SyncfusionMvcApplication3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
