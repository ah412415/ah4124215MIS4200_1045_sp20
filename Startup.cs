using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ah4124215MIS4200_1045_sp20.Startup))]
namespace ah4124215MIS4200_1045_sp20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
