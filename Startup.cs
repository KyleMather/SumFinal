using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumFinal.Startup))]
namespace SumFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
