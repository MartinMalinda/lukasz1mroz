#pragma checksum "C:\Users\Lukasz\source\repos\BankOfSimba\BankOfSimba\Views\Home\String.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e694372725b45ede4b655d2f3a4442a4ad0a98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_String), @"mvc.1.0.view", @"/Views/Home/String.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/String.cshtml", typeof(AspNetCore.Views_Home_String))]
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
#line 1 "C:\Users\Lukasz\source\repos\BankOfSimba\BankOfSimba\Views\_ViewImports.cshtml"
using BankOfSimba;

#line default
#line hidden
#line 2 "C:\Users\Lukasz\source\repos\BankOfSimba\BankOfSimba\Views\_ViewImports.cshtml"
using BankOfSimba.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e694372725b45ede4b655d2f3a4442a4ad0a98", @"/Views/Home/String.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"862ac1b1182d9c7716cb92864d9b80dcc2fea1c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_String : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(7, 12, false);
#line 2 "C:\Users\Lukasz\source\repos\BankOfSimba\BankOfSimba\Views\Home\String.cshtml"
Write(ViewBag.Text);

#line default
#line hidden
            EndContext();
            BeginContext(19, 11, true);
            WriteLiteral("</h1>\r\n<h1>");
            EndContext();
            BeginContext(31, 23, false);
#line 3 "C:\Users\Lukasz\source\repos\BankOfSimba\BankOfSimba\Views\Home\String.cshtml"
Write(Html.Raw(@ViewBag.Text));

#line default
#line hidden
            EndContext();
            BeginContext(54, 5, true);
            WriteLiteral("</h1>");
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
