#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c638b2060a5e338b3a7dae93af9eec0f1e887b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Danhmuc_khachhang), @"mvc.1.0.view", @"/Views/Danhmuc/khachhang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c638b2060a5e338b3a7dae93af9eec0f1e887b3c", @"/Views/Danhmuc/khachhang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e8af26c98d5ac069d8769dc932d061bf88f7a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Danhmuc_khachhang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detailKH", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
  
    ViewData["Title"] = "khachhang";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
  
    if (TempData["alertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success  alert-dismissable\">\r\n            ");
#nullable restore
#line 10 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
       Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
  
    if (TempData["alertMessage1"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success  alert-dismissable\">\r\n            ");
#nullable restore
#line 18 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
       Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 577, "\"", 585, 0);
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
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Hàng hóa</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                        ");
            WriteLiteral(@"    <li>
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
                                <a class=""close-link""><i class=""fa fa-close""></i></a>
                            </li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">
             ");
            WriteLiteral(@"           <div class=""row"">
                            <div class=""col-sm-12"">
                                <div class=""card-box table-responsive"">
                                    <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0"" width=""100%"">
                                        <thead>
                                            <tr>
                                                <th>Mã khách</th>
                                                <th>Tên tắt</th>
                                                <th>Tên khách</th>
                                                <th>Địa chỉ</th>
                                                <th>SĐT</th>
                                                <th>email</th>
                                                <th>MST/CMND</th>
                                                <th>FAX</th>
                                                <th>Giao dịch</th>
                  ");
            WriteLiteral(@"                              <th>Tỉnh</th>
                                                <th>Quốc gia</th>
                                                <th>Loại khách</th>
                                                <th>Tài khoản</th>
                                                <th>Ngân hàng</th>
                                                <th>Giáy phép</th>
                                                <th>Ngày cấp</th>
                                                <th>Vận chuyển</th>
                                                <th>Bốc xếp</th>
                                                <th>Diện tích (m²)</th>
                                                <th>Sản lượng</th>
                                                <th>Giao dịch mua</th>
                                                <th>Giao dịch bán</th>
                                                <th>Ứng tiền mua</th>
                                                <th>Ứng tiền bán</th>
          ");
            WriteLiteral("                                  </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 97 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                              
                                                foreach (var item in Model)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 102 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.MaKhach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c638b2060a5e338b3a7dae93af9eec0f1e887b3c10724", async() => {
#nullable restore
#line 103 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                                                                                                      Write(item.TenKhach);

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
#line 103 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                                                                                WriteLiteral(item.Idkhach);

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
#line 104 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.TenFull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 105 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 106 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.DienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 107 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 108 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.MaSoThue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 109 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 110 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.GiaoDich);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 111 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.MaKhuvuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 112 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.TenQg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 113 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.LoaiKhach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 114 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.TaiKhoan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 115 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.NganHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 116 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.GiayPhep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 117 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.NgayCap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 118 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.Vanchuyen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 119 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.Bocxep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 120 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.Dientich);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 121 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                       Write(item.Sanluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 122 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                          
                                                            if (item.GiaoDichMua == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Có</td>\r\n");
#nullable restore
#line 126 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Không</td>\r\n");
#nullable restore
#line 130 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }

                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                          
                                                            if (item.GiaoDichBan == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Có</td>\r\n");
#nullable restore
#line 137 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Không</td>\r\n");
#nullable restore
#line 141 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }

                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                          
                                                            if (item.ThanhToanMua == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Có</td>\r\n");
#nullable restore
#line 148 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Không</td>\r\n");
#nullable restore
#line 152 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }

                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                          
                                                            if (item.ThanhToanBan == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Có</td>\r\n");
#nullable restore
#line 159 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>Không</td>\r\n");
#nullable restore
#line 163 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
                                                            }

                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </tr>\r\n");
#nullable restore
#line 168 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang.cshtml"
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
                    <div class=""col-md-12 col-sm-12  "">
                        <div class=""x_panel"">
                            <div class=""x_title"">
                                <h2><i class=""fa fa-bars""></i>Chi tiết hàng hóa</h2>
                                <ul class=""nav navbar-right panel_toolbox"">
                                    <li>
                                        <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                                    </li>
                                    <li class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                                        <div class=""drop");
            WriteLiteral(@"down-menu"" aria-labelledby=""dropdownMenuButton"">
                                            <a class=""dropdown-item"" href=""#"">Settings 1</a>
                                            <a class=""dropdown-item"" href=""#"">Settings 2</a>
                                        </div>
                                    </li>
                                    <li>
                                        <a class=""close-link""><i class=""fa fa-close""></i></a>
                                    </li>
                                </ul>
                                <div class=""clearfix""></div>
                            </div>
                            <div class=""x_content"">

                                <ul class=""nav nav-tabs bar_tabs"" id=""myTab"" role=""tablist"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Định ");
            WriteLiteral(@"mức</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Người đại diện</a>
                                    </li>
                                </ul>
                                <div class=""tab-content"" id=""myTabContent"">
                                    <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                                        <table class=""table table-striped table-bordered"" style=""width:100%"">
                                            <thead>
                                                <tr>
                                                    <th border=""1"" style=""border-color:black"">Nhóm hàng</th>
                                                    <th border=""1"" style=""border-color:black"">ĐM HH chưa gia");
            WriteLiteral(@"o(KSG)</th>
                                                    <th border=""1"" style=""border-color:black"">Đơn vị</th>
                                                    <th border=""1"" style=""border-color:black"">Người GD</th>
                                                    <th border=""1"" style=""border-color:black"">QH với chủ DN</th>
                                                    <th border=""1"" style=""border-color:black"">Ghi chú</th>
                                                    <th border=""1"" style=""border-color:black"">Người tạo</th>
                                                    <th border=""1"" style=""border-color:black"">Ngày tạo</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <th scope=""col"" style=""border-color:black"">Nhóm hàng</th>
                           ");
            WriteLiteral(@"                         <th scope=""col"" style=""border-color:black"">ĐM HH chưa giao(KGS)</th>
                                                    <th scope=""col"" style=""border-color:black"">Đơn vị</th>
                                                    <th scope=""col"" style=""border-color:black"">Người GD</th>
                                                    <th scope=""col"" style=""border-color:black"">QH với DN</th>
                                                    <th scope=""col"" style=""border-color:black"">Ghi chú</th>
                                                    <th scope=""col"" style=""border-color:black"">Người tạo</th>
                                                    <th scope=""col"" style=""border-color:black"">Ngày tạo</th>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div class=""tab-pane fade"" id=""");
            WriteLiteral(@"profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                                        <table class=""table table-striped table-bordered"" style=""width:100%"">
                                            <thead>
                                                <tr>
                                                    <th border=""1"" style=""border-color:black"">Người đại diện</th>
                                                    <th border=""1"" style=""border-color:black"">Chức vụ</th>
                                                    <th border=""1"" style=""border-color:black"">Ủy quyền</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td border=""1"" style=""border-color:black""></td>
                                                    <td border=""1"" style=""border-color:black""></td>");
            WriteLiteral(@"
                                                    <td border=""1"" style=""border-color:black""></td>
                                                </tr>
                                            </tbody>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
