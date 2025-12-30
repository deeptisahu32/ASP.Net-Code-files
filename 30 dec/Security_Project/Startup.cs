using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Security_Project.Startup))]
namespace Security_Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
