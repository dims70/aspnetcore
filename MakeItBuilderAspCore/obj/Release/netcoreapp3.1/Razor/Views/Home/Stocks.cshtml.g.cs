#pragma checksum "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\Stocks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6efb687992aad36a2a0bbba885cd9c8328008f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Stocks), @"mvc.1.0.view", @"/Views/Home/Stocks.cshtml")]
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
#line 1 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\_ViewImports.cshtml"
using MakeItBuilderAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\_ViewImports.cshtml"
using MakeItBuilderAspCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\Stocks.cshtml"
using MakeItBuilderAspCore.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6efb687992aad36a2a0bbba885cd9c8328008f7", @"/Views/Home/Stocks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf9e10aabf1d133e54742dfad3a3e079f65d3fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Stocks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Stock>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\Stocks.cshtml"
   
    ViewBag.Title = "LOGOS FOOD - Акции";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\Stocks.cshtml"
Write(await Html.PartialAsync("_stocks",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Stock>> Html { get; private set; }
    }
}
#pragma warning restore 1591
