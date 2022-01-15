using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace novaSoft
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Eleve/Search", "Eleve/Search/{searchingValue}", new { controller = "Eleve", action= "Search", searchingValue = UrlParameter.Optional });
            routes.MapRoute("Eleve/updatePaiement", "Eleve/updatePaiement/{id}/{montant}/{mois}", new { controller = "Eleve", action ="updatePaiement", id = UrlParameter.Optional, montant = UrlParameter.Optional, mois = UrlParameter.Optional});
            routes.MapRoute("ObjetSaisie/SearchByMatricule", "ObjetSaisie/SearchByMatricule/{searchingValue}", new { controller = "ObjetSaisie", action = "SearchByMatricule", searchingValue = UrlParameter.Optional });


            /*  routes.MapRoute("Eleve/SearchByMatricule", "Eleve/SearchByMatricule/{matricule}", new { controller = "Eleve", action = "SearchByMatricule", matricule = UrlParameter.Optional });
  */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
