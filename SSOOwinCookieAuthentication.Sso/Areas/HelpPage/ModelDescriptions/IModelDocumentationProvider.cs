using System;
using System.Reflection;

namespace SSOOwinCookieAuthentication.Sso.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}