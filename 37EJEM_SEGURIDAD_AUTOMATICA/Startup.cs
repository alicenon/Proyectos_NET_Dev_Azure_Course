using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_37EJEM_SEGURIDAD_AUTOMATICA.Startup))]
namespace _37EJEM_SEGURIDAD_AUTOMATICA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
