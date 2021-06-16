using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zoomer.Startup))]
namespace Zoomer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
