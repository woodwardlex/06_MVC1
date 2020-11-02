using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroToMVC.UI.MVC.Startup))]
namespace IntroToMVC.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
