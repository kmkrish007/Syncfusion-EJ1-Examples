using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServerOperations.Startup))]
namespace ServerOperations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
