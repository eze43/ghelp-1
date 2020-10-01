using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GHelp.Startup))]
namespace GHelp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
