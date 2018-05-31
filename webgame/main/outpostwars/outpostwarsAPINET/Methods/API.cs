using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using outpostwarsAPINET.Models;


namespace outpostwarsAPINET.Methods
{
    public static class API
    {
        public static ApplicationDbContext dbContext = new ApplicationDbContext();
        public static UserManager<ApplicationUser> UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(dbContext));
        public static Guid CurrentUserGuid
        {
            get
            {
                Guid _currentUserGuid = Guid.Empty;
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    if (!String.IsNullOrEmpty(HttpContext.Current.User.Identity.Name))
                    {
                        _currentUserGuid = new Guid(HttpContext.Current.User.Identity.GetUserId());
                    }
                }
                return _currentUserGuid;
            }
        }

      
        public static ApplicationUser applicationUser = UserManager.FindById(CurrentUserGuid.ToString());
        public static bool isLoggedIn = HttpContext.Current.User.Identity.IsAuthenticated;
        public static bool isPlayer = (API.applicationUser.ProfileType == "Player");
        public static bool isAdmin = (API.applicationUser.ProfileType == "Admin");

    } 
}