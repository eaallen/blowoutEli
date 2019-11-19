using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(First_database.Startup))]
namespace First_database
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
