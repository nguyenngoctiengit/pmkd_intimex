#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4c9b59c93b413de0f7b0e7a94a6d461aa27f406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartialViewChat), @"mvc.1.0.view", @"/Views/Home/PartialViewChat.cshtml")]
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
#line 1 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\_ViewImports.cshtml"
using Intimex_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\_ViewImports.cshtml"
using Intimex_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c9b59c93b413de0f7b0e7a94a6d461aa27f406", @"/Views/Home/PartialViewChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PartialViewChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Avatar.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
  
    ViewData["Title"] = "chat";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4c9b59c93b413de0f7b0e7a94a6d461aa27f4065573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    .buttonChat {
        text-align: left;
    }

    .text-center {
        text-align: center;
    }

    .btn {
        background-color: #494e52; /* Blue background */
        border: none; /* Remove borders */
        color: white; /* White text */
        padding: 12px 16px; /* Some padding */
        font-size: 16px; /* Set a font size */
        cursor: pointer; /* Mouse pointer on hover */
    }
</style>
<div class=""right_col"" role=""main"" style=""height: 100%"">
    <h3 class=""text-center"">Messing to ");
#nullable restore
#line 26 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                  Write(ViewBag.messingTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    <div class=""messaging"">
        <div class=""inbox_msg"">
            <div class=""inbox_people"">
                <div class=""headind_srch"">
                    <div class=""srch_bar"">
                        <div class=""stylish-input-group"">
                            <input type=""text"" class=""search-bar"" placeholder=""Search"" id=""keySearch"" onkeyup=""Search()"">
                        </div>
                    </div>
                </div>
                <div class=""inbox_chat scroll"">
");
#nullable restore
#line 38 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                       foreach (var item in ViewBag.user)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"buttonChat\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1349, "\"", 1383, 3);
            WriteAttributeValue("", 1359, "location.href=\'", 1359, 15, true);
#nullable restore
#line 40 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 1374, item.Id, 1374, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1382, "\'", 1382, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1384, "\"", 1416, 1);
#nullable restore
#line 40 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 1392, item.NormalizedUserName, 1392, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"padding:0;border:none;background:none\" type=\"submit\">\r\n                                <div class=\"chat_list\">\r\n                                    <div class=\"chat_people\">\r\n\r\n                                        <div class=\"chat_img\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4c9b59c93b413de0f7b0e7a94a6d461aa27f4069512", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1675, "~/Images/", 1675, 9, true);
#nullable restore
#line 44 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
AddHtmlAttributeValue("", 1684, item.Image, 1684, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n                                        <div class=\"chat_ib\">\r\n                                            <h5 id=\"h5\">\r\n                                                ");
#nullable restore
#line 47 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                           Write(item.NormalizedUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                  
                                                    if (item.Online == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"chat_date\">Online</span>\r\n");
#nullable restore
#line 52 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"chat_date\">Offline</span>\r\n");
#nullable restore
#line 56 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </h5>\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </button>\r\n");
#nullable restore
#line 64 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <input type=\"text\" id=\"senderInput\"");
            BeginWriteAttribute("value", " value=\"", 2918, "\"", 2941, 1);
#nullable restore
#line 68 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 2926, ViewBag.sender, 2926, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n            <input type=\"text\" id=\"receiverInput\"");
            BeginWriteAttribute("value", " value=\"", 3003, "\"", 3028, 1);
