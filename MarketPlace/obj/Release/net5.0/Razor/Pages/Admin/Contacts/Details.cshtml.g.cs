#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ab204c71772213981927bafb3042b5b279e713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Contacts_Details), @"mvc.1.0.razor-page", @"/Pages/Admin/Contacts/Details.cshtml")]
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
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\_ViewImports.cshtml"
using MarketPlace.Application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ab204c71772213981927bafb3042b5b279e713", @"/Pages/Admin/Contacts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a7659e4f2a3abbe29b190a96643a5f77775fe4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Contacts_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
  
    ViewData["Title"] = "????????????";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"main_content_area\">\r\n    <div class=\"container\">\r\n        <div class=\"account_dashboard\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12 col-md-3 col-lg-3\">\r\n                    ");
#nullable restore
#line 15 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
               Write(await Component.InvokeAsync("SideBarAdmin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                <div class=""col-sm-12 col-md-9 col-lg-9"">
                    <!-- Tab panes -->
                    <div class=""tab-content dashboard_content"">

                        <h2>????????????</h2>

                        <div>
                            <h4>???????? ???? ????</h4>
                            <hr />
                            <dl class=""dl-horizontal"">
                                <dt>
                                    ");
#nullable restore
#line 29 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ContactUs.UserIp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 32 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContactUs.UserIp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 35 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ContactUs.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 38 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContactUs.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 41 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ContactUs.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 44 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContactUs.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 47 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ContactUs.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 50 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContactUs.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 53 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ContactUs.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 56 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContactUs.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 59 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ContactUs.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 62 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContactUs.User.EmailActiveCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt>\r\n                                    ");
#nullable restore
#line 65 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ContactUs.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd>\r\n                                    ");
#nullable restore
#line 68 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ContactUs.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n\r\n                            </dl>\r\n                        </div>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ab204c71772213981927bafb3042b5b279e71310448", async() => {
                WriteLiteral("????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Contacts\Details.cshtml"
                                                   WriteLiteral(Model.ContactUs.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ab204c71772213981927bafb3042b5b279e71312644", async() => {
                WriteLiteral("?????????? ???? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarketPlace.Pages.Admin.Contacts.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarketPlace.Pages.Admin.Contacts.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarketPlace.Pages.Admin.Contacts.DetailsModel>)PageContext?.ViewData;
        public MarketPlace.Pages.Admin.Contacts.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
