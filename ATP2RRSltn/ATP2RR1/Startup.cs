using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATP2RR1.Startup))]
namespace ATP2RR1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
