using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularCorners.Startup))]
namespace AngularCorners
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
