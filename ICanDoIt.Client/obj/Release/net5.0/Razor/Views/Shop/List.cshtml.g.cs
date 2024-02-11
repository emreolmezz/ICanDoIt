#pragma checksum "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b59f21b18002c4afae4040596c08946932058e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b59f21b18002c4afae4040596c08946932058e", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a981751c51bfdb589bdee6020bbc2167dd730f67", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"album py-5 bg-white\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 14 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
           Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <div class=\"row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3\">\r\n");
#nullable restore
#line 18 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-6 col-lg-4 mb-4\" data-aos=\"fade-up\">\r\n                            <div class=\"block-4 text-center border\">\r\n                                <figure class=\"block-4-image\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b59f21b18002c4afae4040596c08946932058e6869", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e6b59f21b18002c4afae4040596c08946932058e7085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 860, "~/Images/", 860, 9, true);
#nullable restore
#line 23 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
AddHtmlAttributeValue("", 869, item.ImageUrl, 869, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                                                                     WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </figure>\r\n                                <div class=\"block-4-text p-4\">\r\n                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b59f21b18002c4afae4040596c08946932058e11093", async() => {
#nullable restore
#line 26 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                                                                         WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                                    <p class=\"text-primary font-weight-bold\">$ ");
#nullable restore
#line 27 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                                                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 31 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""row"">
                    <div class=""col"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination"">
                                <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
");
#nullable restore
#line 38 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                 for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                     if (String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 2023, "\"", 2087, 2);
            WriteAttributeValue("", 2031, "page-item", 2031, 9, true);
#nullable restore
#line 42 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 2040, Model.PageInfo.CurrentPage==i+1?"active":"", 2041, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2155, "\"", 2183, 2);
            WriteAttributeValue("", 2162, "/products?page=", 2162, 15, true);
#nullable restore
#line 43 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
WriteAttributeValue("", 2177, i+1, 2177, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 44 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 47 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 2505, "\"", 2569, 2);
            WriteAttributeValue("", 2513, "page-item", 2513, 9, true);
#nullable restore
#line 51 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 2522, Model.PageInfo.CurrentPage==i+1?"active":"", 2523, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2637, "\"", 2697, 4);
            WriteAttributeValue("", 2644, "/products/", 2644, 10, true);
#nullable restore
#line 52 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
WriteAttributeValue("", 2654, Model.PageInfo.CurrentCategory, 2654, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2685, "?page=", 2685, 6, true);
#nullable restore
#line 52 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
WriteAttributeValue("", 2691, i+1, 2691, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 53 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 56 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Emre\Desktop\Engineering\Programming\ICanDoIt\ICanDoIt.Client\Views\Shop\List.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
