#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85243ae8d17a471bd24f6b629ba3f94f7102da40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Sliders_Delete), @"mvc.1.0.razor-page", @"/Pages/Admin/Sliders/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85243ae8d17a471bd24f6b629ba3f94f7102da40", @"/Pages/Admin/Sliders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a7659e4f2a3abbe29b190a96643a5f77775fe4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Sliders_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
  
    ViewData["Title"] = "حذف";
     Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"main_content_area\">\r\n    <div class=\"container\">\r\n        <div class=\"account_dashboard\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12 col-md-3 col-lg-3\">\r\n                    ");
#nullable restore
#line 15 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
               Write(await Component.InvokeAsync("SideBarAdmin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                <div class=""col-sm-12 col-md-9 col-lg-9"">
                    <!-- Tab panes -->
                    <div class=""tab-content dashboard_content"">

<h2>حذف</h2>

<h3>آیا از پاک کردن این بلاگ مطمئن هستین ؟</h3>
<div>
    <h4>اسلایدر</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
#nullable restore
#line 30 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.MainHeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 33 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.MainHeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 36 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.SecondHeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 39 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.SecondHeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 42 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 45 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 48 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 51 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 54 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 57 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 60 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 63 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 66 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 69 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 72 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 75 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 78 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Slider.LastUpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 81 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Slider.LastUpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85243ae8d17a471bd24f6b629ba3f94f7102da4010773", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85243ae8d17a471bd24f6b629ba3f94f7102da4011040", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 86 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Sliders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Slider.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85243ae8d17a471bd24f6b629ba3f94f7102da4012827", async() => {
                    WriteLiteral("برگشت به لیست");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n         </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarketPlace.Pages.Admin.Sliders.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarketPlace.Pages.Admin.Sliders.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarketPlace.Pages.Admin.Sliders.DeleteModel>)PageContext?.ViewData;
        public MarketPlace.Pages.Admin.Sliders.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
