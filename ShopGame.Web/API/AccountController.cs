﻿using Microsoft.AspNet.Identity.Owin;
using ShopGame.Web.App_Start;
using ShopGame.Web.Infastucture.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace ShopGame.Web.API
{
    // api dung de chung thuc nguoi dung
    [RoutePrefix("api/account")]
    public class AccountController : BaseApiController
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
       
        public async Task<HttpResponseMessage> Login(HttpRequestMessage req, string u,String p,bool remem)
        {
            if (!ModelState.IsValid)
            {
                return req.CreateErrorResponse(HttpStatusCode.BadRequest,ModelState);
            }

         
            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = await SignInManager.PasswordSignInAsync(u,p,remem, shouldLockout: false);           
            return req.CreateResponse(HttpStatusCode.OK, result);

                         
        }

    }
}