#pragma checksum "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c76aa50c67f0a9a94d3cdf2ab07c9ebbde44cfa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserHistory), @"mvc.1.0.view", @"/Views/User/UserHistory.cshtml")]
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
#line 1 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76aa50c67f0a9a94d3cdf2ab07c9ebbde44cfa4", @"/Views/User/UserHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>");
#nullable restore
#line 3 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<table class=\"table\">\n    <thead>\n        <tr>\n          <th>Date</th>\n          <th>Location</th>  \n          <th>Cost</th>                              \n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 13 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
 if(Model != null)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
   foreach (var item in @Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n      <td>\n        ");
#nullable restore
#line 18 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
   Write(DateTime.Now.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </td>\n      <td>\n        ");
#nullable restore
#line 21 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
   Write(item.Store.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </td>\n      <td>\n        ");
#nullable restore
#line 24 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
   Write(item.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </td>\n    </tr>\n");
#nullable restore
#line 27 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
   
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\n      <td>\n        \"N/A\"\n      </td>\n      <td>\n        \"N/A\"\n      </td>\n      <td>\n        \"N/A\"\n      </td>\n    </tr>\n");
#nullable restore
#line 42 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/User/UserHistory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\n</table>\n\n<a href=\"/order/SelectStore\" class=\"btn btn-primary\" role=\"button\">Begin your order</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
