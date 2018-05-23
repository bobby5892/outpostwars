using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using outpostwarsapi.Data;
using outpostwarsapi;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
namespace outpostwarsapi.Pages.API
{
    public class APIBASEController : Controller
    {
        
       

        // Load the User Manager
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _context;
        public APIBASEController(UserManager<ApplicationUser> userManager, IHttpContextAccessor context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task GrabUserInfo()
        {
            // Current Application user
            ApplicationUser user = await _userManager.GetUserAsync(_context.HttpContext.User);
            
            // user.ProfileID;
            // user.ProfileType;
           
            
        }

       
        public IActionResult Index()
        {
           
            return View();
        }
    }
}