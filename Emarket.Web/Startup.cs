using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emarket.Web.Startup))]
namespace Emarket.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
