using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Daterbase2._0.Startup))]
namespace Daterbase2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
