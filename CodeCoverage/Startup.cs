using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeCoverage.Startup))]
namespace CodeCoverage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
