#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e", @"/Views/Home/PartialViewChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PartialViewChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/emojiPicker/jquery1.emojipicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/emojiPicker/jquery.emojipicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/emojiPicker/jquery.emojipicker.tw.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/emojiPicker/jquery.emojis.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ChatPartialView.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/notify.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Avatar.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!--EmojiOneArea -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e7504", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e8618", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e9657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e10771", async() => {
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
            WriteLiteral("\r\n<!--css chat -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e11831", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e12946", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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

    .emojionearea-button {
        margin-top: 50px;
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
<script>
    $(function () {
        $(""#messageInput1"").emojiPicker({
            position: 'right'

        });
        document.getElementById('messageInput1').style.width = '100%';
    });
</script>
<div class=""right_col"" role=""main"" style=""height: 100%"">
    <div");
            BeginWriteAttribute("class", " class=\"", 1352, "\"", 1360, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h3 class=\"text-center\">Messing to ");
#nullable restore
#line 49 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
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
#line 61 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                           foreach (var item in ViewBag.user)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"buttonChat\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2133, "\"", 2189, 3);
            WriteAttributeValue("", 2143, "location.href=\'/home/PartialViewChat/", 2143, 37, true);
#nullable restore
#line 63 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 2180, item.Id, 2180, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2188, "\'", 2188, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2190, "\"", 2222, 1);
#nullable restore
#line 63 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 2198, item.NormalizedUserName, 2198, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""padding:0;border:none;background:none"" type=""submit"">
                                    <div class=""chat_list"">
                                        <div class=""chat_people"">
                                            <div class=""chat_img""> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e17335", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2491, "~/Images/", 2491, 9, true);
#nullable restore
#line 66 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
AddHtmlAttributeValue("", 2500, item.Image, 2500, 11, false);

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
            WriteLiteral(" </div>\r\n                                            <div class=\"chat_ib\">\r\n                                                <h5>\r\n                                                    ");
#nullable restore
#line 69 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                               Write(item.NormalizedUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                      
                                                        if (item.Online == true)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"chat_date\">Online</span>\r\n");
#nullable restore
#line 74 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"chat_date\">Offline</span>\r\n");
#nullable restore
#line 78 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </h5>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </button>\r\n");
#nullable restore
#line 86 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <input type=\"text\" id=\"senderInput\"");
            BeginWriteAttribute("value", " value=\"", 3820, "\"", 3843, 1);
#nullable restore
#line 91 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 3828, ViewBag.sender, 3828, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n                <input type=\"text\" id=\"receiverInput\"");
            BeginWriteAttribute("value", " value=\"", 3909, "\"", 3934, 1);
#nullable restore
#line 92 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 3917, ViewBag.receiver, 3917, 17, false);

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
                                document.getElementById('messageInput1').focus();

                            }
                            window.addEventListener('load', scrollChat);

                        </script>
    ");
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 4983, "\"", 4991, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 113 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                           foreach (var item in ViewBag.outMsg)
                            {
                                if (item.FromUser == ViewBag.sender && item.ToUser == ViewBag.receiver)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"outgoing_msg\">\r\n                                        <div class=\"sent_msg\" id=\"sent_msg\">\r\n                                            <p");
            BeginWriteAttribute("onclick", " onclick=\"", 5425, "\"", 5469, 3);
            WriteAttributeValue("", 5435, "DownloadDocument(\'", 5435, 18, true);
#nullable restore
#line 119 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 5453, item.Message1, 5453, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5467, "\')", 5467, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\">\r\n                                                ");
#nullable restore
#line 120 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                           Write(item.Message1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <span class=\"time_date\"> ");
#nullable restore
#line 122 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                                Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 125 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"incoming_msg\">\r\n                                        <div class=\"incoming_msg_img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e25826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"received_msg\">\r\n                                            <div class=\"received_withd_msg\">\r\n                                                <p");
            BeginWriteAttribute("onclick", " onclick=\"", 6357, "\"", 6401, 3);
            WriteAttributeValue("", 6367, "DownloadDocument(\'", 6367, 18, true);
#nullable restore
#line 134 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 6385, item.Message1, 6385, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6399, "\')", 6399, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\">");
#nullable restore
#line 134 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                                                                                  Write(item.Message1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                <span class=\"time_date\"> ");
#nullable restore
#line 135 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                                    Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div> ");
#nullable restore
#line 138 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                           }

                            } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div id=""createDiv_incoming_msg""></div>
                        <div id=""createDiv_outgoing_msg""></div>
                    </div>
                    <label class=""custom-file-upload"">
                        <input type=""file"" id=""fileUpload"" onchange=""UploadFile(event)"" hidden />
                        <i class=""fa fa-cloud-upload""></i>
                    </label>
                    <div class=""type_msg"">
                        <div class=""input_msg_write"">
                            <input type=""text"" class=""write_msg"" id=""messageInput1"" placeholder=""Type a message"" style=""width:100%""/>
                            <button class=""msg_send_btn"" type=""button"" id=""sendButton1""><i class=""fa fa-paper-plane-o"" aria-hidden=""true""></i></button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- signalr -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e29801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eb79556ac0e8f68a4fb3f61f3f598f34c0e8d9e30841", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
