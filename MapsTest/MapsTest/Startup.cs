using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapsTest.Startup))]
namespace MapsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
