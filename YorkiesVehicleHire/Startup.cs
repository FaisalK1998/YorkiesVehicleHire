using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YorkiesVehicleHire.Startup))]
namespace YorkiesVehicleHire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
