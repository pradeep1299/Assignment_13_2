﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShoppingMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ViewData",
                url: "ViewData",
                defaults: new { controller = "DisplayList", action = "ViewDataProduct", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ViewBag",
                url: "ViewBag",
                defaults: new { controller = "DisplayList", action = "ViewBagProduct", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "TempData",
                url: "TempData",
                defaults: new { controller = "DisplayList", action = "TempDataProduct", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "DisplayList", action = "ViewDataProduct", id = UrlParameter.Optional }
            );
        }
    }
}