<script type=""text/javascript"">
    document.getElementById('messageInput1').addEventListener('keyup', function (event) {
        event.preventDefault();
        if (event.keyCode === 13) {
            document.getElementById('sendButton1').click();
        }
    });

    function DownloadDocument(id) {
        var extensionFile = [""docx"", ""jpg"", ""jpeg"", ""gif"", ""png"", ""doc"", ""pdf"", ""xls"",
            ""xlsx"", ""xlsm"", ""pptx"", ""pptm"", ""ppt"", ""txt"", ""mp3"", ""mp4"", ""rar"", ""zip""];
        var regex = new RegExp(""([a-zA-Z0-9\s_\\.\-:])+("" + extensionFile.join('|') + "")$"");
        if (!regex.test(id.toLowerCase())) {
            $.notify(""This is not a file. Cannot download !!"", ""error"");
        } else {
            location.href = '/home/DownloadDocument/' + id;
        }
    }

    function Search() {
        var searchKey = document.getElementById('keySearch');
        var filter = searchKey.value.toUpperCase();
        var");
            WriteLiteral(@" button = document.querySelectorAll('.buttonChat');
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
            if ($(this).text().search(new RegExp(filter, ""i"")) < 0) {
                $(this).hide();  // MY CHANGE

                // Show the list item if the phrase matches and increase the count by 1
            } else {
                $(this).show(); // MY CHANGE
                count++;
            }
        })
    }
    $('.msg_history').scroll(function () {
        if ($('.msg_history').scrollTop() == 0) {
            if (GetDataMessage() != 0) {
     ");
            WriteLiteral(@"           GetDataMessage();
                $('.msg_history').scrollTop(30);
            }
        }
    });

    function createLi_message(id,sender, nguoiGui, message) {
        var datetime = new Date().toLocaleString().replace("","", """").replace(/:.. /, "" "");
        var msg = message.replace(/&/g, ""&amp;"").replace(/</g, ""&lt;"").replace(/>/g, ""&gt;"");
        var a = document.createElement('a');
        a.className = 'dropdown-item';
        a.href = '/home/GetPageFromNotification/' + id;
        a.innerHTML = '<span class=""image""><img src=""/public/images/img.jpg"" alt=""Profile Image"" /></span>' +
            '<span>' +
            '<span>' + nguoiGui + '</span>' +
            '<span class=""time"" style=""text-align:right;"">' + datetime + '</span>' +
            '</span>' +
            '<span class=""message"">' +
            msg +
            '</span>';
        document.getElementById(""messageIncoming"").appendChild(a);
    }

    function updateNotification() {
        $('#messageIncomi");
            WriteLiteral(@"ng').empty();
        $.ajax({
            type: 'GET',
            url: '/home/GetNotification',
            success: function (respone) {
                $.each(respone, function (index, value) {
                    var FromUser = document.getElementById('senderInput').value;
                    console.log(value);
                    if (FromUser == value.FromUser) {

                    } else {
                        var FromUser = document.getElementById('receiverInput').value;
                        createLi_message(value.Id, FromUser, value.FromUser, value.Message1);
                    }

                    
                })
            },
            error: function (error) {
                console.log(error);
            }
        })
    }

    var pageSize = 10;
    var pageIndex = 1;
    var id = document.getElementById('receiverInput').value;
    var sender = document.getElementById('senderInput').value;
    var receiver = document.getElementById('receiverInput'");
            WriteLiteral(@").value;
    function GetDataMessage() {
        $.ajax({
            type: 'GET',
            url: '/home/GetDataMessage',
            data: { ""pageindex"": pageIndex, ""pagesize"": pageSize, ""id"": id },
            dataType: 'json',
            success: function (data) {
                if (data != null) {
                    for (var i = 0; i < data.length; i++) {
                        if (data[i].FromUser == sender && data[i].ToUser == receiver) {
                            $('#msg_history').prepend(' <div class=""outgoing_msg"">' +
                                '<div class=""sent_msg"">' +
                                '<p onclick=""DownloadDocument(\'' + data[i].Message1 + '\')"" style=""cursor: pointer"">'
                                + data[i].Message1 +
                                '</p>' +
                                '<span class=""time_date"">' + data[i].Date + '</span>' +
                                '</div>' +
                                '</div>');

                ");
            WriteLiteral(@"        } else {
                            $('#msg_history').prepend('<div class=""incoming_msg"">' +
                                '<div class=""incoming_msg_img"">' +
                                '<img src=""/Images/Avatar.PNG"" />' +
                                ' </div>' +
                                '<div class=""received_msg"">' +
                                '<div class=""received_withd_msg"">' +
                                '<p onclick=""DownloadDocument(\'' + data[i].Message1 + '\')"" style=""cursor: pointer"">' + data[i].Message1 + '</p>' +
                                '<span class=""time_date"">' + data[i].Date + '</span>' +
                                '</div>' +
                                '</div>' +
                                '</div>');
                        }
                    }

                }

            },
            error: function () {
                alert('Đã load hết dữ liệu chat !!');
            }
        })
        pageIndex++;
    }");
            WriteLiteral("\r\n</script>\r\n");
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
