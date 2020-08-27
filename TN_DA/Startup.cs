using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TN_DA.Startup))]
namespace TN_DA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
