#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd1db1fecc049d997e0baad230719c085d3d216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SiteFooter_SiteFooter), @"mvc.1.0.view", @"/Views/Shared/Components/SiteFooter/SiteFooter.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
using MarketPlace.DataLayer.Entities.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
using MarketPlace.DataLayer.Entities.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd1db1fecc049d997e0baad230719c085d3d216", @"/Views/Shared/Components/SiteFooter/SiteFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657e07ab3d928f0c60b0e1b636ef14cd4ab6a754", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SiteFooter_SiteFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
  
    var siteSetting = ViewBag.siteSetting as SiteSetting;
    //var user = ViewBag.user as User;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--footer area start-->
<footer class=""footer_widgets"">
    <div class=""footer_top"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-6"">
                    <div class=""widgets_container contact_us"">
                        <div class=""footer_logo"">
                            ");
#nullable restore
#line 17 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                       Write(await Component.InvokeAsync("Logo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"footer_contact\">\r\n                            <p>");
#nullable restore
#line 20 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                          Write(siteSetting.FooterText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><span>????????: </span>");
#nullable restore
#line 21 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                                             Write(siteSetting.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                             if (!string.IsNullOrEmpty(siteSetting.Mobile))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>\r\n                                    <span>????????????: </span>\r\n");
#nullable restore
#line 26 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                                     foreach (var mobile in siteSetting.Mobile.Split('-'))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"ltr-text\"");
            BeginWriteAttribute("href", " href=\"", 1253, "\"", 1271, 2);
            WriteAttributeValue("", 1260, "tel:", 1260, 4, true);
#nullable restore
#line 28 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
WriteAttributeValue("", 1264, mobile, 1264, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                                                                          Write(mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral(",");
#nullable restore
#line 30 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                                                      
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\r\n");
#nullable restore
#line 33 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p><span>????????????????: </span><a target=\"_blank\" href=\"#\">");
#nullable restore
#line 34 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                                                                             Write(siteSetting.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2 col-md-6 col-sm-6"">
                    <div class=""widgets_container widget_menu"">
                        <h3>??????????????</h3>
                        <div class=""footer_menu"">
                            <ul>
                                <li><a href=""/About-Us"">???????????? ????</a></li>
");
            WriteLiteral(@"                                <li><a href=""/contact-us"">???????? ???? ????</a></li>
                                <li><a href=""/products"">??????????????</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 51 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                 if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-2 col-md-6 col-sm-6"">
                        <div class=""widgets_container widget_menu"">
                            <h3>???????? ????????????</h3>
                            <div class=""footer_menu"">
                                <ul>
                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd1db1fecc049d997e0baad230719c085d3d21611415", async() => {
                WriteLiteral(" ?????? ?????? ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd1db1fecc049d997e0baad230719c085d3d21612825", async() => {
                WriteLiteral(" ???????? ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 64 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-2 col-md-6 col-sm-6"">
                        <div class=""widgets_container widget_menu"">
                            <h3>???????? ????????????</h3>
                            <div class=""footer_menu"">
                                <ul>

                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd1db1fecc049d997e0baad230719c085d3d21614922", async() => {
                WriteLiteral(" ");
                WriteLiteral("?????? ???????????? ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd1db1fecc049d997e0baad230719c085d3d21616570", async() => {
                WriteLiteral(" ???????? ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 79 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-md-6"">
                    <div class=""widgets_container newsletter"">
                        <h3>???? ???? ?????????? ????????</h3>
                        <div class=""footer_social_link"">
                            <ul>
                                ");
#nullable restore
#line 85 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                           Write(await Component.InvokeAsync("Social"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </ul>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""footer_bottom"">
                            <div class=""container"">
                                <div class=""row align-items-center"">
                                    <div class=""col-lg-6 col-md-6"">
                                        <div class=""copyright_area"">
                                            <p>");
#nullable restore
#line 110 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                                          Write(siteSetting.CopyRight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    ");
#nullable restore
#line 113 "D:\MarketPlace\MarketPlace\MarketPlace\Views\Shared\Components\SiteFooter\SiteFooter.cshtml"
                               Write(await Component.InvokeAsync("Lices"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <!---TODO: Lices-->
</footer>
<!--footer area end-->
");
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
