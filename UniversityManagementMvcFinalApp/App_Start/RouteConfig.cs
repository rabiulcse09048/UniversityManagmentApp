using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using UniversityManagementMvcFinalApp.Models;

namespace UniversityManagementMvcFinalApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           Database.SetInitializer(new SeedClass());
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
