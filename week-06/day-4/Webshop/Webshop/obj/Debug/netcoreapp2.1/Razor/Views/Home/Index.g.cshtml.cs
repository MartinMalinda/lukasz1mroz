#pragma checksum "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "090eae92ed81a48fe7ced39f4f6bc0d490bb7a25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\_ViewImports.cshtml"
using Webshop;

#line default
#line hidden
#line 2 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\_ViewImports.cshtml"
using Webshop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090eae92ed81a48fe7ced39f4f6bc0d490bb7a25", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3007544e27f27aa477c857fed0458ab25934d7c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 223, true);
            WriteLiteral("\r\n    <div>\r\n        <table>\r\n            <tr id=\"names\">\r\n                <td>Name</td>\r\n                <td>Description</td>\r\n                <td>Price</td>\r\n                <td>Quantity of stock</td>\r\n            </tr>\r\n");
            EndContext();
#line 10 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\Home\Index.cshtml"
             foreach (Shopitem item in ViewBag.Items)
             {

#line default
#line hidden
            BeginContext(294, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(341, 9, false);
#line 13 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(350, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(382, 16, false);
#line 14 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\Home\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(398, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(430, 10, false);
#line 15 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\Home\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(440, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(472, 20, false);
#line 16 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\Home\Index.cshtml"
                   Write(item.QuantityOfStock);

#line default
#line hidden
            EndContext();
            BeginContext(492, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 18 "C:\Users\Lukasz\source\repos\Webshop\Webshop\Views\Home\Index.cshtml"
             }

#line default
#line hidden
            BeginContext(538, 29, true);
            WriteLiteral("         </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
