using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JazzyGrandCircus.Startup))]
namespace JazzyGrandCircus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
