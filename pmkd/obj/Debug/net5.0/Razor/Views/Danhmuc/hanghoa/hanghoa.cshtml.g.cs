#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f265226c4f3508749bbb0ae3f2f939b987de02d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Danhmuc_hanghoa_hanghoa), @"mvc.1.0.view", @"/Views/Danhmuc/hanghoa/hanghoa.cshtml")]
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
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f265226c4f3508749bbb0ae3f2f939b987de02d3", @"/Views/Danhmuc/hanghoa/hanghoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e8af26c98d5ac069d8769dc932d061bf88f7a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Danhmuc_hanghoa_hanghoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hanghoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updateHH", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "danhmuc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
  
    ViewData["Title"] = "hanghoa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 188, "\"", 196, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Thông tin hàng hóa</h3>
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
#line 24 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Hàng hóa</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                            <li>
                                <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                            </li>
                            <li class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item"" href=""#"">Settings 1</a>
                                    <a class=""dropdown-item"" href=""#"">Settings 2</a>
                                </div>
       ");
            WriteLiteral(@"                     </li>
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
                                    <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0"" width=""100%"">
                                        <thead>
                                            <tr>
                                                <th>Mã hàng</th>
                                                <th>Tên hàng</th>
                                                <th>Tên nhóm hàng</th>
                                                ");
            WriteLiteral(@"<th>Tên hàng VAT</th>
                                                <th>VAT</th>
                                                <th>ĐVT</th>
                                                <th>Giao dịch</th>
                                                <th>Bao bì</th>
                                                <th>Kiểm định</th>
                                                <th>Quy cách</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 83 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                              
                                                foreach (var item in Model)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 88 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.Mahang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f265226c4f3508749bbb0ae3f2f939b987de02d39933", async() => {
#nullable restore
#line 89 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                                                                                                        Write(item.Tenhang);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                                                                                WriteLiteral(item.Idhanghoa);

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
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 90 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.MaNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 91 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.Tenhangvat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 92 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.Vat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 93 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.Dvt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 94 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                          
                                                            if (item.Visible == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Còn giao dịch</td>\r\n");
#nullable restore
#line 98 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Ngừng giao dịch</td>\r\n");
#nullable restore
#line 102 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        <td>");
#nullable restore
#line 105 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.Baobi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 106 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.Kiemdinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 107 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                       Write(item.Quicach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 109 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\hanghoa\hanghoa.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
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
<!-- footer content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hanghoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
