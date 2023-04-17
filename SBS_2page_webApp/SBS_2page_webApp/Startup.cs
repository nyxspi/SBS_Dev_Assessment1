using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;

[assembly: OwinStartup(typeof(SBS_2page_webApp.StartupOwin))]

namespace SBS_2page_webApp
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            // Enable cookie authentication middleware
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                LogoutPath = new PathString("/Account/Logout"),
                ExpireTimeSpan = TimeSpan.FromMinutes(30),
            });
        }

    }

}

