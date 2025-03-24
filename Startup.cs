using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SafariCyber_Inventario.Startup))]
namespace SafariCyber_Inventario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
