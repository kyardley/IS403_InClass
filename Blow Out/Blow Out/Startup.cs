using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blow_Out.Startup))]
namespace Blow_Out
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
