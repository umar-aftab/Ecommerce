#pragma checksum "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3967556c0159d21c3e5fd3af54011d406907e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards_CustomerForumSubscriptions), @"mvc.1.0.view", @"/Views/Boards/CustomerForumSubscriptions.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\websites\nopDemp\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3967556c0159d21c3e5fd3af54011d406907e37", @"/Views/Boards/CustomerForumSubscriptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Boards_CustomerForumSubscriptions : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CustomerForumSubscriptionsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "CustomerForumSubscriptions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
      
    Layout = "_ColumnsTwo";

    //title
    Html.AddTitleParts(T("PageTitle.ForumSubscriptions").Text);
    //page class
    Html.AppendPageCssClassParts("html-account-page");
    Html.AppendPageCssClassParts("html-forum-subscriptions-page");

#line default
#line hidden
#nullable disable
            DefineSection("left", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
Write(await Component.InvokeAsync("CustomerNavigation",new { selectedTabId = CustomerNavigationEnum.ForumSubscriptions }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"page account-page forum-subscriptions-page\">\r\n    <div class=\"page-title\">\r\n        <h1>");
#nullable restore
#line 17 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
       Write(T("Account.MyAccount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                                 Write(T("Account.ForumSubscriptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"page-body\">\r\n");
#nullable restore
#line 20 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
         if (Model.ForumSubscriptions.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"description\">\r\n                ");
#nullable restore
#line 23 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
           Write(T("Account.ForumSubscriptions.Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3967556c0159d21c3e5fd3af54011d406907e3711091", async() => {
                WriteLiteral(@"
                $(document).ready(function () {
                    $('#selectall').on('click', function () {
                        $('.subscription-list .rowcheckbox').prop('checked', $(this).is(':checked')).trigger('change');
                    });

                    $('.subscription-list .rowcheckbox').on('change', function (e) {
                        var numChkBoxes = $('.subscription-list .rowcheckbox').length;
                        var numChkBoxesChecked = $('.subscription-list .rowcheckbox:checked').length;
                        $('#selectall').prop('checked', numChkBoxes == numChkBoxesChecked && numChkBoxes > 0);
                    });
                });
            ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 25 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3967556c0159d21c3e5fd3af54011d406907e3713283", async() => {
                WriteLiteral(@"
                <div class=""subscription-list"">
                    <div class=""table-wrapper"">
                        <table class=""data-table"">
                            <colgroup>
                                <col width=""1"" />
                                <col />
                            </colgroup>
                            <thead>
                            <tr>
                                <th class=""select-boxes"">
                                    <input type=""checkbox"" id=""selectall"" />
                                </th>
                                <th class=""info"">
                                    ");
#nullable restore
#line 52 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                               Write(T("Account.ForumSubscriptions.InfoColumn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 57 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                             for (var i = 0; i < Model.ForumSubscriptions.Count; i++)
                            {
                                var item = Model.ForumSubscriptions[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr ");
#nullable restore
#line 60 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                                Write(i % 2 == 0 ? Html.Raw(" class=\"odd\"") : Html.Raw(" class=\"even\""));

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                                    <td class=\"select-boxes\">\r\n                                        <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 2946, "\"", 2965, 2);
                WriteAttributeValue("", 2953, "fs", 2953, 2, true);
#nullable restore
#line 62 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
WriteAttributeValue("", 2955, item.Id, 2955, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rowcheckbox\" />\r\n                                    </td>\r\n                                    <td class=\"info\">\r\n");
#nullable restore
#line 65 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                                         if (item.TopicSubscription)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                                       Write(Html.RouteLink(item.Title, "TopicSlug", new { Id = item.ForumTopicId, slug = item.Slug }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                                                                                                                                      
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                                       Write(Html.RouteLink(item.Title, "ForumSlug", new { Id = item.ForumId, slug = item.Slug }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                                                                                                                                 
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 75 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 79 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                      
                        var pager = Html.Pager(Model.PagerModel);
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                     if (!string.IsNullOrEmpty(pager.ToHtmlString()))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"pager\">\r\n                            ");
#nullable restore
#line 85 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                       Write(pager);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 87 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"buttons\">\r\n                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 4288, "\"", 4343, 1);
#nullable restore
#line 89 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
WriteAttributeValue("", 4296, T("Account.ForumSubscriptions.DeleteSelected"), 4296, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"button-1 delete-selected-fs-button\" />\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"no-data\">\r\n                ");
#nullable restore
#line 97 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
           Write(T("Account.ForumSubscriptions.NoSubscriptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 99 "D:\websites\nopDemp\Presentation\Nop.Web\Views\Boards\CustomerForumSubscriptions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerForumSubscriptionsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
