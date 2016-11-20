using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlAccesoMVC.Startup))]
namespace ControlAccesoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
