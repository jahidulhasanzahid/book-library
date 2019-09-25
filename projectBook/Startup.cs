using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projectBook.Startup))]
namespace projectBook
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
