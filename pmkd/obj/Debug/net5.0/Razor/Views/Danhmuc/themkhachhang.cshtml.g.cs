#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\themkhachhang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "723fe42ac8df07e30442b21d9321c57d49da5a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Danhmuc_themkhachhang), @"mvc.1.0.view", @"/Views/Danhmuc/themkhachhang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723fe42ac8df07e30442b21d9321c57d49da5a03", @"/Views/Danhmuc/themkhachhang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e8af26c98d5ac069d8769dc932d061bf88f7a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Danhmuc_themkhachhang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\themkhachhang.cshtml"
  
    ViewData["Title"] = "themkhachhang";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\themkhachhang.cshtml"
  
    if (TempData["alertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success  alert-dismissable\">\r\n            ");
#nullable restore
#line 12 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\themkhachhang.cshtml"
       Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\themkhachhang.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .input-validation-error {\r\n        border-color: red;\r\n</style>\r\n<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 433, "\"", 441, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""col-md-12 col-sm-12"">
            <div class=""x_panel"">
                <div class=""x_title"">
                    <h2>Chi tiết<small>Hàng hóa</small></h2>
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
                        </li>
                        <li>
                            <a class=""close-link""><i class=""fa fa-");
            WriteLiteral("close\"></i></a>\r\n                        </li>\r\n                    </ul>\r\n                    <div class=\"clearfix\"></div>\r\n                </div>\r\n                <div class=\"x_content\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a037968", async() => {
                WriteLiteral(@"
                        <div>
                            <label>ID khách hàng</label>
                            <input type=""text"" class=""form-control"" placeholder=""ID khách hàng"" data-validate=""Làm ơn nhập ID hàng hóa"">
                            <span class=""input-validation-error""></span>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-3"">
                                <label for=""inputEmail4"">Mã khách</label>
                                <input type=""text"" class=""form-control"" placeholder=""Mã khách"">
                                <span class=""text-danger""></span>
                            </div>
                            <div class=""form-group col-md-6"">
                                <label for=""inputPassword4"">Tên tắt</label>
                                <input type=""text"" class=""form-control"" placeholder=""Tên tắt"">
                                <span class=""text-danger""></span>
");
                WriteLiteral(@"                            </div>
                            <div class=""form-group col-md-3"">
                                <label for=""inputPassword4"">MST/CMND</label>
                                <input type=""text"" class=""form-control"" placeholder=""MST / CMND"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-9"">
                                <label for=""inputEmail4"">Tên khách</label>
                                <input type=""text"" class=""form-control"" placeholder=""Tên khách"">
                                <span class=""text-danger""></span>
                            </div>
                            <div class=""form-group col-md-3"">
                                <label for=""inputPassword4"">Điện thoại</label>
                                <input type=""text"" class=""form-control"" placeholder=""Tên tắt"">
                                <span class=""text-dan");
                WriteLiteral(@"ger""></span>
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-9"">
                                <label for=""inputEmail4"">Địa chỉ</label>
                                <input type=""text"" class=""form-control"" placeholder=""Địa chỉ"">
                                <span class=""text-danger""></span>
                            </div>
                            <div class=""form-group col-md-3"">
                                <label for=""inputPassword4"">FAX</label>
                                <input type=""text"" class=""form-control"" placeholder=""FAX"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <label for=""inputState"">Loại khách  || 0-MB lâu dài, 1-MB theo từng PA, 2-MB theo ủy thác, 3-Khách lập bảng kê</label>
                            <label for=""inputZip"" style=""margin-le");
                WriteLiteral(@"ft:270px"">Email</label>
                        </div>

                        <div class=""form-row"">
                            <div class=""form-group col-md-2"">
                                <select class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a0311782", async() => {
                    WriteLiteral("0");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a0313037", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a0314292", async() => {
                    WriteLiteral("2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a0315547", async() => {
                    WriteLiteral("3");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group col-md-3"" style=""margin-left:599px"">
                                <input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-3"">
                                <label for=""inputEmail4"">Tài khoản</label>
                                <input type=""text"" class=""form-control"" placeholder=""Tài khoản"">
                            </div>
                            <div class=""form-group col-md-9"">
                                <label for=""inputPassword4"">Ngân hàng</label>
                                <input type=""text"" class=""form-control"" placeholder=""Ngân hàng"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div cl");
                WriteLiteral(@"ass=""form-group col-md-3"">
                                <label for=""inputEmail4"">Giấy phép</label>
                                <input type=""text"" class=""form-control"" placeholder=""Giấy phép"">
                            </div>
                            <div class=""form-group col-md-6"">
                                <label for=""inputPassword4"">Ngày cấp</label>
                                <input type=""date"" class=""form-control"" placeholder=""ngày cấp"">
                            </div>
                            <div class=""form-group col-md-3"">
                                <label for=""inputPassword4"">Tỉnh / TP</label>
                                <select class=""form-control"">
");
                WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div>
                            <label>Ghi chú</label>
                            <textarea class=""form-control""></textarea>
                        </div>

                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label>Quốc gia</label>
                                <select class=""form-control"">
");
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""form-group col-md-3"">
                                <label>Tòa kinh tế</label>
                                <input type=""text"" class=""form-control"" placeholder=""Tòa kinh tế"">
                            </div>
                            <div class=""form-group col-md-3"">
                                <label>Bốc xếp</label>
                                <input type=""text"" class=""form-control"" placeholder=""Bốc xếp"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label>Vận chuyển</label>
                                <input type=""text"" class=""form-control"" placeholder=""Vận chuyển"">
                            </div>
                            <div class=""form-group col-md-3"">
                                <la");
                WriteLiteral(@"bel>Diện tích(m2)</label>
                                <input type=""text"" class=""form-control"" placeholder=""Diện tích"">
                            </div>
                            <div class=""form-group col-md-3"">
                                <label>Sản lượng(kg)</label>
                                <input type=""text"" class=""form-control"" placeholder=""Sản lượng"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" id=""isActive"" type=""checkbox"" value=""true"">
                                <input type=""hidden"" value=""false"" />
                                <label class=""form-check-label"">
                                    Kiểm tra định mức HH chưa giao
                                </label>

                            </div>
                        </div>
                        <div class=""form-r");
                WriteLiteral(@"ow"">
                            <label>Giao dịch || 0-Chờ duyệt, 1- Đang giao dịch, 2-Ngừng giao dịch</label>
                            <label style=""margin-left:100px"">Giao dịch</label>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-2"">

                                <select class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a0321836", async() => {
                    WriteLiteral("0");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a0323091", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723fe42ac8df07e30442b21d9321c57d49da5a0324346", async() => {
                    WriteLiteral("2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""custom-control custom-checkbox"" style=""margin-left:300px"">
                                <input type=""checkbox"" id=""customRadio1"" class=""custom-control-input"" value=""true"">
                                <input type=""hidden"" value=""false"">
                                <label class=""custom-control-label"" for=""customRadio1"">Thanh toán mua</label>
                            </div>
                            <div class=""custom-control custom-checkbox"">
                                <input type=""checkbox"" id=""customRadio2"" class=""custom-control-input"" value=""true"">
                                <input type=""hidden"" value=""false"">
                                <label class=""custom-control-label"" for=""customRadio2"">Thanh toán bán</label>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
