using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPCursus.Startup))]
namespace ASPCursus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
