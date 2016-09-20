using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrioWebApp.Startup))]
namespace TrioWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
