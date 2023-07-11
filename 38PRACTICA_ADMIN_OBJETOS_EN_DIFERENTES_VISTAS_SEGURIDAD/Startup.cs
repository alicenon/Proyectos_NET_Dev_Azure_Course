using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_38PRACTICA_ADMIN_OBJETOS_EN_DIFERENTES_VISTAS_SEGURIDAD.Startup))]
namespace _38PRACTICA_ADMIN_OBJETOS_EN_DIFERENTES_VISTAS_SEGURIDAD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
