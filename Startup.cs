using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(getfitEF.Startup))]
namespace getfitEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
