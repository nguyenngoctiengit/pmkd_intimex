#pragma checksum "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b070fb8eccf7e052ab7630248b0ee3204e64c5cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Danhmuc_createhanghoa), @"mvc.1.0.view", @"/Views/Danhmuc/createhanghoa.cshtml")]
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
#line 2 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b070fb8eccf7e052ab7630248b0ee3204e64c5cd", @"/Views/Danhmuc/createhanghoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e8af26c98d5ac069d8769dc932d061bf88f7a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Danhmuc_createhanghoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hanghoa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("demo-form2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-label-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml"
  
    ViewData["Title"] = "createhanghoa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml"
  
    if (TempData["alertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success  alert-dismissable\">\r\n            ");
#nullable restore
#line 10 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml"
       Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml"
  
    if (TempData["alertMessage1"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning  alert-dismissable\">\r\n            ");
#nullable restore
#line 18 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml"
       Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Danhmuc\createhanghoa.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 543, "\"", 551, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Cập nhật hàng hóa</h3>
            </div>

            <div class=""title_right"">
                <div class=""col-md-5 col-sm-5  form-group pull-right top_search"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search for..."">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""button"">Go!</button>
                        </span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Update <small>hàng hóa</small></h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                          ");
            WriteLiteral(@"  <li>
                                <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                            </li>
                            <li class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                                <ul class=""dropdown-menu"" role=""menu"">
                                    <li>
                                        <a class=""dropdown-item"" href=""#"">Settings 1</a>
                                    </li>
                                    <li>
                                        <a class=""dropdown-item"" href=""#"">Settings 2</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a class=""close-link""><i class=""fa fa-close""></i></a>
                            </li>
 ");
            WriteLiteral("                       </ul>\r\n                        <div class=\"clearfix\"></div>\r\n                    </div>\r\n                    <div class=\"x_content\">\r\n                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b070fb8eccf7e052ab7630248b0ee3204e64c5cd8102", async() => {
                WriteLiteral(@"

                            <div>
                                <label>ID hàng hóa</label>
                                <input type=""text"" class=""form-control""  placeholder=""ID hàng hóa"" data-validate=""Làm ơn nhập ID hàng hóa"">
                                <span  class=""input-validation-error""></span>
                            </div>
                            <div class=""form-row"">
                                <div class=""form-group col-md-3"">
                                    <label for=""inputEmail4"">Nhóm hàng</label>
                                    <input type=""text"" class=""form-control""  placeholder=""Mã khách"">
                                    <span  class=""text-danger""></span>
                                </div>
                                <div class=""form-group col-md-6"">
                                    <label for=""inputPassword4"">Mã hàng</label>
                                    <input type=""text"" class=""form-control""  placeholder=""Tên tắt"">
       ");
                WriteLiteral(@"                             <span  class=""text-danger""></span>
                                </div>
                                <div class=""form-group col-md-3"">
                                    <label for=""inputPassword4"">Tên hàng</label>
                                    <input type=""text"" class=""form-control""  placeholder=""MST / CMND"">
                                </div>
                            </div>
                            <div>
                                <label>Tên hàng VAT</label>
                                <input type=""text"" class=""form-control""  placeholder=""ID hàng hóa"" data-validate=""Làm ơn nhập ID hàng hóa"">
                                <span  class=""input-validation-error""></span>
                            </div>
                            <div class=""form-row"">
                                <div class=""form-group col-md-3"">
                                    <label for=""inputEmail4"">VAT</label>
                                    <input ty");
                WriteLiteral(@"pe=""text"" class=""form-control""  placeholder=""Mã khách"">
                                    <span  class=""text-danger""></span>
                                </div>
                                <div class=""form-group col-md-6"">
                                    <label for=""inputPassword4"">ĐVT</label>
                                    <input type=""text"" class=""form-control""  placeholder=""Tên tắt"">
                                    <span  class=""text-danger""></span>
                                </div>
                                <div class=""form-group col-md-3"">
                                    <label for=""inputPassword4"">Giao dịch</label>
                                    <input type=""text"" class=""form-control"" placeholder=""MST / CMND"">
                                </div>
                            </div>
                            <div>
                                <label>Bao bì</label>
                                <textarea class=""form-control""></textarea>
   ");
                WriteLiteral(@"                         </div>
                            <div>
                                <label>Kiểm định</label>
                                <textarea class=""form-control""></textarea>
                            </div>
                            <div>
                                <label>Quy cách</label>
                                <textarea class=""form-control""></textarea>
                            </div>
                            <div> <button type=""button"" class=""btn btn-primary btn-block"" style=""margin-top: 30px"">Submit</button></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-parsley-validate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hanghoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
