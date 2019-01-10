using System.Configuration;

namespace SSOOwinCookieAuthentication.SsoSecurity
{
    public class SsoSettings
    {
        internal const string AuthenticationType = "SsoCookies";
        internal static string CookieName => ConfigurationManager.AppSettings["AppSsoCookieName"] ?? ".myOrg.SingleSignOn";
        internal static string CookieDomain => ConfigurationManager.AppSettings["AppSsoCookieDomain"] ?? "localhost";
    }
}