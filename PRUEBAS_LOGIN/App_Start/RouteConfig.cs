using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PRUEBAS_LOGIN
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Rutas para los grados
            for (int i = 1; i <= 8; i++)
            {
                routes.MapRoute(
                    name: $"Grado{i}",
                    url: $"Home/Grado{i}",
                    defaults: new { controller = "Home", action = $"Grado{i}" }
                );

            }

            routes.MapRoute(
           name: "Asistencia_Grado1",
           url: "Home/Grado1/Asistencia1",
           defaults: new { controller = "Home", action = "Asistencia1" }
       );

            routes.MapRoute(
                name: "Calificaciones_Grado1",
                url: "Home/Grado1/Calificaciones1",
                defaults: new { controller = "Home", action = "Calificaciones1" }
            );

            routes.MapRoute(
                name: "Comentarios_Grado1",
                url: "Home/Grado1/Comentarios1",
                defaults: new { controller = "Home", action = "Comentarios1" }
            );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
