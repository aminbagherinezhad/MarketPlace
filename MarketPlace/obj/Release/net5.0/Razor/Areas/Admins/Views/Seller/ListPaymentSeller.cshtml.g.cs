#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7806fd37fba818b97e2fef279398e8a4492db974"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admins_Views_Seller_ListPaymentSeller), @"mvc.1.0.view", @"/Areas/Admins/Views/Seller/ListPaymentSeller.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\_ViewImports.cshtml"
using MarketPlace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\_ViewImports.cshtml"
using MarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
using MarketPlace.Application.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
using MarketPlace.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
using MarketPlace.DataLayer.Entities.Wallet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
using MarketPlace.DataLayer.Entities.Store;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7806fd37fba818b97e2fef279398e8a4492db974", @"/Areas/Admins/Views/Seller/ListPaymentSeller.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14800691eb5534af4c704351ac5cbd5585008d2", @"/Areas/Admins/Views/_ViewImports.cshtml")]
    public class Areas_Admins_Views_Seller_ListPaymentSeller : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MarketPlace.DataLayer.Entities.Wallet.SellerWallet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_JqueryValidators", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMoneyForSeller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NoItemFound", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListPaymentSeller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filter-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
  
    ViewData["Title"] = "تسویه حساب فروشنده ها";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
    var Sellers = ViewData["Seller"] as List<Seller>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7806fd37fba818b97e2fef279398e8a4492db9747777", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<section class=\"main_content_area\">\r\n    <div class=\"container\">\r\n        <div class=\"account_dashboard\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12 col-md-3 col-lg-3\">\r\n                    ");
#nullable restore
#line 24 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
               Write(await Component.InvokeAsync("SideBarAdmin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                <div class=""col-sm-12 col-md-9 col-lg-9"">
                    <!-- Tab panes -->
                    <div class=""tab-content dashboard_content"">

                        <div class=""tab-pane active show"" id=""account-details"">
                            <h3></h3>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7806fd37fba818b97e2fef279398e8a4492db9749877", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                                <div class=\"table-responsive\">\r\n");
#nullable restore
#line 36 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                     if (Model != null && Model.Any())
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <table class=""table"">
                                            <thead>
                                                <tr>
                                                    <th>شناسه</th>
                                                    <th>واریز/برداشت</th>
                                                    <th>قیمت</th>

                                                    <th>زمان واریزی</th>
                                                    <th>توضیحات</th>
                                                    <th>وضعیت پرداخت</th>
                                                    <th>اسم فروشگاه</th>
                                                    <th>شماهر موبایل</th>
                                                    <th>شماره حساب</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 54 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                 foreach (var wallet in Model)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 57 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                       Write(wallet.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 58 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                         if (wallet.TransactionType != TransactionType.Withdrawal)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <td>\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7806fd37fba818b97e2fef279398e8a4492db97412802", async() => {
                    WriteLiteral("تسویه واریزی");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ajax-url-button", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 61 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
AddHtmlAttributeValue("", 3044, wallet.Id, 3044, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                                                                                                                                                                    WriteLiteral(wallet.Id);

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
                WriteLiteral("\r\n                                                            </td>\r\n");
#nullable restore
#line 63 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <td>");
#nullable restore
#line 64 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                       Write(wallet.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 65 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                       Write(wallet.CreateDate.ToShamsiDateTime());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                                        <td>");
#nullable restore
#line 67 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                       Write(wallet.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 68 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                         if (@wallet.TransactionType == TransactionType.Withdrawal)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <td>با فروشنده تسویه شد</td>\r\n");
#nullable restore
#line 71 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <td>در انتظار تسویه</td>\r\n");
#nullable restore
#line 75 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                                        <td>\r\n\r\n");
#nullable restore
#line 80 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                             foreach (var item in Sellers.Where(s => s.Id == wallet.SellerId))
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <td>");
#nullable restore
#line 82 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                           Write(item.StoreName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 83 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                           Write(item.Mobile);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 84 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                           Write(item.BankNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 85 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"

                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </tr>\r\n");
#nullable restore
#line 89 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n");
#nullable restore
#line 92 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7806fd37fba818b97e2fef279398e8a4492db97421482", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 97 "D:\MarketPlace\MarketPlace\MarketPlace\Areas\Admins\Views\Seller\ListPaymentSeller.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MarketPlace.DataLayer.Entities.Wallet.SellerWallet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
