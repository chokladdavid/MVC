using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Lab_2_Grupp_3.Startup))]
namespace MVC_Lab_2_Grupp_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
