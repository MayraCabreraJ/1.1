using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pmvc.Startup))]
namespace pmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
