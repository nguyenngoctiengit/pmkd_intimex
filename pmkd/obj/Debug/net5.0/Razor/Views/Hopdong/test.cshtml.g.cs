#pragma checksum "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16dd1a240e5019219ed1f1248dbe220bbcb54aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hopdong_test), @"mvc.1.0.view", @"/Views/Hopdong/test.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16dd1a240e5019219ed1f1248dbe220bbcb54aa3", @"/Views/Hopdong/test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb5032fc71ad384771cb309a8213e095deb506", @"/Views/_ViewImports.cshtml")]
    public class Views_Hopdong_test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hdmb>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label-left input_mask"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
  
    ViewData["Title"] = "test";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
  
    ViewData["Title"] = "hdmb";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 292, "\"", 300, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Hợp đồng mua bán</h3>
            </div>
            <div class=""title_right"">
                <div class=""col-md-5 col-sm-5   form-group pull-right top_search"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search for..."">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""button"">Go!</button>
                        </span>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 30 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Hopdong\test.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Hợp đồng mua bán</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                            <li>
                                <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                            </li>
                            <li class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item"" href=""#"">Settings 1</a>
                                    <a class=""dropdown-item"" href=""#"">Settings 2</a>
                                </div>");
            WriteLiteral(@"
                            </li>
                            <li>
                                <a class=""close-link""><i class=""fa fa-close""></i></a>
                            </li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <div class=""card-box table-responsive"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16dd1a240e5019219ed1f1248dbe220bbcb54aa39515", async() => {
                WriteLiteral(@"
                                        <div class=""form-group row"">
                                            <label class=""col-form-label col-md-2 col-sm-2"">A- Trị giá bán</label>
                                            <label class=""col-form-label col-md-2 col-sm-2"">Nguyên tệ</label>
                                            <div class=""col-md-3 col-sm-3"">
                                                <input type=""text"" class=""form-control"">
                                            </div>
                                            <label class=""col-form-label col-md-1 col-sm-1"">Qui VNĐ</label>
                                            <div class=""col-md-4 col-sm-4"">
                                                <input type=""text"" class=""form-control"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label class=""co");
                WriteLiteral(@"l-form-label col-md-2 col-sm-2"">Đơn giá bán</label>
                                            <label class=""col-form-label col-md-2 col-sm-2"">TẤN</label>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"">
                                            </div>
                                            <div class=""col-md-1 col-sm-1"">
                                                <input type=""text"" class=""form-control"">
                                            </div>
                                            <label class=""col-form-label col-md-1 col-sm-1""></label>
                                            <div class=""col-md-4 col-sm-4"">
                                                <input type=""text"" class=""form-control"">
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /page content -->
<!-- /page content -->
<!-- footer content -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hdmb>> Html { get; private set; }
    }
}
#pragma warning restore 1591
