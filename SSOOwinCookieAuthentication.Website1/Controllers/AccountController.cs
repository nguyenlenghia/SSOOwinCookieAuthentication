using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace SSOOwinCookieAuthentication.Website1.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// The owin authentication type name
        /// </summary>
        public readonly string AuthenticationType = CookieAuthenticationDefaults.AuthenticationType;

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            //var isLoginValid = FormsAuthentication.Authenticate(username, password);
            var isLoginValid = !string.IsNullOrWhiteSpace(username) && username == password;
            if (isLoginValid)
            {
                var owinContext = Request.GetOwinContext();
                var authenticationManager = owinContext.Authentication;

                username = username.ToLower();
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username),
                };

                var identity = new ClaimsIdentity(claims, AuthenticationType, ClaimTypes.Name, ClaimTypes.Role);
                var properties = new AuthenticationProperties { IsPersistent = false };
                authenticationManager.SignIn(properties, identity);

                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login details");
                ViewBag.ReturnUrl = returnUrl;
                return View();
            }
        }

        [Authorize]
        public ActionResult Logout()
        {
            Session.Clear();
            Request.Cookies.Clear();

            var owinContext = Request.GetOwinContext();
            var authenticationManager = owinContext.Authentication;
            authenticationManager.SignOut(AuthenticationType);

            return RedirectToLocal(null);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}