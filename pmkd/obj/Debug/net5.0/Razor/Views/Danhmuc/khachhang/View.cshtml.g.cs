#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "907a58e78ff1d3a7a06fa5917ce8d712a39ca9c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Danhmuc_khachhang_View), @"mvc.1.0.view", @"/Views/Danhmuc/khachhang/View.cshtml")]
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
#nullable restore
#line 3 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using pmkd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907a58e78ff1d3a7a06fa5917ce8d712a39ca9c7", @"/Views/Danhmuc/khachhang/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f3fdee9548d5779914426f2f6cb4c3005f9059", @"/Views/_ViewImports.cshtml")]
    public class Views_Danhmuc_khachhang_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KhachHang>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
  
    ViewData["Title"] = "editcthd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
  
    if (TempData["alertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"color:red\">\r\n            ");
#nullable restore
#line 11 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
       Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .input-validation-error {\r\n        border-color: red;\r\n</style>\r\n<div class=\"right_col\" role=\"main\" style=\"height:800px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 420, "\"", 428, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""col-md-12 col-sm-12"">
            <div class=""x_panel"">
                <div class=""x_title"">
                    <h2>Thêm<small>khách hàng</small></h2>
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
                            <a class=""close-link""><i class=""fa fa-cl");
            WriteLiteral("ose\"></i></a>\r\n                        </li>\r\n                    </ul>\r\n");
#nullable restore
#line 41 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
                      
                        if (TempData["alertMessage"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"color:red;font-size:30px\">\r\n                                ");
#nullable restore
#line 45 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
                           Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
                      
                        if (TempData["alertMessage1"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"color:red;font-size:30px\">\r\n                                ");
#nullable restore
#line 53 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
                           Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 55 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"clearfix\"></div>\r\n                </div>\r\n                <div class=\"x_content\">\r\n                    <br />\r\n\r\n                    ");
#nullable restore
#line 62 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Danhmuc\khachhang\View.cshtml"
                Write(Html.DevExtreme().Form<pmkd.Models.KhachHang>()
    .LabelLocation(FormLabelLocation.Right)
    .Items(items => {
        items.AddGroup().Caption("Group1").Items(groupItems => {

            groupItems.AddSimpleFor(m => m.Idkhach);

            groupItems.AddSimpleFor(m => m.MaKhach);

            groupItems.AddSimpleFor(m => m.TenKhach);

            groupItems.AddSimpleFor(m => m.TenFull);

            groupItems.AddSimpleFor(m => m.Email);

            groupItems.AddSimpleFor(m => m.DiaChi);

            groupItems.AddSimpleFor(m => m.DienThoai);

            groupItems.AddSimpleFor(m => m.Fax);

            groupItems.AddSimpleFor(m => m.MaSoThue);

            groupItems.AddSimpleFor(m => m.TaiKhoan);

            groupItems.AddSimpleFor(m => m.NganHang);

            groupItems.AddSimpleFor(m => m.GiayPhep);

            groupItems.AddSimpleFor(m => m.NgayCap);

            groupItems.AddSimpleFor(m => m.MaCn);

            groupItems.AddSimpleFor(m => m.MatHang);

            groupItems.AddSimpleFor(m => m.CheckItem);

            groupItems.AddSimpleFor(m => m.CheckTh);

            groupItems.AddSimpleFor(m => m.GiaoDichMua);

            groupItems.AddSimpleFor(m => m.ThanhToanMua);

            groupItems.AddSimpleFor(m => m.GiaoDichBan);

            groupItems.AddSimpleFor(m => m.ThanhToanBan);

            groupItems.AddSimpleFor(m => m.GhiChu);

            groupItems.AddSimpleFor(m => m.GiaoDich);

            groupItems.AddSimpleFor(m => m.DateActive);

            groupItems.AddSimpleFor(m => m.MaKhuvuc);

            groupItems.AddSimpleFor(m => m.TenQg);

            groupItems.AddSimpleFor(m => m.ToaKinhTe);

            groupItems.AddSimpleFor(m => m.CreatedDate);

            groupItems.AddSimpleFor(m => m.CreatedBy);

            groupItems.AddSimpleFor(m => m.ModifiedDate);

            groupItems.AddSimpleFor(m => m.ModifiedBy);

            groupItems.AddSimpleFor(m => m.Vanchuyen);

            groupItems.AddSimpleFor(m => m.Bocxep);

            groupItems.AddSimpleFor(m => m.LoaiKhach);

            groupItems.AddSimpleFor(m => m.NguoiKy1);

            groupItems.AddSimpleFor(m => m.ChucVu1);

            groupItems.AddSimpleFor(m => m.UyQuyen1);

            groupItems.AddSimpleFor(m => m.NguoiKy2);

            groupItems.AddSimpleFor(m => m.ChucVu2);

            groupItems.AddSimpleFor(m => m.UyQuyen2);

            groupItems.AddSimpleFor(m => m.Visible);

            groupItems.AddSimpleFor(m => m.Sanluong);

            groupItems.AddSimpleFor(m => m.Dientich);

            groupItems.AddSimpleFor(m => m.MaHd);
        });
    })
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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