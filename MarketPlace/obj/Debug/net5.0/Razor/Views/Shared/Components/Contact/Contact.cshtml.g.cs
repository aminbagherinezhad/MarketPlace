#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833720b951e640b20936c6f6be44c349d2d0fb90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Contact_Contact), @"mvc.1.0.view", @"/Views/Shared/Components/Contact/Contact.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
using MarketPlace.Application.EntitiesExtensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833720b951e640b20936c6f6be44c349d2d0fb90", @"/Views/Shared/Components/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657e07ab3d928f0c60b0e1b636ef14cd4ab6a754", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MarketPlace.DataLayer.Entities.Mazholar.Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
 if (Model != null && Model.Any())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
     foreach (var slider in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"contact_message content\">\r\n            <h3>???????? ???? ????</h3>\r\n            <p>");
#nullable restore
#line 11 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
          Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <ul>\r\n                <li><i class=\"fa fa-fw fa-map-marker\"></i> ");
#nullable restore
#line 13 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
                                                      Write(slider.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><i class=\"fa fa-fw fa-phone\"></i> <span class=\"ltr-text\">+(98) ");
#nullable restore
#line 14 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
                                                                              Write(slider.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
            WriteLiteral("</li>\r\n                <li><i class=\"fa fa-fw fa-envelope-o\"></i> <a href=\"#\">");
#nullable restore
#line 15 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
                                                                  Write(slider.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            </ul>\r\n        </div>\r\n");
#nullable restore
#line 18 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\Contact\Contact.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MarketPlace.DataLayer.Entities.Mazholar.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
