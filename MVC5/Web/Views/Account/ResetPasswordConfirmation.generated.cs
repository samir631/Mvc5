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
    using ViewModel;
    using Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/ResetPasswordConfirmation.cshtml")]
    public partial class _Views_Account_ResetPasswordConfirmation_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Account_ResetPasswordConfirmation_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\ResetPasswordConfirmation.cshtml"
  


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n        <strong>طھط£غŒغŒط¯ طھط؛غŒغŒط± ع©ظ„ظ…ظ‡ ط¹ط¨ظˆط±</strong>\r\n    </div>\r\n" +
"    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(@">
        <p>
            ط¨ط§ ط³ظ„ط§ظ….
            <br />
            ع©ط§ط±ط¨ط± ع¯ط±ط§ظ…غŒ ع©ظ„ظ…ظ‡ ط¹ط¨ظˆط± ط´ظ…ط§ ط¨ط§ ظ…ظˆظپظ‚غŒطھ ط¨ظ‡ طھط؛غŒغŒط± غŒط§ظپطھ.ظ‡ظ… ط§ع©ظ†ظˆظ† ط´ظ…ط§ ط¨ظ‡ طµظˆط±طھ ط§طھظˆظ…ط§طھغŒع© ظˆط§ط±ط¯ ط­ط³ط§ط¨ ط®ظˆط¯ ط´ط¯ظ‡ ط§غŒط¯.
            <br />
            ط¨ط§ طھط´ع©ط± 
        </p>
    </div>
");

            
            #line 18 "..\..\Views\Account\ResetPasswordConfirmation.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\ResetPasswordConfirmation.cshtml"
     if (!User.Identity.IsAuthenticated)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 23 "..\..\Views\Account\ResetPasswordConfirmation.cshtml"
               Write(Html.ActionLink("ظˆط±ظˆط¯ ط¨ظ‡ ط­ط³ط§ط¨ ع©ط§ط±ط¨ط±غŒ", MVC.Account.ActionNames.Login, MVC.Account.Name, null, new { @class = "btn btn-block btn-info btn-sm" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 27 "..\..\Views\Account\ResetPasswordConfirmation.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
