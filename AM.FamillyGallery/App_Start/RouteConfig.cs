using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AM.FamillyGallery
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //to ignore such requests..
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("cuisine", "cuisine/{name}", new { Controller = "Cuisine", Action = "Search", name = "" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
