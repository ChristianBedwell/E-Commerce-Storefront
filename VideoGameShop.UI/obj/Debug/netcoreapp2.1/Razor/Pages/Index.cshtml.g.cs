#pragma checksum "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "691f15ea9d0f09daad136ac982c16ba2afea8e44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VideoGameShop.UI.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(VideoGameShop.UI.Pages.Pages_Index), null)]
namespace VideoGameShop.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\_ViewImports.cshtml"
using VideoGameShop.UI;

#line default
#line hidden
#line 2 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"691f15ea9d0f09daad136ac982c16ba2afea8e44", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4c00bdb32094668ee540e829afc02eca0c6698", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/video game item.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 75, true);
            WriteLiteral("\r\n<div class=\"section\">\r\n    <div class=\"columns is-multiline is-mobile\">\r\n");
            EndContext();
#line 9 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
          
            foreach (var p in Model.Products)
            {

#line default
#line hidden
            BeginContext(220, 103, true);
            WriteLiteral("                <div class=\"column is-one-third-desktop is-4-tablet is-6-mobile\">\r\n                    ");
            EndContext();
            BeginContext(323, 2108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26088f78bf7c4bd89a9ea2f1d52392a8", async() => {
                BeginContext(388, 205, true);
                WriteLiteral("\r\n                        <div class=\"card large\">\r\n                            <div class=\"card-image\">\r\n                                <figure class=\"image is-3x4\">\r\n                                    ");
                EndContext();
                BeginContext(593, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "181b530ff7ac4991b1fe911cca73c7dd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(633, 317, true);
                WriteLiteral(@"
                                </figure>
                            </div>
                            <div class=""card-content"">
                                <div class=""media"">
                                    <div class=""media-content"">
                                        <p class=""title is-4"">");
                EndContext();
                BeginContext(951, 6, false);
#line 23 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                                                         Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(957, 71, true);
                WriteLiteral("</p>\r\n                                        <p class=\"subtitle is-6\">");
                EndContext();
                BeginContext(1029, 7, false);
#line 24 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                                                            Write(p.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1036, 181, true);
                WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"content\">\r\n                                    ");
                EndContext();
                BeginContext(1218, 13, false);
#line 28 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                               Write(p.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1231, 42, true);
                WriteLiteral("\r\n                                </div>\r\n");
                EndContext();
#line 30 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                                  
                                    string cssClass = "";
                                    string message = "";

                                    if (p.StockCount == 0)
                                    {
                                        cssClass = "is-danger";
                                        message = "Out of Stock";
                                    }
                                    else if (p.StockCount <= 10)
                                    {
                                        cssClass = "is-warning";
                                        message = "Low on Stock";
                                    }
                                

#line default
#line hidden
                BeginContext(2010, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 45 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                                 if (p.StockCount <= 10)
                                {

#line default
#line hidden
                BeginContext(2103, 40, true);
                WriteLiteral("                                    <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2143, "\"", 2206, 4);
                WriteAttributeValue("", 2151, "notification", 2151, 12, true);
                WriteAttributeValue(" ", 2163, "is-paddingless", 2164, 15, true);
                WriteAttributeValue(" ", 2178, "has-text-centered", 2179, 18, true);
#line 47 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
WriteAttributeValue(" ", 2196, cssClass, 2197, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2207, 43, true);
                WriteLiteral(">\r\n                                        ");
                EndContext();
                BeginContext(2251, 7, false);
#line 48 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                                   Write(message);

#line default
#line hidden
                EndContext();
                BeginContext(2258, 46, true);
                WriteLiteral("\r\n                                    </div>\r\n");
                EndContext();
#line 50 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2339, 88, true);
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
                                              WriteLiteral(p.Name.Replace(" ", "-"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2431, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 55 "C:\Users\chris\source\repos\VideoGameShop\VideoGameShop.UI\Pages\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(2483, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
