#pragma checksum "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\TermsDelivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445488e979a3299583718a08221356d21142107e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TermsDelivery), @"mvc.1.0.view", @"/Views/Home/TermsDelivery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445488e979a3299583718a08221356d21142107e", @"/Views/Home/TermsDelivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf9e10aabf1d133e54742dfad3a3e079f65d3fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TermsDelivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\TermsDelivery.cshtml"
  
    ViewBag.Title = "Условия доставки";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""delivery del"" style=""margin-top:20px"">
    <div class=""del__container container"">
        <h2 class=""h2-title del__title"">Условия доставки</h2>
        <div class=""del__left"">
            <div id=""accordion"" class=""acc"">
                <h3 class=""acc__button"">У наших курьеров всегда должна быть сдача!</h3>
                <div class=""acc__content"">
                    Мы очень внимательно следим за качеством нашей работы, поэтому, если у вас будут какие-либо замечания или предложения, то обязательно сообщайте их нам
                </div>
                <h3 class=""acc__button"">Вам что-то не довезли?</h3>
                <div class=""acc__content"">
                    Мы очень внимательно следим за качеством нашей работы, поэтому, если у вас будут какие-либо замечания или предложения, то обязательно сообщайте их нам
                </div>
                <h3 class=""acc__button"">Не понравился продукт?</h3>
                <div class=""acc__content"">
                    Мы очень вн");
            WriteLiteral(@"имательно следим за качеством нашей работы, поэтому, если у вас будут какие-либо замечания или предложения, то обязательно сообщайте их нам
                </div>
                <h3 class=""acc__button"">Если появились замечания</h3>
                <div class=""acc__content"">
                    Мы очень внимательно следим за качеством нашей работы, поэтому, если у вас будут какие-либо замечания или предложения, то обязательно сообщайте их нам
                </div>
                <h3 class=""acc__button"">Оплата Visa, MasterCard и МИР</h3>
                <div class=""acc__content"">
                    Мы очень внимательно следим за качеством нашей работы, поэтому, если у вас будут какие-либо замечания или предложения, то обязательно сообщайте их нам
                </div>
                <h3 class=""acc__button"">Реквизиты</h3>
                <div class=""acc__content"">
                    Мы очень внимательно следим за качеством нашей работы, поэтому, если у вас будут какие-либо замечания или предло");
            WriteLiteral(@"жения, то обязательно сообщайте их нам
                </div>
            </div>
        </div>
        <div class=""del__right del__map-img"">
            <div class=""img""></div>
        </div>
        <div class=""del__time"">
            <p class=""del__text-block"">
                <b>График работы доставки:</b>
                <span>с 10:00-21:00</span>
            </p>
            <p class=""del__text-block"">
                <b>График работы кафе:</b>
                <span>с 08:00-21:00</span>
            </p>
        </div>
        <div class=""del__info del__text-block"">
            <b>Минимальный заказ:</b>
            <span>
                Бесплатная доставка пешим курьером при сумме заказа от 400 ₽
                Доставка оператором такси от любой суммы заказа - по тарифам
                перевозчика.
            </span>
        </div>

    </div>

</section>
");
#nullable restore
#line 61 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\TermsDelivery.cshtml"
 if (!Context.Request.Cookies.Keys.Contains("deliveryModalHide"))
{
    

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral(@"
        <script>
            // Проверка доставки на время - режим работы доставки 10ч-21ч
            (() => {
                let currDate = new Date();
                if (currDate.getHours() > 21 || currDate.getHours() < 10)
                    $(""#dialog"").dialog({
                        modal: true,
                        resizable: false,
                        draggable: false,
                        classes: {
                            ""ui-dialog"": ""delivery_time_no""
                        },
                        close: function () {
                            document.cookie = `${encodeURIComponent(""deliveryModalHide"")}=${encodeURIComponent(1)}; max-age=36000`;
                        }
                    });
            })();
        </script>
    ");
            }
            );
            DefineSection("modalDeliveryNo", async() => {
                WriteLiteral("\r\n        <div id=\"dialog\" title=\"Не доставляется\">\r\n            <p>Доставка сейчас не работает (10:00-21:00) <span style=\"font-size:20px\">:(</span></p>\r\n        </div>\r\n    ");
            }
            );
#nullable restore
#line 87 "C:\Users\Dimas\source\repos\MakeItBuilderAspCore\aspnetcore\MakeItBuilderAspCore\Views\Home\TermsDelivery.cshtml"
     
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
