using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AshEbook.Startup))]
namespace AshEbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
