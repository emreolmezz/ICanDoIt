#pragma checksum "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb3b8f861a38641be055dc6d8e2dd30d6622c2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb3b8f861a38641be055dc6d8e2dd30d6622c2c", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a981751c51bfdb589bdee6020bbc2167dd730f67", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""navbar navbar-expand-md navbar-light"">

    <a class=""navbar-brand"" href=""#!"">
        <img src=""https://mdbootstrap.com/img/logo/mdb-transaprent-noshadows.png"" height=""30"" alt=""mdb logo"">
    </a>

    <!-- Collapse button -->
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#basicExampleNav13""
            aria-controls=""basicExampleNav13"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <!-- Breadcrumbs -->
    <!-- Breadcrumbs -->
    <!-- Links -->
    <div class=""collapse navbar-collapse"" id=""basicExampleNav13"">

        <div class=""navbar-search pl-0 ml-auto mt-3 mb-2 mt-md-0 mb-md-0 mr-3"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb3b8f861a38641be055dc6d8e2dd30d6622c2c5968", async() => {
                WriteLiteral(@"
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"" placeholder=""Search"" name=""q"">
                    <div class=""input-group-btn"">
                        <button class=""btn btn-default"" type=""submit"">
                            <i class=""fas fa-search""></i>
                        </button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          </div>

        <!-- Right -->
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a href=""/cart"" class=""nav-link navbar-link-2 waves-effect"">
                    <span class=""badge badge-pill red"">1</span>
                    <i class=""fas fa-shopping-cart pl-0""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""#!"" class=""nav-link waves-effect"">
                    Shop
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""#!"" class=""nav-link waves-effect"">
                    Contact
                </a>
            </li>
");
#nullable restore
#line 50 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a href=\"/admin/index\" class=\"nav-link waves-effect\">\r\n                            Admin Arayüzü\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 59 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shared\_navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a href=\"/account/manage\" class=\"nav-link waves-effect\">\r\n                        ");
#nullable restore
#line 62 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shared\_navbar.cshtml"
                   Write(User.FindFirstValue(ClaimTypes.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </a>
                </li>
                <li class=""nav-item pl-2 mb-2 mb-md-0 d-md-none d-xl-inline-block"">
                    <a href=""/Account/Logout"" type=""button""
                       class=""btn btn-outline-info btn-md btn-rounded btn-navbar waves-effect waves-light"">
                        Logout
                    </a>
                </li>
");
#nullable restore
#line 71 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shared\_navbar.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item d-md-none d-xl-inline-block"">
                    <a href=""/Account/Login"" class=""nav-link waves-effect"">
                        Sign in
                    </a>
                </li>
                <li class=""nav-item pl-2 mb-2 mb-md-0 d-md-none d-xl-inline-block"">
                    <a href=""/Account/Register"" type=""button""
                       class=""btn btn-outline-info btn-md btn-rounded btn-navbar waves-effect waves-light"">
                        Sign
                        up
                    </a>
                </li>
");
#nullable restore
#line 86 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shared\_navbar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n\r\n    </div>\r\n    <!-- Links -->\r\n\r\n</nav>");
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
