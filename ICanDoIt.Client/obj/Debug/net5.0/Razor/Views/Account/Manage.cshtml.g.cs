#pragma checksum "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Account\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfbf66695a2922a6528f81d435f114015a780098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Manage), @"mvc.1.0.view", @"/Views/Account/Manage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\_ViewImports.cshtml"
using ICanDoIt.Entity.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\_ViewImports.cshtml"
using ICanDoIt.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\_ViewImports.cshtml"
using ICanDoIt.Client.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfbf66695a2922a6528f81d435f114015a780098", @"/Views/Account/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a981751c51bfdb589bdee6020bbc2167dd730f67", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Account\Manage.cshtml"
  
    ViewData["Title"] = "Manage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""list-group pb-2"">
                    <a href=""/account/orders"" class=""list-group-item list-group-item-action"">
                        Orders
                    </a>
                    <a");
            BeginWriteAttribute("href", " href=\"", 409, "\"", 484, 2);
            WriteAttributeValue("", 416, "/account/ProfileInfo/", 416, 21, true);
#nullable restore
#line 15 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Account\Manage.cshtml"
WriteAttributeValue("", 437, User.FindFirstValue(ClaimTypes.NameIdentifier), 437, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""list-group-item list-group-item-action"">
                        Profile Info
                    </a>
                    <a href=""/account/PasswordChange"" class=""list-group-item list-group-item-action"">
                        Change Password
                    </a>
                    <a href=""/account/adresses"" class=""list-group-item list-group-item-action"">
                        Adresess
                    </a>
                    <a href=""/account/logout"" class=""list-group-item list-group-item-action"">
                        Logout
                    </a>
                </div>
            </div>
            <div class=""col-md-9"">
               
                
            </div>
        </div>
    </div>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
