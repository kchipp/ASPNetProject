using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNetProject.Startup))]
namespace ASPNetProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
