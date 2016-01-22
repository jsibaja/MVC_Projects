using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeProMVC.Startup))]
namespace PrimeProMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
