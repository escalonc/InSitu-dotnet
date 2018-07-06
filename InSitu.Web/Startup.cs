using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InSitu.Web.Startup))]
namespace InSitu.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
