using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WoopCart.Web.Startup))]
namespace WoopCart.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
