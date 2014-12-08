using Microsoft.Owin;
using Owin;
using Test_Web_Client;

[assembly: OwinStartup(typeof (Startup))]

namespace Test_Web_Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}