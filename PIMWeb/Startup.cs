using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PIMWeb.Startup))]
namespace PIMWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
