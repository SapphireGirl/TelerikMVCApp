using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TelerikMvcApp.Startup))]
namespace TelerikMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}