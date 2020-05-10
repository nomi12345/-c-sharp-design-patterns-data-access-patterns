#pragma checksum "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e06c608dc2e686affa15b0daad5e6ef15becbea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\_ViewImports.cshtml"
using MyShop.Web;

#line default
#line hidden
#line 2 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\_ViewImports.cshtml"
using MyShop.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e06c608dc2e686affa15b0daad5e6ef15becbea", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26bea9f67ef5767e1019593b1af5c2f5412cf531", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyShop.Domain.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "All customers";

#line default
#line hidden
            BeginContext(97, 21, true);
            WriteLiteral("\n<h1>Customers</h1>\n\n");
            EndContext();
#line 9 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
 foreach (var customer in Model)
{

#line default
#line hidden
            BeginContext(153, 265, true);
            WriteLiteral(@"    <div class=""row mb-lg-5"">
        <div class=""col-lg-8"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Customer </span>
                <span class=""badge badge-secondary badge-pill"">");
            EndContext();
            BeginContext(419, 13, false);
#line 15 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
                                                          Write(customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(432, 44, true);
            WriteLiteral("</span>\r\n            </h4>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 476, "\"", 569, 2);
            WriteAttributeValue("", 482, "data:image/jpeg;base64,", 482, 23, true);
#line 17 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
WriteAttributeValue("", 505, System.Text.Encoding.Default.GetString(customer.ProfilePicture), 505, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(570, 55, true);
            WriteLiteral(" width=\"200\" />\r\n            <div>\r\n                <p>");
            EndContext();
            BeginContext(626, 24, false);
#line 19 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
              Write(customer.ShippingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(650, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(676, 13, false);
#line 20 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
              Write(customer.City);

#line default
#line hidden
            EndContext();
            BeginContext(689, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(715, 19, false);
#line 21 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
              Write(customer.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(734, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(760, 16, false);
#line 22 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
              Write(customer.Country);

#line default
#line hidden
            EndContext();
            BeginContext(776, 40, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 816, "\"", 859, 2);
            WriteAttributeValue("", 823, "/Customer/Index/", 823, 16, true);
#line 24 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
WriteAttributeValue("", 839, customer.CustomerId, 839, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(860, 45, true);
            WriteLiteral(">More details</a>\r\n        </div>\n    </div>\n");
            EndContext();
#line 27 "C:\Users\Muhammad.Noman\OneDrive - Bentley Systems, Inc\Desktop\RepositoryPattern\MyShop.Web\Views\Customer\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyShop.Domain.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
