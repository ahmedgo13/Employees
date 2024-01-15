using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employees_Portal.Startup))]
namespace Employees_Portal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
