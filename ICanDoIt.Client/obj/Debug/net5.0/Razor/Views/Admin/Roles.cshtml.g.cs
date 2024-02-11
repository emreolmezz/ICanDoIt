#pragma checksum "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a68650d3cfb91480040960798d6552954e03b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Roles), @"mvc.1.0.view", @"/Views/Admin/Roles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a68650d3cfb91480040960798d6552954e03b5f", @"/Views/Admin/Roles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a981751c51bfdb589bdee6020bbc2167dd730f67", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Roles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
  
    ViewData["Title"] = "Roles";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
Write(await Html.PartialAsync("_AdminNavbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
Write(await Html.PartialAsync("_AdminSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content-wrapper container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h1 class=""h3"">Roles</h1>
            <hr>
            <a class=""btn btn-primary btn-sm"" href=""/admin/RoleCreate"">Add Role</a>
            <table class=""table table-bordered mt-3"">
                <thead>
                    <tr>
                        <td style=""width: 30px;"">Id</td>
                        <td style=""width: 100px;"">Role Name</td>
                        <td style=""width: 30px;""></td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 25 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
                     if (Model.Count() > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                \r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1217, "\"", 1248, 2);
            WriteAttributeValue("", 1224, "/admin/editrole/", 1224, 16, true);
#nullable restore
#line 34 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
WriteAttributeValue("", 1240, item.Id, 1240, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a68650d3cfb91480040960798d6552954e03b5f8059", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 1491, "\"", 1507, 1);
#nullable restore
#line 37 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
WriteAttributeValue("", 1499, item.Id, 1499, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1348, "/admin/deleterole/", 1348, 18, true);
#nullable restore
#line 36 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
AddHtmlAttributeValue("", 1366, item.Id, 1366, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Roles.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591