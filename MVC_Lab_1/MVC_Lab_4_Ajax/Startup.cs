using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Lab_4_Ajax.Startup))]
namespace MVC_Lab_4_Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
