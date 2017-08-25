using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AM.FamillyGallery.Startup))]
namespace AM.FamillyGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
