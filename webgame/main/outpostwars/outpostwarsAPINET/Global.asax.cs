using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using outpostwarsAPINET.Models;

namespace outpostwarsAPINET
{
    public class Global : HttpApplication
    {
  
        void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapPageRoute("", "Player", "~/Methods/Player.aspx");

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Custom Routes for Game
           
            // RegisterRoutes(RouteTable.Routes);



        }
    }
}