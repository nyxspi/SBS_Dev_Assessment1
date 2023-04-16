using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SBS_2page_webApp.StartupOwin))]

namespace SBS_2page_webApp
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
