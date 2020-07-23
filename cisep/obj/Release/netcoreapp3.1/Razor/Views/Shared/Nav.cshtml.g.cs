#pragma checksum "C:\cicep_project\cisep\cisep\Views\Shared\Nav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a3ef526b54a809045e48c32069845d14983dfe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Nav), @"mvc.1.0.view", @"/Views/Shared/Nav.cshtml")]
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
#line 1 "C:\cicep_project\cisep\cisep\Views\_ViewImports.cshtml"
using cisep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\cicep_project\cisep\cisep\Views\_ViewImports.cshtml"
using cisep.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3ef526b54a809045e48c32069845d14983dfe2", @"/Views/Shared/Nav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f9c12bc26ea23a9af3a7b8556ffd35affaf06b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Nav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logoCISEP.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("alternative"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link page-scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ServicesPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreditRepairIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Navbar -->
    <nav class=""navbar navbar-expand-md navbar-dark navbar-custom fixed-top"">
        <!-- Text Logo - Use this if you don't have a graphic logo -->
        <!-- <a class=""navbar-brand logo-text page-scroll"" href=""index.html"">Aria</a> -->
        <!-- Image Logo -->
        <a class=""navbar-brand logo-image"" href=""index.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a3ef526b54a809045e48c32069845d14983dfe25182", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        \r\n        <a");
            BeginWriteAttribute("class", " class=\"", 427, "\"", 435, 0);
            EndWriteAttribute();
            WriteLiteral(@"style=""text-decoration:none;color:white;"" href=""index.html"">CISEP Multi-Services</a>
        <!-- Mobile Menu Toggle Button -->
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExampleDefault"" aria-controls=""navbarsExampleDefault"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-awesome fas fa-bars""></span>
            <span class=""navbar-toggler-awesome fas fa-times""></span>
        </button>
        <!-- end of mobile menu toggle button -->

        <div class=""collapse navbar-collapse"" id=""navbarsExampleDefault"">
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link page-scroll"" href=""#header"">HOME <span class=""sr-only"">(current)</span></a>
                </li>
");
            WriteLiteral("\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link page-scroll\" href=\"#services\">SERVICES</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a3ef526b54a809045e48c32069845d14983dfe27601", async() => {
                WriteLiteral("CREDITO");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle page-scroll"" href=""#intro"" id=""navbarDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">ABOUT</a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        <a class=""dropdown-item"" href=""terms-conditions.html""><span class=""item-text"">TERMS CONDITIONS</span></a>
                        <div class=""dropdown-items-divide-hr""></div>
                        <a class=""dropdown-item"" href=""privacy-policy.html""><span class=""item-text"">PRIVACY POLICY</span></a>
                    </div>
                </li>
");
            WriteLiteral(@"
                <!-- Dropdown Menu -->
                <!-- end of dropdown menu -->

                <li class=""nav-item"">
                    <a class=""nav-link page-scroll"" href=""#contact"">CONTACT</a>
                </li>
            </ul>
            <span class=""nav-item social-icons"">
                <span class=""fa-stack"">
                    <a href=""https://www.facebook.com/cisepcomunidad/"" target=""_blank"">
");
            WriteLiteral(@"                        <i class=""fas fa-circle fa-stack-2x""></i>
                        <i class=""fab fa-facebook-f fa-stack-1x""></i>
                    </a>
                </span>
                <span class=""fa-stack"">
                    <a href=""https://www.instagram.com/cisepservices/"" target=""_blank"">
                        <i class=""fas fa-circle fa-stack-2x""></i>
                        <i class=""fab fa-instagram fa-stack-1x""></i>
                    </a>
                </span>
                <span class=""fa-stack"">
                    <a href=""tel:+1 256-200-9773"">
                        <i class=""fas fa-circle fa-stack-2x""></i>
                        <i class=""fas fa-phone fa-stack-1x""></i>
                    </a>
                </span>

               
            </span>
        </div>
    </nav> <!-- end of navbar -->
<!-- end of navbar -->");
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