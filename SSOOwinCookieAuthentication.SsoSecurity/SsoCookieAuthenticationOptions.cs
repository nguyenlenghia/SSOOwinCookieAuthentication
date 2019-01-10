using Microsoft.Owin.Security.Cookies;

namespace SSOOwinCookieAuthentication.SsoSecurity
{
    public class SsoCookieAuthenticationOptions : CookieAuthenticationOptions
    {
        public SsoCookieAuthenticationOptions()
        {
            // Override default of CookieAuthenticationOptions
            this.AuthenticationType = SsoCookieAuthenticationDefaults.AuthenticationType; // SsoSettings.AuthenticationType;
            this.CookieName = SsoCookieAuthenticationDefaults.CookieName; // SsoSettings.CookieName;
            this.CookieDomain = SsoCookieAuthenticationDefaults.CookieDomain; // SsoSettings.CookieDomain;
        }
    }
}
