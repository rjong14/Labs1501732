using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1.MVCEntity.Startup))]
namespace _1.MVCEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
