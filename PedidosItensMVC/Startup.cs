using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PedidosItensMVC.Startup))]
namespace PedidosItensMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
