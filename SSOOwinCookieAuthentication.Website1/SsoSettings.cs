using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SSOOwinCookieAuthentication.Website1
{
    public class SsoSettings
    {
        internal const string AuthenticationType = "SsoCookies";
        internal static string CookieName => ConfigurationManager.AppSettings["AppSsoCookieName"] ?? ".myOrg.SingleSignOn";
        internal static string CookieDomain => ConfigurationManager.AppSettings["AppSsoCookieDomain"] ?? "localhost";
    }
}