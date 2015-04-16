﻿using CMS.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KonigLabs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var route = routes.MapRoute("locations", "{*location}", MVC.Default.Page(),
                        new { localizationRedirectRouteName = "homepage" },
                        new { location = new LocationConstraints() });
            route.DataTokens["RouteName"] = "locations";



            routes.MapRoute(
                name: "Comment",
                url: "Comment",
                defaults: new { controller = "Home", action = "Comment" }
            );

            routes.MapRoute(
                name: "Blog",
                url: "Blog/{language}",
                defaults: new { controller = "Home", action = "Blog", language = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Article",
               url: "BlogPost/{id}",
               defaults: new { controller = "Home", action = "BlogPost" }
           );
            
            routes.MapRoute(
                name: "Default",
                url: "{language}",
                defaults: new { controller = "Home", action = "Index", language = UrlParameter.Optional }
            );

            

            routes.MapRoute(
              name: "Accounts",
              url: "{controller}/{action}"
          );
        }
    }
}
