using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1mvc.Startup))]
namespace _1mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
