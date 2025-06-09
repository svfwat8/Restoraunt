﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Restoraunt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Restoraunt.Controllers" } 
            );
            //routes.MapRoute(
            //    name: "404-PageNotFound",
            //    url: "{*url}",
            //    defaults: new { controller = "Error", action = "Page404"}
            //);
        }
    }

}
