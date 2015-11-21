using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3.AzureSauna.Startup))]
namespace _3.AzureSauna
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
