#pragma checksum "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5323a02c2513b69f11ac88e845b7049b19f770a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\_ViewImports.cshtml"
using MyShop.Web;

#line default
#line hidden
#line 2 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\_ViewImports.cshtml"
using MyShop.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5323a02c2513b69f11ac88e845b7049b19f770a2", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26bea9f67ef5767e1019593b1af5c2f5412cf531", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyShop.Domain.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "All orders";

#line default
#line hidden
            BeginContext(91, 18, true);
            WriteLiteral("\n<h1>Orders</h1>\n\n");
            EndContext();
#line 9 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
            BeginContext(141, 260, true);
            WriteLiteral(@"    <div class=""row mb-lg-5"">
        <div class=""col-lg-8"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Order #</span>
                <span class=""badge badge-secondary badge-pill"">");
            EndContext();
            BeginContext(402, 13, false);
#line 15 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
                                                          Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(415, 62, true);
            WriteLiteral("</span>\n            </h4>\n            <ul class=\"list-group\">\n");
            EndContext();
#line 18 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
                 foreach (var item in order.LineItems)
                {

#line default
#line hidden
            BeginContext(550, 168, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\n                        <div>\n                            <h6 class=\"my-0\">");
            EndContext();
            BeginContext(719, 17, false);
#line 22 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
                                        Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(736, 70, true);
            WriteLiteral("</h6>\n                            <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(807, 13, false);
#line 23 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
                                                           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(820, 90, true);
            WriteLiteral("</small>\n                        </div>\n                        <span class=\"text-muted\">$");
            EndContext();
            BeginContext(912, 34, false);
#line 25 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
                                              Write(item.Product.Price * item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(947, 34, true);
            WriteLiteral("</span>\n                    </li>\n");
            EndContext();
#line 27 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(999, 151, true);
            WriteLiteral("\n                <li class=\"list-group-item d-flex justify-content-between\">\n                    <span>Total (USD)</span>\n                    <strong>$");
            EndContext();
            BeginContext(1151, 16, false);
#line 31 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
                        Write(order.OrderTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 76, true);
            WriteLiteral("</strong>\n                </li>\n            </ul>\n        </div>\n    </div>\n");
            EndContext();
#line 36 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPatternFinal\MyShop.Web\Views\Order\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyShop.Domain.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591