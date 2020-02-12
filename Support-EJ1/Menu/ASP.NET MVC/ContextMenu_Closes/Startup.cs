using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample145862.Startup))]
namespace Sample145862
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
