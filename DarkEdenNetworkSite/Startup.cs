using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DarkEdenNetworkSite.Startup))]
namespace DarkEdenNetworkSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
