using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSimpleBlog.Startup))]
namespace MvcSimpleBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
