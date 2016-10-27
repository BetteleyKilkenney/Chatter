using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterMVCApp.Startup))]
namespace ChatterMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
