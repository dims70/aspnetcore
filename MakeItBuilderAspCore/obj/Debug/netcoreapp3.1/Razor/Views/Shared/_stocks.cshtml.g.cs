#pragma checksum "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\Shared\_stocks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25fd5f68a4681667177c7e36f50c5f373fbf9c83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__stocks), @"mvc.1.0.view", @"/Views/Shared/_stocks.cshtml")]
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
#line 1 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\_ViewImports.cshtml"
using MakeItBuilderAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\_ViewImports.cshtml"
using MakeItBuilderAspCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd5f68a4681667177c7e36f50c5f373fbf9c83", @"/Views/Shared/_stocks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf9e10aabf1d133e54742dfad3a3e079f65d3fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__stocks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MakeItBuilderAspCore.Models.Entities.Stock>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""stock"">
    <div class=""stock__container container"">
        <h2 class=""h2-title del__title stock__title"" style=""margin-top:50px"">АКЦИИ</h2>
        <svg width=""1440"" height=""1"" viewBox=""0 0 1440 1"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
            <line y1=""0.5"" x2=""1440"" y2=""0.5"" stroke=""url(#paint0_linear_72_11)"" />
            <defs>
                <linearGradient id=""paint0_linear_72_11"" x1=""1440"" y1=""1"" x2=""0"" y2=""1"" gradientUnits=""userSpaceOnUse"">
                    <stop stop-color=""white"" stop-opacity=""0"" />
                    <stop offset=""1"" stop-color=""white"" stop-opacity=""0.2"" />
                </linearGradient>
            </defs>
        </svg>

        <ul class=""stock__list"">
");
#nullable restore
#line 16 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\Shared\_stocks.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"stock__item stock-item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 938, "\"", 958, 1);
#nullable restore
#line 19 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\Shared\_stocks.cshtml"
WriteAttributeValue("", 944, item.urlToImg, 944, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\">\r\n                    <a href=\"#\">");
#nullable restore
#line 20 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\Shared\_stocks.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <p>");
#nullable restore
#line 21 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\Shared\_stocks.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span>");
#nullable restore
#line 22 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\Shared\_stocks.cshtml"
                     Write(item.dateExp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n");
#nullable restore
#line 24 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\MakeItBuilderAspCore\Views\Shared\_stocks.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MakeItBuilderAspCore.Models.Entities.Stock>> Html { get; private set; }
    }
}
#pragma warning restore 1591
