#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Views\Home\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc3879e967d7b2287cdd0c4bfcc0980a266c99b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace\Views\_ViewImports.cshtml"
using MarketPlace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace\Views\_ViewImports.cshtml"
using MarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace\Views\_ViewImports.cshtml"
using MarketPlace.Application.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Home\AboutUs.cshtml"
using MarketPlace.DataLayer.Entities.Abouts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3879e967d7b2287cdd0c4bfcc0980a266c99b5", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657e07ab3d928f0c60b0e1b636ef14cd4ab6a754", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Home\AboutUs.cshtml"
  
    ViewData["Title"] = "درباره ما";
    var Basket = ViewData["result"] as List<About>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb_content"">
                    <ul>
                        <li><a href=""/home"">خانه</a></li>
                        <li>درباره ما</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 22 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Home\AboutUs.cshtml"
 foreach (var item in Basket)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""about_section mt-60"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-12"">
                    <figure>
                        <div class=""about_thumb"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 867, "\"", 895, 2);
            WriteAttributeValue("", 873, "/About/", 873, 7, true);
#nullable restore
#line 30 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 880, item.ImageName, 880, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 896, "\"", 902, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <figcaption class=\"about_content\">\r\n                            <h1>همه چیز درباره ما</h1>\r\n                            <p>\r\n                                ");
#nullable restore
#line 35 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Home\AboutUs.cshtml"
                           Write(Html.Raw(item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </figcaption>\r\n                    </figure>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 43 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Home\AboutUs.cshtml"
}

#line default
#line hidden
#nullable disable
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