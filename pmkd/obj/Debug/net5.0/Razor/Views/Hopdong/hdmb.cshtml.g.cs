#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbba110a55b7d28fbe2f2d381569aff28b9f1494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hopdong_hdmb), @"mvc.1.0.view", @"/Views/Hopdong/hdmb.cshtml")]
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
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbba110a55b7d28fbe2f2d381569aff28b9f1494", @"/Views/Hopdong/hdmb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e8af26c98d5ac069d8769dc932d061bf88f7a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Hopdong_hdmb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewModelHDMB>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cthdmb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "hopdong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
  
    ViewData["Title"] = "hdmb";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 210, "\"", 218, 0);
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
#line 24 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
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
                        <div class=""form-check-inline"">
                            <input type=""radio"" name=""Month"" value=""All"" checked=""checked"" style=""margin-left:10px""/>All
                            <input type=""radio"" name=""Month"" value=""MUA"" style=""margin-left:10px""/>Mua
                            <input type=""radio"" name=""Month"" value=""BAN"" style=""margin-left:10px""/>Bán
                            <input type=""radio"" name=""Month"" value=""MUON"" style=""margin-left:10px""/>Mượn
                            <input type=""radio"" name=""Month"" value=""CMUON"" style=""margin-left:10px""/>Cho mượn
                            <input type=""radio"" name=""Month"" value=""KT");
            WriteLiteral(@"RA"" style=""margin-left:10px""/>Khách trả
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <div class=""card-box table-responsive"">
                                    <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0"" width=""100%"">
                                        <thead>
                                            <tr>
                                                <th>System ID</th>
                                                <th>Ref</th>
                                                <th>Số HĐ</th>
                                                <th>Mã khách hàng</th>
                                                <th>Khách hàng</th>
                                                <th>Ngày hợp đồng</th>
                                                <th>Tiền tệ</th>
                                                <");
            WriteLiteral(@"th>Vận chuyển</th>
                                                <th>INT ký</th>
                                                <th>Khách ký</th>
                                                <th>Thanh toán</th>
                                                <th>Địa điểm giao hàng</th>
                                                <th>Mức ứng</th>
                                                <th>Tạm ứng theo HĐ</th>
                                                <th>Ngày giao hàng</th>
                                                <th>Ngày hiệu lực</th>
                                                <th>Ghi chú</th>
                                                <th>Hình thức KD</th>
                                                <th>Loại hợp đồng</th>
                                                <th>Hình thức gía</th>
                                                <th>Mã đơn vị</th>
                                                <th>Người tạo</th>
                        ");
            WriteLiteral("                    </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 103 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                              
                                                foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr class=\"dataRow\">\r\n                                                        <th>");
#nullable restore
#line 107 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Systemref);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbba110a55b7d28fbe2f2d381569aff28b9f149411641", async() => {
#nullable restore
#line 108 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                                                                                           Write(item.hdmb.Ref);

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
#line 108 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                                                              WriteLiteral(item.hdmb.Systemref);

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
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 109 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Sohd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 110 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Makhach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 111 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.khachHang.TenKhach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 112 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Ngayky);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 113 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Tiente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 114 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.VanChuyen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 115 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                          

                                                            string str = item.hdmb.IntKy.Trim();
                                                            int c = str.Length;
                                                            if (c > 1)
                                                            {
                                                                string str1 = str.Substring(str.Length - 1, 1);
                                                                foreach (var a in ViewBag.signer)
                                                                {
                                                                    if (a.MaKhach == item.hdmb.Macn.Trim() && a.Stt.ToString() == str1)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <th>");
#nullable restore
#line 126 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                       Write(a.Nguoiky);

#line default
#line hidden
#nullable disable
            WriteLiteral(" chức vụ ");
#nullable restore
#line 126 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                                          Write(a.Chucvu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 127 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                    }

                                                                }
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <th></th>\r\n");
#nullable restore
#line 134 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 137 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                          

                                                            string strKH = item.hdmb.ClientKy.Trim();
                                                            int b = strKH.Length;
                                                            if (b > 0)
                                                            {
                                                                string strKH1 = strKH.Substring(b - 1, 1);
                                                                foreach (var a in ViewBag.signer)
                                                                {
                                                                    if (a.MaKhach == item.hdmb.Makhach && a.Stt.ToString() == strKH1)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <th>");
#nullable restore
#line 148 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                       Write(a.Nguoiky);

#line default
#line hidden
#nullable disable
            WriteLiteral(" chức vụ ");
#nullable restore
#line 148 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                                          Write(a.Chucvu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 149 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                    }

                                                                }
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <th></th>\r\n");
#nullable restore
#line 156 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                            }



                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <th>");
#nullable restore
#line 161 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Thanhtoan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || ");
#nullable restore
#line 161 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                               Write(item.portfolioPayment.TenTt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 162 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.DiaDiemGiaoHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 163 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.portfolioPayment.Mucung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 164 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.TienUngHd.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 165 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Ngaygiao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 166 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Ngayhl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 167 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Ghichu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 168 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                          
                                                            if (item.hdmb.TypeKd == 0)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <th>Trực tiếp</th>\r\n");
#nullable restore
#line 172 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <th>Ủy thác</th>\r\n");
#nullable restore
#line 176 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        <th class=\"aaa\">");
#nullable restore
#line 179 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                   Write(item.hdmb.MuaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 180 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                          
                                                            if (item.hdmb.IsFix == false)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <th>Giá outright</th>\r\n");
#nullable restore
#line 184 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <th>Giá trừ lùi</th>\r\n");
#nullable restore
#line 188 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                            }
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        <th>");
#nullable restore
#line 191 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Macn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <th>");
#nullable restore
#line 192 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                       Write(item.hdmb.Nguoilam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    </tr>\r\n");
#nullable restore
#line 194 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Hopdong\hdmb.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewModelHDMB>> Html { get; private set; }
    }
}
#pragma warning restore 1591
