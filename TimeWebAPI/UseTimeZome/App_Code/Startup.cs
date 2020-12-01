using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UseTimeZome.Startup))]
namespace UseTimeZome
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
