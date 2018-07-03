using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcGame.Startup))]
namespace MvcGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
