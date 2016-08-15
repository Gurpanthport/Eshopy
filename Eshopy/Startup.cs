using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eshopy.Startup))]
namespace Eshopy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
