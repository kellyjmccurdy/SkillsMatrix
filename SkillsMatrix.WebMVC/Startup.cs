using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkillsMatrix.WebMVC.Startup))]
namespace SkillsMatrix.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
