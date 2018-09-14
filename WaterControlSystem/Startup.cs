using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WaterControlSystem.Startup))]
namespace WaterControlSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
