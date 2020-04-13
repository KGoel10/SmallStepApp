using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ONE_SMALL_STEP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            //routes.MapRoute(
            //    name: "person",
            //    url: "person/{*catch-all}",
            //    defaults: new
            //    {
            //        controller = "Person",
            //        action = "Index"
            //    });

            routes.MapRoute(
            name: "messageType",
            url: "messageType/{*catch-all}",
            defaults: new
            {
                controller = "Home",
                action = "Index"
            });


            routes.MapRoute(
            name: "message",
            url: "message/{*catch-all}",
            defaults: new
            {
                controller = "Home",
                action = "Index"
            });



            routes.MapRoute(
            name: "person",
            url: "person/{*catch-all}",
            defaults: new
            {
                controller = "Home",
                action = "Index"
            });

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }    
            );


      

       
       
        }
    }
}
