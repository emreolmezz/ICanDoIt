#pragma checksum "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca52a071c8fb15b70397edaa532649e4c2d634c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Products), @"mvc.1.0.view", @"/Views/Admin/Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca52a071c8fb15b70397edaa532649e4c2d634c6", @"/Views/Admin/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a981751c51bfdb589bdee6020bbc2167dd730f67", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
Write(await Html.PartialAsync("_AdminNavbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
Write(await Html.PartialAsync("_AdminSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-wrapper container\">\r\n");
#nullable restore
#line 12 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
     if (TempData["message"] != null)
    {
        var message = JsonConvert.DeserializeObject<AlertMessage>(TempData["message"] as string);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 486, "\"", 524, 3);
            WriteAttributeValue("", 494, "alert", 494, 5, true);
            WriteAttributeValue(" ", 499, "alert-", 500, 7, true);
#nullable restore
#line 17 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
WriteAttributeValue("", 506, message.AlertType, 506, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
               Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <h1 class=""h3"">Admin Products</h1>
            <hr>
            <a class=""btn btn-primary btn-sm"" href=""/admin/createproduct"">Add Product</a>
            <table id=""productTable"" class=""table table-bordered mt-3"" data-ordering=""false"">
                <thead>
                    <tr>
                        <td class=""adminTd"" style=""width: 30px;"">Id</td>
                        <td class=""adminTd"" style=""width: 100px;"">Image</td>
                        <td class=""adminTd"">Name</td>
                        <td class=""adminTd"" style=""width: 20px;"">Price</td>
                        <td class=""adminTd"" style=""width: 20px;"">Stock</td>
                        <td class=""adminTd"" style=""width: 150px;""></td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 40 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                     if (Model.Products.Count() > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                         foreach (var item in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"adminTd\">");
#nullable restore
#line 45 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"adminTd\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca52a071c8fb15b70397edaa532649e4c2d634c69573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1810, "~/Images/", 1810, 9, true);
#nullable restore
#line 46 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
AddHtmlAttributeValue("", 1819, item.ImageUrl, 1819, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td class=\"adminTd\">");
#nullable restore
#line 47 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"adminTd\">");
#nullable restore
#line 48 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"adminTd\">\r\n");
#nullable restore
#line 50 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                             if (item.isStock)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 53 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 57 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"adminTd\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2473, "\"", 2507, 2);
            WriteAttributeValue("", 2480, "/admin/editproduct/", 2480, 19, true);
#nullable restore
#line 60 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
WriteAttributeValue("", 2499, item.Id, 2499, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca52a071c8fb15b70397edaa532649e4c2d634c613503", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 2740, "\"", 2756, 1);
#nullable restore
#line 63 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
WriteAttributeValue("", 2748, item.Id, 2748, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2599, "/admin/deleteproduct/", 2599, 21, true);
#nullable restore
#line 62 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
AddHtmlAttributeValue("", 2620, item.Id, 2620, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-warning\">\r\n                            <h3>No Products</h3>\r\n                        </div>\r\n");
#nullable restore
#line 75 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Admin\Products.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591