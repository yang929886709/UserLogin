using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserLogin.Startup))]
namespace UserLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
