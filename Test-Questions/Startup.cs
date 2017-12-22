using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Questions.Startup))]
namespace Test_Questions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
