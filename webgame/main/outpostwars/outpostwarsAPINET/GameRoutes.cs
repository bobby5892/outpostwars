using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using outpostwarsAPINET.Models;

namespace outpostwarsAPINET
{
    public class GameRoutes
    {
    



        /// <summary>
        /// Register the Game Routes
        /// </summary>
        public void registerRoutes()
        {
            RouteCollection routes = new RouteCollection();
            // MAke sure an send to Method and have it check for Player or Admin applicationUser.ProfileType
            //ApplicationUser applicationUser is in
            //currentUser
            /* TEMPLATE
            string[] allowedMethods = { "GET", "POST" };
            HttpMethodConstraint methodConstraints = new HttpMethodConstraint(allowedMethods);
            Route reportRoute = new Route("{locale}/{year}", new ReportRouteHandler());
            reportRoute.Constraints = new RouteValueDictionary { { "httpMethod", methodConstraints } };
            
            routes.Add(reportRoute);
            */

            //APIRoutes
            #region Endpoints

            /*  // /API/Player - Get Current Player Info
              string[] allowedMethods = { "GET", "POST" };
              HttpMethodConstraint methodConstraints = new HttpMethodConstraint(allowedMethods);
              Route reportRoute = new Route("{locale}/{year}", new ReportRouteHandler());
              reportRoute.Constraints = new RouteValueDictionary { { "httpMethod", methodConstraints } };

              routes.Add(reportRoute);
              */

            // /API/Player - Get Current Player Info

           
           //
            #endregion
        }
    }
}