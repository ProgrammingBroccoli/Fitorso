using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fitorso.Startup))]
namespace Fitorso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
