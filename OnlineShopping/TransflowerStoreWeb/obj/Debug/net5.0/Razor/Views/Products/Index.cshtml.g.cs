#pragma checksum "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b40669ca615bb49f6a4b510a709117aeda99a3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\_ViewImports.cshtml"
using TransflowerStoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\_ViewImports.cshtml"
using TransflowerStoreWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
using Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b40669ca615bb49f6a4b510a709117aeda99a3b", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a98b6fc9fbcaa36df3430de3d3a60654378b73", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
        div.gallery {
            margin: 5px;
            border: 1px solid #ccc;
            float: left;
            width: 180px;
        }

        div.gallery:hover {
            border: 1px solid #777;
        }

        div.gallery img {
            width: 100%;
            height: auto;
        }

        div.desc {
            padding: 15px;
            text-align: center;
        }
</style>

");
#nullable restore
#line 26 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Products Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Product Catalog</h1>\r\n</div>\r\n\r\n<h1>Todays Fresh Flowers</h1>\r\n<hr/>\r\n<div>\r\n");
#nullable restore
#line 37 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
     foreach (Product  item in ViewData["products"] as List<Product>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>  \r\n\r\n       <!-- <p>");
#nullable restore
#line 41 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>   \r\n        <img src=\"");
#nullable restore
#line 42 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
             Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" width=\"100\" height=\"100\"/>-->\r\n\r\n        <div class=\"gallery\">\r\n                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 897, "\"", 918, 1);
#nullable restore
#line 45 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
WriteAttributeValue("", 904, item.ImageUrl, 904, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 946, "\"", 966, 1);
#nullable restore
#line 46 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
WriteAttributeValue("", 952, item.ImageUrl, 952, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("   width=\"600\" height=\"400\">\r\n                </a>\r\n                <div class=\"desc\">\r\n                    ");
#nullable restore
#line 49 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |<a");
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1123, 2);
            WriteAttributeValue("", 1097, "/products/details/", 1097, 18, true);
#nullable restore
#line 49 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
WriteAttributeValue("", 1115, item.Id, 1115, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n                </div>\r\n        </div>\r\n      \r\n  </div>\r\n");
#nullable restore
#line 54 "D:\TAP\DotnetCore\Day_23\OnlineShopping\TransflowerStoreWeb\Views\Products\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
