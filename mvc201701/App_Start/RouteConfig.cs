using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc201701
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            // constraints: new { id = @"\d+" }

            //routes.MapMvcAttributeRoutes();
            //// Meget simpel men effektiv route

            ////    routes.MapRoute(
            ////    name: "S1",
            ////    url: "{action}",
            ////    defaults: new { controller = "Home", action = "Index" }
            ////);

            //routes.MapRoute(
            //    name: "Salg",
            //    url: "salg/kunder/{aar}/{mdr}",
            //    defaults: new { controller = "salg", action = "Index" }
            //);
        }
    }
}
