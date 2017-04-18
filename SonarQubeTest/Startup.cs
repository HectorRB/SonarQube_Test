using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SonarQubeTest.Startup))]
namespace SonarQubeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
