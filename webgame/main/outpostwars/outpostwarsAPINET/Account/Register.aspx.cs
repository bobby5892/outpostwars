﻿using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using outpostwarsAPINET.Models;

using outpostWarsClasses;
using outpostwarsdb;
namespace outpostwarsAPINET.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771

                /* Send Confirmation Email */
                string code = manager.GenerateEmailConfirmationToken(user.Id);
                string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                /* Create User Account */
               Create create = new Create();
               Player newPlayer = new Player();
               newPlayer.CLSID = user.Id;
               newPlayer.email = user.Email;
                
               create.CreateEverything(newPlayer);

              // create.CreateEverything(newPlayer,chosenSector);


                signInManager.SignIn( user, isPersistent: false, rememberBrowser: true);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}