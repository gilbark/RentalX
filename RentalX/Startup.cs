using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalX.Startup))]
namespace RentalX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
