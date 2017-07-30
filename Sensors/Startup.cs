using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sensors.Startup))]
namespace Sensors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
