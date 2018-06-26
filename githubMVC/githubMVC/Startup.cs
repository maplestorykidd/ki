using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubMVC.Startup))]
namespace githubMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
