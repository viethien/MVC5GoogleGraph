using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Graphs.Startup))]
namespace Graphs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
