using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace outpostwarsapi.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
       // Create DB Linked Properties
        public int ProfileID { get; set; }
        public string ProfileType { get; set; }

        // set default
        public ApplicationUser()
        {
            this.ProfileType = "Player";
        }
    }
}
