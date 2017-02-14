using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RWPAPIv2.Startup))]
namespace RWPAPIv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
