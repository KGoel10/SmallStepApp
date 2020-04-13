using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ONE_SMALL_STEP.Startup))]
namespace ONE_SMALL_STEP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
