using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FantasyBasketball.Startup))]
namespace FantasyBasketball
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
