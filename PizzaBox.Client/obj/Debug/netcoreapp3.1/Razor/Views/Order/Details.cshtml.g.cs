#pragma checksum "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69443a993e06285ade98f8c560f29441b6226dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69443a993e06285ade98f8c560f29441b6226dcf", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml"
  
  decimal total = 0.00M;
  foreach(var c in Model)
  {
    total = total+c.cost;
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Order Details</h2>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n          <th>Crust</th>\n          <th>Size</th>  \n          <th>Cost</th>                              \n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 20 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml"
 foreach (var item in @Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\n    <td>\n      ");
#nullable restore
#line 23 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml"
 Write(item.Crust);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n      ");
#nullable restore
#line 26 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml"
 Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n      ");
#nullable restore
#line 29 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml"
 Write(item.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n  </tr>\n");
#nullable restore
#line 32 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\n    <td>\n      Total\n    </td>\n    <td> \n    </td>\n    <td>\n      ");
#nullable restore
#line 40 "/home/nick/revature_projects/p1/p1-nick-bush/PizzaBox.Client/Views/Order/Details.cshtml"
 Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n  </tr>\n    </tbody>\n</table>\n<a href=\"/order/add\">Add another pizza</a>\n<a href =\"/order/checkout\">Checkout</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
