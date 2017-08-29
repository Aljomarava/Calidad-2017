using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen.Mvc5.Startup))]
namespace Examen.Mvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
