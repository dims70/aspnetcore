#pragma checksum "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ccd4a0301a1d589fa5269c11e85fbceb6c07653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Dishes), @"mvc.1.0.view", @"/Views/Shared/_Dishes.cshtml")]
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
#line 1 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\_ViewImports.cshtml"
using MakeItBuilderAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\_ViewImports.cshtml"
using MakeItBuilderAspCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccd4a0301a1d589fa5269c11e85fbceb6c07653", @"/Views/Shared/_Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf9e10aabf1d133e54742dfad3a3e079f65d3fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MakeItBuilderAspCore.Models.Entities.Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"swiper-wrapper product-list__swiper-wrapper\">\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"product-list__swiper-slide swiper-slide\">\r\n            <div class=\"card\">\r\n                <div class=\"card__count\">1</div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 326, "\"", 346, 1);
#nullable restore
#line 8 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
WriteAttributeValue("", 332, item.urlToImg, 332, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__img\" alt=\"card-image\">\r\n                <div class=\"card__center\">\r\n                    <h3 class=\"card__title\">\r\n                        <a href=\"#\">");
#nullable restore
#line 11 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> <span>Вес: ");
#nullable restore
#line 11 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
                                                         Write(item.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" г</span>\r\n                    </h3>\r\n                    <p class=\"card__text\">\r\n                        ");
#nullable restore
#line 14 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"card__end\">\r\n                    <button class=\"card__btn card__btn--count card__btn--minus\" data-id=\"");
#nullable restore
#line 18 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
                                                                                    Write(item._id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i class=\"icon card__icon icon-minus\"></i>\r\n                    </button>\r\n                    <p class=\"card__price\"><span data-price=\"620\">");
#nullable restore
#line 21 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ₽</p>\r\n                    <button class=\"card__btn card__btn--basket\"  data-id=\"");
#nullable restore
#line 22 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
                                                                     Write(item._id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <span>В корзину</span>\r\n                        <i class=\"icon icon-buy\"></i>\r\n                    </button>\r\n                    <button class=\"card__btn card__btn--count card__btn--plus\" data-id=\"");
#nullable restore
#line 26 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
                                                                                   Write(item._id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i class=\"icon card__icon icon-plus\"></i>\r\n                    </button>\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 32 "C:\Users\user\source\repos\aspnetcore\MakeItBuilderAspCore\Views\Shared\_Dishes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MakeItBuilderAspCore.Models.Entities.Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
