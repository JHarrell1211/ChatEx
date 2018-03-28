using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatEx.Startup))]
namespace ChatEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
