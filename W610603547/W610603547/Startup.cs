using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W610603547.Startup))]
namespace W610603547
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
