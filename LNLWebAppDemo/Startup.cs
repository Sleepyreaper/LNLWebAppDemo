using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LNLWebAppDemo.Startup))]
namespace LNLWebAppDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
