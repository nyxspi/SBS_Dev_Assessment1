using System.Web.Mvc;
using System.Web.Routing;

namespace SBS_2page_webApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "Login/Index",
                defaults: new { controller = "Login", action = "Index" }
            );

            routes.MapRoute(
                name: "LoginPost",
                url: "Login/Login",
                defaults: new { controller = "Login", action = "Login" }
            );

            routes.MapRoute(
                name: "Info",
                url: "Info/Index",
                defaults: new { controller = "Info", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
