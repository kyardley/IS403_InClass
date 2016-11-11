using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsRUs.Startup))]
namespace CarsRUs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
