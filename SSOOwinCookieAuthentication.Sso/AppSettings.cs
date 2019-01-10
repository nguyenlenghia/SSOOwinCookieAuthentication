using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SSOOwinCookieAuthentication.Sso
{
    public class AppSettings
    {
        internal static readonly string LoginPath = "/Account/Login";
        internal static readonly string LogoutPath = "/Account/Logout";

        internal static string AuthenticationType => ConfigurationManager.AppSettings["AppAuthenticationType"] ?? "SsoCookies";
    }
}