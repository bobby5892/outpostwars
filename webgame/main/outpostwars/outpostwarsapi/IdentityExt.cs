using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
namespace outpostwarsapi
{
    /*
     * 5/23/2018
     * Added So you can access applicationPropteries from elsewhere
     https://stackoverflow.com/questions/39174121/get-property-of-applicationuser-from-the-asp-net-core-identity
    */
    public static class IdentityExt
    {
        public static Task<T> GetCurrentUser<T>(this UserManager<T> manager, HttpContext httpContext) where T : class
        {
            return manager.GetUserAsync(httpContext.User);
        }
    }
}
