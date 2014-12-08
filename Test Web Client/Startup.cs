using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Web_Client.Startup))]
namespace Test_Web_Client
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
