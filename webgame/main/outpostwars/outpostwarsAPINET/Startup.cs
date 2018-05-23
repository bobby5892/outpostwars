using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(outpostwarsAPINET.Startup))]
namespace outpostwarsAPINET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
