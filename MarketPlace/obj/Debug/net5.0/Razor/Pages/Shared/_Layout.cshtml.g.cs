#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "519db5a3e0cb0b21269421e5df62fac56cd38b6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519db5a3e0cb0b21269421e5df62fac56cd38b6f", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a7659e4f2a3abbe29b190a96643a5f77775fe4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "519db5a3e0cb0b21269421e5df62fac56cd38b6f3061", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <title>?????? ???????????? ???????? </title>

    <!-- Core CSS - Include with every page -->
    <link href=""/AdminContent/css/bootstrap-rtl.css"" rel=""stylesheet"">
    <link href=""/AdminContent/font-awesome/css/font-awesome.css"" rel=""stylesheet"">

    <!-- Page-Level Plugin CSS - Dashboard -->
    <link href=""/AdminContent/css/plugins/morris/morris-0.4.3.min.css"" rel=""stylesheet"">
    <link href=""/AdminContent/css/plugins/timeline/timeline.css"" rel=""stylesheet"">

    <!-- SB Admin CSS - Include with every page -->
    <link href=""/AdminContent/css/sb-admin.css"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "519db5a3e0cb0b21269421e5df62fac56cd38b6f4756", async() => {
                WriteLiteral(@"

    <div id=""wrapper"">

        <nav class=""navbar navbar-default navbar-fixed-top"" role=""navigation"" style=""margin-bottom: 0"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".sidebar-collapse"">
                    <span class=""sr-only"">?????? ???????? ??????</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""/Admin"">???????? ????????????????</a>
            </div>
            <!-- /.navbar-header -->



            <div class=""navbar-default navbar-static-side"" role=""navigation"">
                <div class=""sidebar-collapse"">
                    <ul class=""nav"" id=""side-menu"">
");
                WriteLiteral(@"                        <li>
                            <a href=""/Admin"">?????? ??????????</a>
                        </li>
                        <li>
                            <a href=""/user"">?????? ????????????</a>
                        </li>
                      
                        <li>
                            <a href=""/admin/Contacts"">???????? ???? ????</a>
                        </li>
                        <li>
                            <a href=""/admin/Blogs"">???????? ????????</a>
                        </li>
                        <li>
                            <a href=""/admin/ContactText"">???????? ???? ???? ??????????</a>
                        </li>

                        <li>
                            <a href=""/admin/Products""> ??????????????</a>
                        </li>
                        <li>
                            <a href=""/admin/Licesis"">???????? ????</a>
                        </li>
                        <li>
                            <a href=""/admin/Logos"">????????</a>
           ");
                WriteLiteral(@"             </li>

                        <li>
                            <a href=""/admin/TBasket""> ?????????? ?????? ?????? ???????? ???? ???????? ????????</a>
                        </li>
                        <li>
                            <a href=""/admin/MessageTicket"">?????? ???????? ????</a>
                        </li>
                        <li>
                            <a href=""/admin/OrderDetails"">???????????? ??????????</a>
                        </li>
                        <li>
                            <a href=""/admin/Orders""> ??????????</a>
                        </li>
                        <li>
                            <a href=""/admin/Properties"">?????????? ?????? ????????</a>
                        </li>
                        <li>
                            <a href=""/admin/Sellers"">??????????????</a>
                        </li>
                        <li>
                            <a href=""/admin/SiteBanners"">??????????</a>
                        </li>
                        <li>
                            ");
                WriteLiteral(@"<a href=""/admin/Sliders"">??????????????</a>
                        </li>
                        <li>
                            <a href=""/admin/Socials"">???????? ??????????????</a>
                        </li>
                        <li>
                            <a href=""/admin/Tickets"">???????? ????</a>
                        </li>

                        <li>
                            <a href=""/admin/contactsetting"">???????? ???? ???? ???? ???????? ???????? ?? ?????? ???????? ???? ????</a>
                        </li>
                        <li>
                            <a href=""/admin/Users"">??????????????</a>
                        </li>
                        <li>
                            <a href=""/admin/WalletSellers"">?????? ??????</a>
                        </li>
                    </ul>
                    <!-- /#side-menu -->
                </div>
                <!-- /.sidebar-collapse -->
            </div>
            <!-- /.navbar-static-side -->
        </nav>

        <div id=""page-wrapper"">
            ");
#nullable restore
#line 132 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->
    <!-- Core Scripts - Include with every page -->
    <script src=""/AdminContent/js/jquery-1.10.2.js""></script>
    <script src=""/AdminContent/js/bootstrap.min.js""></script>
    <script src=""/AdminContent/js/plugins/metisMenu/jquery.metisMenu.js""></script>

    <!-- Page-Level Plugin Scripts - Dashboard -->
    <script src=""/AdminContent/js/plugins/morris/raphael-2.1.0.min.js""></script>
    <script src=""/AdminContent/js/plugins/morris/morris.js""></script>

    <!-- SB Admin Scripts - Include with every page -->
    <script src=""/AdminContent/js/sb-admin.js""></script>

    <!-- Page-Level Demo Scripts - Dashboard - Use for reference -->
    <script src=""/AdminContent/js/demo/dashboard-demo.js""></script>
    ");
#nullable restore
#line 152 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 154 "D:\MarketPlace\MarketPlace\MarketPlace\Pages\Shared\_Layout.cshtml"
Write(RenderSection("jsckeditor", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
