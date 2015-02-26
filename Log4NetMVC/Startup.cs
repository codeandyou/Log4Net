using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Log4NetMVC.Startup))]
namespace Log4NetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
