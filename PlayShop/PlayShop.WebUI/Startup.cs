using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayShop.WebUI.Startup))]
namespace PlayShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
