using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2.MetropoliaDbFirst.Startup))]
namespace _2.MetropoliaDbFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
