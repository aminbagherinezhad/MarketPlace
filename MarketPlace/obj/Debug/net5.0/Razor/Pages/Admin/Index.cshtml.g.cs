#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b92d86b64d1187cbcf30dbb156f7dcaca241b687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92d86b64d1187cbcf30dbb156f7dcaca241b687", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a7659e4f2a3abbe29b190a96643a5f77775fe4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SellerRequests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListPaymentSeller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Index.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<div class=""col-lg-12"">

    <div class=""col-lg-4"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                مدیریت محصولات ارسال شده توسط کاربران
            </div>
            <div class=""panel-body"">
                <p>کاربرانی که بعد از ارتقا به سطح فروشندگی محصولات خود را آپلود میکنند از این قسمت محصولات آن ها بررسی میشود</p>
            </div>
            <div class=""panel-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92d86b64d1187cbcf30dbb156f7dcaca241b6875377", async() => {
                WriteLiteral("وارد جزئیات شوید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>


    <div class=""col-lg-4"">
        <div class=""panel panel-info"">
            <div class=""panel-heading"">
                بررسی درخواست های فروشندگی توسط کاربران
            </div>
            <div class=""panel-body"">
                <p>از این قسمت آدمین میتواند کاربرانی که قصد دارند سطح کاربری خود را به فروشندگی ارتقا دهند و محصولات خود را آپلود بکنند مشاهده بکند</p>
            </div>
            <div class=""panel-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92d86b64d1187cbcf30dbb156f7dcaca241b6877463", async() => {
                WriteLiteral("وارد جزئیات شوید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col-lg-4"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                تسویه حساب با فروشندگان
            </div>
            <div class=""panel-body"">
                <p>در این قسمت وضعیت تسویه حساب ها با فروشندگان را آدمین میتواند مشاهده بکنید و با فروشندگان تسویه بکند . اطلاعات فروشندگان قابل مشاهده میبشاد .</p>
            </div>
            <div class=""panel-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92d86b64d1187cbcf30dbb156f7dcaca241b6879546", async() => {
                WriteLiteral("وارد جزئیات شوید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<br />
<br />

<div class=""col-lg-6"">
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            لیست کاربران
        </div>
        <!-- /.panel-heading -->
        <div class=""panel-body"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>نام و نام خانوادگی</th>
                            <th>ایمیل</th>
                            <th>موبایل</th>
                        </tr>
                    </thead>
                    <tbody>
                        ");
#nullable restore
#line 73 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Admin\Index.cshtml"
                   Write(await Component.InvokeAsync("User"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
            <!-- /.table-responsive -->
        </div>
        <!-- /.panel-body -->
    </div>
    <!-- /.panel -->
</div>
<div class=""col-lg-6"">
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            لیست ایتم های مدیریت
        </div>
        <!-- /.panel-heading -->
        <div class=""panel-body"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>عنوان</th>
                            <th>توضیح</th>
                            <th>لینک</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>صفحه تماس با ما</td>
                            <td>مدیریت صفحه تماس با ما</td>
                            <td> <a href=""/admin/Contacts"">تماس با ما</a></td>
          ");
            WriteLiteral(@"              </tr>
                        <tr>
                            <td>مدیریت صفحه بلاگ</td>
                            <td>از این قسمت میتوانید صفحه بلاگ را مدیریت بکنید</td>
                            <td>  <a href=""/admin/Blogs"">صفحه بلاگ</a></td>
                        </tr>
                        <tr>
                            <td>تماس با ما مطالب</td>
                            <td>تماس با ما مطالب</td>
                            <td>  <a href=""/admin/ContactText"">تماس با ما مطالب</a></td>
                        </tr>

                        <tr>
                            <td>محصولات</td>
                            <td>از این بخش میتوانید محصولات را مدیریت بکنید</td>
                            <td><a href=""/admin/Products""> محصولات</a></td>
                        </tr>
                        <tr>
                            <td>مجوز ها</td>
                            <td>از این بخش میتوانید مجوز هارا مدیریت بکنید</td>
                            <td> <a hre");
            WriteLiteral(@"f=""/admin/Licesis"">مجوز ها</a></td>
                        </tr>
                        <tr>
                            <td>لوگو ها</td>
                            <td>از این بخش میتوانید لوگو را مدیریت بکنید</td>
                            <td>  <a href=""/admin/Logos"">لوگو</a></td>
                        </tr>

                        <tr>
                            <td>متن تیکت ها </td>
                            <td>از این بخش میتوانید متن تیکت ها را مدیریت بکنید</td>
                            <td>  <a href=""/admin/MessageTicket"">متن تیکت ها</a></td>
                        </tr>
                        <tr>
                            <td>عنوان های سبد خرید </td>
                            <td>از این بخش میتوانید عنوان های سبد خرید را مدیریت بکنید</td>
                            <td>  <a href=""/admin/TBasket""> عنوان های سبد خرید در صفحه اصلی</a></td>
                        </tr>

                        <tr>
                            <td> جزئیات سفارش </td>
            ");
            WriteLiteral(@"                <td>از این بخش میتوانید جزئیات سفارش را مدیریت بکنید</td>
                            <td> <a href=""/admin/OrderDetails"">جزئیات سفارش</a></td>
                        </tr>
                        <tr>
                            <td> سفارش </td>
                            <td>از این بخش میتوانید سفارش را مدیریت بکنید</td>
                            <td>    <a href=""/admin/Orders""> سفارش</a></td>
                        </tr>
                        <tr>
                            <td> گروه ها و زیر گروه ها </td>
                            <td>از این بخش میتوانید گروه ها و زیر گروه ها را مدیریت بکنید</td>
                            <td>    <a href=""/admin/Category""> گروه ها</a></td>
                        </tr>
                        <tr>
                            <td> ویژگی اول سایت </td>
                            <td>از این بخش میتوانید ویژگی اول سایت را مدیریت بکنید</td>
                            <td> <a href=""/admin/Properties"">ویژگی اول سایت</a></td>
        ");
            WriteLiteral(@"                </tr>
                        <tr>
                            <td> فروشنده </td>
                            <td>از این بخش میتوانید فروشنده را مدیریت بکنید</td>
                            <td><a href=""/admin/Sellers"">فروشنده</a></td>
                        </tr>

                        <tr>
                            <td> بنرها </td>
                            <td>از این بخش میتوانید بنرها را مدیریت بکنید</td>
                            <td>  <a href=""/admin/SiteBanners"">بنرها</a></td>
                        </tr>
                        <tr>
                            <td> اسلایدر </td>
                            <td>از این بخش میتوانید اسلایدر را مدیریت بکنید</td>
                            <td>   <a href=""/admin/Sliders"">اسلایدر</a></td>
                        </tr>

                        <tr>
                            <td> شبکه اجتماعی </td>
                            <td>از این بخش میتوانید شبکه اجتماعی را مدیریت بکنید</td>
                          ");
            WriteLiteral(@"  <td>    <a href=""/admin/Socials"">شبکه اجتماعی</a></td>
                        </tr>

                        <tr>
                            <td> تیکت ها </td>
                            <td>از این بخش میتوانید تیکت ها را مدیریت بکنید</td>
                            <td>  <a href=""/admin/Tickets"">تیکت ها</a></td>
                        </tr>

                        <tr>
                            <td> تماس با ما در قسمت فوتر و صفه تماس با ما </td>
                            <td>از این بخش میتوانید تماس با ما در قسمت فوتر و صفه تماس با ما را مدیریت بکنید</td>
                            <td>  <a href=""/admin/contactsetting"">تماس با ما در قسمت فوتر و صفه تماس با ما</a></td>
                        </tr>

                        <tr>
                            <td>کاربران </td>
                            <td>از این بخش میتوانید کاربران را مدیریت بکنید</td>
                            <td> <a href=""/admin/Users"">کاربران</a></td>
                        </tr>

                     ");
            WriteLiteral(@"   <tr>
                            <td>کیف پول </td>
                            <td>از این بخش میتوانید کیف پول را مدیریت بکنید</td>
                            <td> <a href=""/admin/WalletSellers"">کیف پول</a></td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <!-- /.table-responsive -->
        </div>
        <!-- /.panel-body -->
    </div>
    <!-- /.panel -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DIGIShop.Pages.Admin.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DIGIShop.Pages.Admin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DIGIShop.Pages.Admin.IndexModel>)PageContext?.ViewData;
        public DIGIShop.Pages.Admin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
