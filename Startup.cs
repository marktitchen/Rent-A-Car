using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rent_A_Car.Startup))]
namespace Rent_A_Car
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
