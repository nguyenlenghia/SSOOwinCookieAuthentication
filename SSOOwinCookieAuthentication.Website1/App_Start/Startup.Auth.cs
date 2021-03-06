﻿using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSOOwinCookieAuthentication.Website1
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the Application Sign In Cookie.
            // UseCookieAuthentication is an extension of Microsoft.Owin.Security.Cookies.CookieAuthenticationExtensions
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = SsoSettings.AuthenticationType,

                // The value of CookieName and CookieDomain must is the same in every sso website.
                CookieName = SsoSettings.CookieName,
                CookieDomain = SsoSettings.CookieDomain,
            });

            // Set default Way to SignIn as AuthenticationType
            app.SetDefaultSignInAsAuthenticationType(AppSettings.AuthenticationType);
        }
    }
}