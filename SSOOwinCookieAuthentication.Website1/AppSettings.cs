using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SSOOwinCookieAuthentication.Website1
{
    public class AppSettings
    {
        internal static readonly string LoginPath = "/Account/Login";
        internal static readonly string LogoutPath = "/Account/Logout";

        internal static string AuthenticationType => ConfigurationManager.AppSettings["AppAuthenticationType"] ?? SsoSettings.AuthenticationType;
    }
}