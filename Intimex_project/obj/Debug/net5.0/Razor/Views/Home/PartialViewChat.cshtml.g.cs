#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d976b7fa2f90304acbb75c4fdd54ed7d795df73b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d976b7fa2f90304acbb75c4fdd54ed7d795df73b", @"/Views/Home/PartialViewChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PartialViewChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ChatPartialView.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/notify.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Avatar.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!--EmojiOneArea -->\r\n<!--css chat -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d976b7fa2f90304acbb75c4fdd54ed7d795df73b6015", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d976b7fa2f90304acbb75c4fdd54ed7d795df73b7129", async() => {
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
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/emojionearea/3.4.2/emojionearea.min.js"" integrity=""sha512-hkvXFLlESjeYENO4CNi69z3A1puvONQV5Uh+G4TUDayZxSLyic5Kba9hhuiNLbHqdnKNMk2PxXKm0v7KDnWkYA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/emojionearea/3.4.2/emojionearea.min.css"" integrity=""sha512-vEia6TQGr3FqC6h55/NdU3QSM5XR6HSl5fW71QTKrgeER98LIMGwymBVM867C1XHIkYD9nMTfWK2A0xcodKHNA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
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
        cursor: pointer; /* Mouse pointer on hov");
            WriteLiteral("er */\r\n    }\r\n</style>\r\n<script>\r\n    $(function () {\r\n        $(\"#messageInput1\").emojioneArea();\r\n    });\r\n</script>\r\n<div class=\"right_col\" role=\"main\" style=\"height: 100%\">\r\n    <h3 class=\"text-center\">Messing to ");
#nullable restore
#line 40 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
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
#line 52 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                       foreach (var item in ViewBag.user)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"buttonChat\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2142, "\"", 2176, 3);
            WriteAttributeValue("", 2152, "location.href=\'", 2152, 15, true);
#nullable restore
#line 54 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 2167, item.Id, 2167, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2175, "\'", 2175, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2177, "\"", 2209, 1);
#nullable restore
#line 54 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 2185, item.NormalizedUserName, 2185, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"padding:0;border:none;background:none\" type=\"submit\">\r\n                                <div class=\"chat_list\">\r\n                                    <div class=\"chat_people\">\r\n\r\n                                        <div class=\"chat_img\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d976b7fa2f90304acbb75c4fdd54ed7d795df73b11760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2468, "~/Images/", 2468, 9, true);
#nullable restore
#line 58 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
AddHtmlAttributeValue("", 2477, item.Image, 2477, 11, false);

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
#line 61 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                           Write(item.NormalizedUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                  
                                                    if (item.Online == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"chat_date\">Online</span>\r\n");
#nullable restore
#line 66 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"chat_date\">Offline</span>\r\n");
#nullable restore
#line 70 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </h5>\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </button>\r\n");
#nullable restore
#line 78 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <input type=\"text\" id=\"senderInput\"");
            BeginWriteAttribute("value", " value=\"", 3711, "\"", 3734, 1);
#nullable restore
#line 82 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 3719, ViewBag.sender, 3719, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n            <input type=\"text\" id=\"receiverInput\"");
            BeginWriteAttribute("value", " value=\"", 3796, "\"", 3821, 1);
#nullable restore
#line 83 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 3804, ViewBag.receiver, 3804, 17, false);

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
                    <div");
            BeginWriteAttribute("class", " class=\"", 4798, "\"", 4806, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 104 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                       foreach (var item in ViewBag.outMsg)
                        {
                            if (item.FromUser == ViewBag.sender && item.ToUser == ViewBag.receiver)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"outgoing_msg\">\r\n                                    <div class=\"sent_msg\" id=\"sent_msg\">\r\n                                        <p");
            BeginWriteAttribute("onclick", " onclick=\"", 5212, "\"", 5256, 3);
            WriteAttributeValue("", 5222, "DownloadDocument(\'", 5222, 18, true);
#nullable restore
#line 110 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 5240, item.Message1, 5240, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5254, "\')", 5254, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\">\r\n                                            ");
#nullable restore
#line 111 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                       Write(item.Message1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <span class=\"time_date\"> ");
#nullable restore
#line 113 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                            Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 116 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"incoming_msg\">\r\n                                    <div class=\"incoming_msg_img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d976b7fa2f90304acbb75c4fdd54ed7d795df73b19974", async() => {
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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"received_msg\">\r\n                                        <div class=\"received_withd_msg\">\r\n                                            <p");
            BeginWriteAttribute("onclick", " onclick=\"", 6084, "\"", 6128, 3);
            WriteAttributeValue("", 6094, "DownloadDocument(\'", 6094, 18, true);
#nullable restore
#line 125 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
WriteAttributeValue("", 6112, item.Message1, 6112, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6126, "\')", 6126, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\">");
#nullable restore
#line 125 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                                                                              Write(item.Message1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <span class=\"time_date\"> ");
#nullable restore
#line 126 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                                                Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div> ");
#nullable restore
#line 129 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Home\PartialViewChat.cshtml"
                                       }

                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div id=""createDiv_incoming_msg""></div>
                    <div id=""createDiv_outgoing_msg""></div>
                </div>
                <div>
                    <input type=""file"" name=""file"" id=""fileUpload"" onchange=""UploadFile(event)"" hidden>
                    <label for=""fileUpload""><i class=""fa fa-upload"" aria-hidden=""true""></i></label>
                </div>
                <div class=""type_msg"">
                    <div class=""input_msg_write"">
                        <textarea type=""text"" class=""write_msg"" id=""messageInput1"" placeholder=""Type a message""></textarea>
                        <button class=""msg_send_btn"" type=""button"" id=""sendButton1""><i class=""fa fa-paper-plane-o"" aria-hidden=""true""></i></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- signalr -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d976b7fa2f90304acbb75c4fdd54ed7d795df73b23845", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d976b7fa2f90304acbb75c4fdd54ed7d795df73b24885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
    var pageSize = 10;
    var pageIndex = 1;
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
                    for (var i = 0; i < data.length; i++) {
                        if (data[i].FromUser == sender && data[i].ToUser == receiver) {
                            $('#msg_history').prepend(' <div class=""outgoing_msg"">' +
                                '<div class=""sent_msg"">' +
                                '<p onclick=""DownloadDocument(\'");
            WriteLiteral(@"' + data[i].Message1 + '\')"" style=""cursor: pointer"">'
                                + data[i].Message1 +
                                '</p>' +
                                '<span class=""time_date"">' + data[i].Date + '</span>' +
                                '</div>' +
                                '</div>');

                        } else {
                            $('#msg_history').prepend('<div class=""incoming_msg"">' +
                                '<div class=""incoming_msg_img"">' +
                                '<img src=""/Images/Avatar.PNG"" />' +
                                ' </div>' +
                                '<div class=""received_msg"">' +
                                '<div class=""received_withd_msg"">' +
                                '<p onclick=""DownloadDocument(\'' + data[i].Message1 + '\')"" style=""cursor: pointer"">' + data[i].Message1 + '</p>' +
                                '<span class=""time_date"">' + data[i].Date + '</span>' +
                 ");
            WriteLiteral(@"               '</div>' +
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
