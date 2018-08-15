using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WWW.Startup))]
namespace WWW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
