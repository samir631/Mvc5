﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\_LoginPartial.cshtml"
    using ServiceLayer.Security;
    
    #line default
    #line hidden
    using ViewModel;
    using Web;
    
    #line 2 "..\..\Views\Shared\_LoginPartial.cshtml"
    using Microsoft.AspNet.Identity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_LoginPartial.cshtml")]
    public partial class _Views_Shared__LoginPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__LoginPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_LoginPartial.cshtml"
 if (Request.IsAuthenticated)
{
    using (Html.BeginForm(MVC.Account.ActionNames.LogOff, MVC.Account.Name, FormMethod.Post, new { id = "logoutForm", @class = "navbar-right" }))
    {
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Shared\_LoginPartial.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Shared\_LoginPartial.cshtml"
                                


            
            #line default
            #line hidden
WriteLiteral("        <ul");

WriteLiteral(" class=\"nav navbar-nav navbar-right\"");

WriteLiteral(">\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 11 "..\..\Views\Shared\_LoginPartial.cshtml"
           Write(Html.ActionLink("سلام " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues: new { area = "" }, htmlAttributes: new { title = "Manage", @class = "nofollow" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li><a");

WriteLiteral(" href=\"javascript:document.getElementById(\'logoutForm\').submit()\"");

WriteLiteral(">خروج</a></li>\r\n");

            
            #line 14 "..\..\Views\Shared\_LoginPartial.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Shared\_LoginPartial.cshtml"
             if (User.IsInRole(AssignableToRolePermissions.CanViewAdminPanel))
            {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("\r\n                <li>");

            
            #line 17 "..\..\Views\Shared\_LoginPartial.cshtml"
               Write(Html.ActionLink("پنل مدیریت", MVC.Administrator.Home.ActionNames.Index, MVC.Administrator.Home.Name, new { area = MVC.Administrator.Name }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            ");

WriteLiteral("\r\n");

            
            #line 19 "..\..\Views\Shared\_LoginPartial.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 21 "..\..\Views\Shared\_LoginPartial.cshtml"
    }
   
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <ul");

WriteLiteral(" class=\"nav navbar-nav navbar-right\"");

WriteLiteral(">\r\n        <li>");

            
            #line 27 "..\..\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("ورود", MVC.Account.ActionNames.Login, MVC.Account.Name, null, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 28 "..\..\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("عضویت", MVC.Account.ActionNames.Register, MVC.Account.Name, null, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

            
            #line 30 "..\..\Views\Shared\_LoginPartial.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591