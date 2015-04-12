using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAzureCloudApp.Startup))]
namespace MyAzureCloudApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
