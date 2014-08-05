using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventCalendar.Startup))]
namespace EventCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
