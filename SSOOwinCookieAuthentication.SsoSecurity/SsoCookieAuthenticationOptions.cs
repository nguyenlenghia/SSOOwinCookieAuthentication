using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOOwinCookieAuthentication.SsoSecurity
{
    public class SsoCookieAuthenticationOptions : CookieAuthenticationOptions
    {
        public SsoCookieAuthenticationOptions()
        {
            // Override default of CookieAuthenticationOptions
            this.AuthenticationType = SsoCookieAuthenticationDefaults.AuthenticationType;
            this.CookieName = SsoCookieAuthenticationDefaults.CookieName;
            this.CookieDomain = SsoCookieAuthenticationDefaults.CookieDomain;
        }
    }

    /// <summary>
    /// Default values related to cookie-based authentication middleware
    /// </summary>
    public static class SsoCookieAuthenticationDefaults
    {
        /// <summary>
        /// The default value used for SsoCookieAuthenticationOptions.CookieName
        /// It must the same in every your sso website.
        /// You must change it'name follow your name. The best way to get is get from your config.
        /// </summary>
        public const string CookieName = "SingleSignOn";

        /// <summary>
        /// The default value used for SsoCookieAuthenticationOptions.CookieDomain.
        /// It must the same in every your sso website.
        /// You must change it'name follow your domain. The best way to get is get from your config.
        /// </summary>
        public const string CookieDomain = "mydomain.com";

        /// <summary>
        /// The default value used for SsoCookieAuthenticationOptions.AuthenticationType
        /// </summary>
        public const string AuthenticationType = "SsoCookies";

        /// <summary>
        /// The prefix used to provide a default SsoCookieAuthenticationOptions.CookieName
        /// </summary>
        public const string CookiePrefix = ".MyAspNet.";

        /// <summary>
        /// The default value used by UseApplicationSignInCookie for the
        /// SsoCookieAuthenticationOptions.LoginPath
        /// </summary>
        public static readonly PathString LoginPath = new PathString("/Account/Login");

        /// <summary>
        /// The default value used by UseApplicationSignInCookie for the
        /// SsoCookieAuthenticationOptions.LogoutPath
        /// </summary>
        public static readonly PathString LogoutPath = new PathString("/Account/Logout");

        /// <summary>
        /// The default value of the SsoCookieAuthenticationOptions.ReturnUrlParameter
        /// </summary>
        public const string ReturnUrlParameter = "ReturnUrl";
    }
}
