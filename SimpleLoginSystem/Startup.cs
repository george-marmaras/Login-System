using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleLoginSystem.Startup))]
namespace SimpleLoginSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
