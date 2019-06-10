using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson5_EF.Startup))]
namespace Lesson5_EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
