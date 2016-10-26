using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CleTechTutor.Startup))]
namespace CleTechTutor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
