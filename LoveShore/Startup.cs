using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoveShore.Startup))]
namespace LoveShore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
