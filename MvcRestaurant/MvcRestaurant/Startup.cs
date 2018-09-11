using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRestaurant.Startup))]
namespace MvcRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
