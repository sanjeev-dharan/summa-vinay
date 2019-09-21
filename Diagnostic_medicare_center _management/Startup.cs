using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diagnostic_medicare_center__management.Startup))]
namespace Diagnostic_medicare_center__management
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
