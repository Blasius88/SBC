using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBC.Startup))]
namespace SBC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
