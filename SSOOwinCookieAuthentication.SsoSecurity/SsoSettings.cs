using System.Configuration;

namespace SSOOwinCookieAuthentication.SsoSecurity
{
    public class SsoSettings
    {
        public const string AuthenticationType = "SsoCookies";
        public static string CookieName => ConfigurationManager.AppSettings["AppSsoCookieName"] ?? ".myOrg.SingleSignOn";
        public static string CookieDomain => ConfigurationManager.AppSettings["AppSsoCookieDomain"] ?? "localhost";
    }
}