#nullable restore
#line 69 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 3011, ViewBag.receiver, 3011, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden />
            <div class=""mesgs"">
                <div class=""headind_srch"">
                    <div class=""srch_bar"">
                        <div class=""stylish-input-group"">
                            <input type=""text"" class=""search-bar"" placeholder=""Search"" id=""keySearchMessage"" onkeyup=""SearchMessage()"">
                        </div>
                    </div>
                </div>
                <div class=""msg_history"" id=""msg_history"">
                    <script type=""text/javascript"">
                        function scrollChat() {
                            var msg_history = document.getElementById(""msg_history"");
                            msg_history.scrollTop = msg_history.scrollHeight;
                            document.getElementById('messageInput').focus();
                        }
                        window.addEventListener('load', scrollChat);

                    </script>
                    <div");
            BeginWriteAttribute("class", " class=\"", 4002, "\"", 4010, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 89 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                       foreach (var item in ViewBag.outMsg)
                        {
                            if (item.FromUser == ViewBag.sender && item.ToUser == ViewBag.receiver)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"outgoing_msg\">\r\n                                    <div class=\"sent_msg\">\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 96 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                       Write(item.Message1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <span class=\"time_date\"> ");
#nullable restore
#line 98 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                            Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div> ");
#nullable restore
#line 100 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                       }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"incoming_msg\">\r\n                                    <div class=\"incoming_msg_img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4c9b59c93b413de0f7b0e7a94a6d461aa27f40617157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"received_msg\">\r\n                                        <div class=\"received_withd_msg\">\r\n                                            <p>");
#nullable restore
#line 109 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                          Write(item.Message1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <span class=\"time_date\"> ");
#nullable restore
#line 110 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                                Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div> ");
#nullable restore
#line 113 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                       }

                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""type_msg"">
                    <div class=""input_msg_write"">
                        <input type=""text"" class=""write_msg"" id=""messageInput"" placeholder=""Type a message"" />
                        <button class=""msg_send_btn"" type=""button"" id=""sendButton""><i class=""fa fa-paper-plane-o"" aria-hidden=""true""></i></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c9b59c93b413de0f7b0e7a94a6d461aa27f40619981", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c9b59c93b413de0f7b0e7a94a6d461aa27f40621021", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    document.getElementById('messageInput').addEventListener('keyup', function (event) {
        event.preventDefault();
        if (event.keyCode === 13) {
            document.getElementById('sendButton').click();
        }
    });
    function Search() {
        var searchKey = document.getElementById('keySearch');
        var filter = searchKey.value.toUpperCase();
        var button = document.querySelectorAll('.buttonChat');
        for (var i of button) {
            var item = i.value;
            if (item.toUpperCase().indexOf(filter) > -1) {
                i.style.display = '';
            } else {
                i.style.display = 'none';
            }
        }
    }
    function SearchMessage() {
        var searchKey = document.getElementById('keySearchMessage');
        var filter = searchKey.value.toUpperCase();
        var count = 0;
        $('#msg_history div').each(function () {
            if ($(this).text().search(new RegExp(fil");
            WriteLiteral(@"ter, ""i"")) < 0) {
                $(this).hide();  // MY CHANGE

                // Show the list item if the phrase matches and increase the count by 1
            } else {
                $(this).show(); // MY CHANGE
                count++;
            }
        })
    }
    $('.msg_history').scroll(function () {
        if ($(window).scrollTop() == $(document).height() - $(window).height()) {
            GetDataMessage();
        }
    });
    var pageSize = 10;
    var pageIndex = 2;
    var id = document.getElementById('receiverInput').value;
    var sender = document.getElementById('senderInput').value;
    var receiver = document.getElementById('receiverInput').value;
    function GetDataMessage() {
        $.ajax({
            type: 'GET',
            url: '/home/GetDataMessage',
            data: { ""pageindex"": pageIndex, ""pagesize"": pageSize, ""id"": id },
            dataType: 'json',
            success: function (data) {
                if (data != null) {
             ");
            WriteLiteral(@"       for (var i = 0; i < data.length; i++) {
                        if (data[i].FromUser == sender && data[i].ToUser == receiver) {
                            $('#msg_history').prepend(' <div class=""outgoing_msg"">' +
                                '<div class=""sent_msg"">' +
                                '<p>'
                                + data[i].Message1 +
                                '</p>' +
                                '<span class=""time_date"">' + data[i].Date + '</span>' +
                                '</div>' +
                                '</div>');

                        } else {
                            $('#msg_history').prepend('<div class=""incoming_msg"">' +
                                '<div class=""incoming_msg_img"">' +
                                ' </div>' +
                                '<div class=""received_msg"">' +
                                '<div class=""received_withd_msg"">' +
                                '<p>' + data[i].Message1 + ");
            WriteLiteral(@"'</p>' +
                                '<span class=""time_date"">' + data[i].Date + '</span>' +
                                '</div>' +
                                '</div>' +
                                '</div>');
                        }
                    }
                }
                pageIndex++;
            },
        })
    }
</script>
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