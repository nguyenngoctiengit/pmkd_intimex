#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "928de845011a71edb25adfcd80043dcb43091a9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLiNhanSu_thongtinnhansu), @"mvc.1.0.view", @"/Views/QuanLiNhanSu/thongtinnhansu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928de845011a71edb25adfcd80043dcb43091a9e", @"/Views/QuanLiNhanSu/thongtinnhansu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLiNhanSu_thongtinnhansu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
  
    ViewData["Title"] = "thongtinnhansu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div class=\"x_content\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                ");
#nullable restore
#line 11 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
            Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.NsDmcbnv>()
                    .ID("gridKcs")
                    .DataSource(d => d.Mvc().LoadAction("getCbnv")
                                            .Controller("quanlinhansu")
                                            .Key("IdNs")
                                            .InsertAction("insertKcs")
                                            .UpdateAction("updateKcs"))
                    .RemoteOperations(true)
                    .Columns(colunms => {

                        colunms.AddFor(m => m.Macn).Caption("Chi nhánh").GroupIndex(0).Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("getchinhanh"))
                                                                                        .ValueExpr("Id")
                                                                                        .DisplayExpr("NameV")).Width(400);

                        colunms.AddFor(m => m.MaCbNv).Caption("Mã nhân viên").Fixed(true);

                        colunms.AddFor(m => m.TenCbNv).Caption("Tên nhân viên").Fixed(true);

                        colunms.AddFor(m => m.NgaySinh).Caption("Ngày sinh").Format("dd/MM/yyyy");

                        colunms.AddFor(m => m.NoiSinh).Caption("Nơi sinh").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("getkhuvuc"))
                                                                                        .ValueExpr("MaKhuvuc")
                                                                                        .DisplayExpr("TenKhuvuc"));

                        colunms.AddFor(m => m.NguyenQuan).Caption("Nguyên quán").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("getkhuvuc"))
                                                                                        .ValueExpr("MaKhuvuc")
                                                                                        .DisplayExpr("TenKhuvuc"));

                        colunms.AddFor(m => m.DanToc).Caption("Dân tộc").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("getdantoc"))
                                                                                        .ValueExpr("MaDantoc")
                                                                                        .DisplayExpr("TenDantoc"));

                        colunms.AddFor(m => m.TonGiao).Caption("Tôn giáo").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("gettongiao"))
                                                                                        .ValueExpr("MaTongiao")
                                                                                        .DisplayExpr("TenTongiao"));

                        colunms.AddFor(m => m.TinhTrangHn).Caption("Tình trạng hôn nhân");

                        colunms.AddFor(m => m.QuocTich).Caption("Quốc tịch").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("getquocgia"))
                                                                                        .ValueExpr("Name")
                                                                                        .DisplayExpr("Name"));



                        colunms.AddFor(m => m.SoCmnd).Caption("Số CMND");

                        colunms.AddFor(m => m.NgayCap).Caption("Ngày cấp").Format("dd/MM/yyyy");

                        colunms.AddFor(m => m.NoiCap).Caption("Nơi cấp");

                        colunms.AddFor(m => m.NgayBegin).Caption("Ngày vào làm").Format("dd/MM/yyyy");

                        colunms.AddFor(m => m.MaBp).Caption("Bộ phận").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("getbophan"))
                                                                                        .ValueExpr("DepartmentCode")
                                                                                        .DisplayExpr("DepartmentName"));

                        colunms.AddFor(m => m.ChucVu).Caption("Chức vụ").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("getchucvu"))
                                                                                        .ValueExpr("MaChucvu")
                                                                                        .DisplayExpr("TenChucvu"));

                        colunms.AddFor(m => m.DiaChi).Caption("Địa chỉ");

                        colunms.AddFor(m => m.Email).Caption("Email");

                        colunms.AddFor(m => m.SoPhone).Caption("ĐTH bàn");

                        colunms.AddFor(m => m.HandPhone).Caption("Số di động");

                        colunms.AddFor(m => m.DcHn).Caption("Địa chỉ hiện nay");

                        colunms.AddFor(m => m.MaSoThue).Caption("MST");

                        colunms.AddFor(m => m.SoTk).Caption("Số tài khoản");

                        colunms.AddFor(m => m.NganHang).Caption("Ngân hàng");

                        colunms.AddFor(m => m.TdVh).Caption("Trình độ văn hóa");

                        colunms.AddFor(m => m.TdHv).Caption("Trình độ học vấn").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("gettrinhdo"))
                                                                                        .ValueExpr("MaTd")
                                                                                        .DisplayExpr("DienGiai"));

                        colunms.AddFor(m => m.TdNn).Caption("Trình độ ngoại ngữ").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("gettrinhdo"))
                                                                                        .ValueExpr("MaTd")
                                                                                        .DisplayExpr("DienGiai"));

                        colunms.AddFor(m => m.CmNv).Caption("Chuyên môn");

                        colunms.AddFor(m => m.TdTh).Caption("Trình độ tin học").Lookup(l => l.DataSource(d => d.Mvc()
                                                                                                        .Controller("lookup")
                                                                                                        .LoadAction("gettrinhdo"))
                                                                                        .ValueExpr("MaTd")
                                                                                        .DisplayExpr("DienGiai"));

                        colunms.AddFor(m => m.CongViec).Caption("Công việc chính").Visible(false);

                    })
                    .MasterDetail(m => m.Enabled(true).Template(new TemplateName("details-nhansu")))
                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                    .Selection(s => s.Mode(SelectionMode.Single))
                    .HoverStateEnabled(true)
                    .Export(e => e.Enabled(true))
                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                    .HeaderFilter(header => header.Visible(true))
                    .AllowColumnReordering(true)
                    .AllowColumnResizing(true)
                    .ColumnAutoWidth(true)
                    .ColumnChooser(c => c.Enabled(true))
                    .ColumnFixing(c => c.Enabled(true))
                    .ShowBorders(true)
                    .Grouping(group => group.AutoExpandAll(true))
                    .SearchPanel(searchPanel => searchPanel.Visible(true))
                    .GroupPanel(groupPanel => groupPanel.Visible(true))
                    .Paging(paging => paging.PageSize(10))
                    .Pager(paper =>
                    {
                        paper.ShowPageSizeSelector(true);
                        paper.AllowedPageSizes(new[] { 5, 10, 20 });
                        paper.ShowInfo(true);
                    })
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 152 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                 using (Html.DevExtreme().NamedTemplate("details-nhansu"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                Write(Html.DevExtreme().TabPanel()
                        .Items(items => {
                            items.Add()
                                .Title("HĐ lao động")
                                .Template(new TemplateName("grid-HDLD"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("CV kiêm nhiệm")
                                .Template(new TemplateName("grid-CVKN"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("QT đào tạo")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("QT công tác")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("QH gia đình")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("BHYT-BHTN-BHXH")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("Chuyển phòng ban")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("Điều chỉnh lương.PC")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("Khen thưởng và kỉ luật")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("Đoàn viên")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("Công đoàn")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });

                            items.Add()
                                .Title("Đảng viên")
                                .Template(new TemplateName("gridContainer-details-tab2Template"))
                                .Option("tabExtras", new { MaCbNv = new JS("data.MaCbNv") });
                        })
                    );

#line default
#line hidden
#nullable disable
#nullable restore
#line 216 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 218 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                 using (Html.DevExtreme().NamedTemplate("grid-HDLD"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 220 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.NsHdld>()
                                            .DataSource(ds => ds.Mvc()
                                                .Controller("quanlinhansu")
                                                .LoadAction("getHDLD")
                                                .InsertAction("PostCN")
                                                .UpdateAction("PutCN")
                                                .DeleteAction("DeleteCN")
                                                .LoadParams(new { MaCbNv = new JS("tabExtras.MaCbNv") })
                                                .Key("Ident00")
                                            )
                                            .RemoteOperations(true)
                                            .Columns(columns => {

                                                columns.AddFor(m => m.SoHd).Caption("Số hợp đồng");

                                                columns.AddFor(m => m.LoaiHd).Caption("Loại hợp đồng");

                                                columns.AddFor(m => m.NgayBd).Caption("Ngày bắt đầu").Format("dd/MM/yyyy");

                                                columns.AddFor(m => m.NgayKt).Caption("Ngày kết thúc").Format("dd/MM/yyyy");

                                                columns.AddFor(m => m.NgachLuong).Caption("Bậc lương QC");

                                                columns.AddFor(m => m.LuongCb).Caption("Lương QC").DataType(GridColumnDataType.Number)
                                                                                .Format(Format.FixedPoint)
                                                                                .EditorOptions(Format.FixedPoint);

                                                columns.AddFor(m => m.NgayKy).Caption("Ngày kí").Format("dd/MM/yyyy");

                                                columns.AddFor(m => m.PcQc).Caption("Phụ cấp").DataType(GridColumnDataType.Number)
                                                                                .Format(Format.FixedPoint)
                                                                                .EditorOptions(Format.FixedPoint);

                                                columns.AddFor(m => m.BacLuong).Caption("Bậc lương 205");

                                                columns.AddFor(m => m.GhiChu).Caption("Ghi chú");

                                                columns.AddFor(m => m.HsLuong).Caption("HSL 205");

                                            })

                                            .Selection(s => s.Mode(SelectionMode.Single))
                                            .HoverStateEnabled(true)
                                            .Export(e => e.Enabled(true))
                                            .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                            .HeaderFilter(hearder => hearder.Visible(true))
                                            .AllowColumnResizing(true)
                                            .AllowColumnReordering(true)
                                            .ColumnAutoWidth(true)
                                            .ColumnChooser(c => c.Enabled(true))
                                            .ColumnFixing(c => c.Enabled(true))
                                            .ShowBorders(true)
                                            .Grouping(group => group.AutoExpandAll(true))
                                            .SearchPanel(searchPanel => searchPanel.Visible(true))
                                            .GroupPanel(groupPanel => groupPanel.Visible(true))
                                            .Paging(paging => paging.PageSize(10))
                                            .Pager(paper =>
                                            {
                                                paper.ShowPageSizeSelector(true);
                                                paper.AllowedPageSizes(new[] { 5, 10, 20 });
                                                paper.ShowInfo(true);
                                            }
                                            )
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 283 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                                         
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 285 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                 using (Html.DevExtreme().NamedTemplate("grid-CVKN"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 287 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.NsCdkn>()
                                            .DataSource(ds => ds.Mvc()
                                                .Controller("quanlinhansu")
                                                .LoadAction("getCVKN")
                                                .InsertAction("PostCN")
                                                .UpdateAction("PutCN")
                                                .DeleteAction("DeleteCN")
                                                .LoadParams(new { MaCbNv = new JS("tabExtras.MaCbNv") })
                                                .Key("Id")
                                            )
                                            .RemoteOperations(true)
                                            .Columns(columns => {

                                                columns.AddFor(m => m.NgayBd).Caption("Ngày nhận CDKN");

                                                columns.AddFor(m => m.SoQdkn).Caption("Số QĐKN");

                                                columns.AddFor(m => m.NoiDungCd).Caption("Nội dung");

                                                columns.AddFor(m => m.TgBks).Caption("Tham gia BKS");

                                                columns.AddFor(m => m.TgHdqt).Caption("Tham gia HĐQT");

                                                columns.AddFor(m => m.CdHdqt).Caption("Chức danh trong HĐQT");

                                                columns.AddFor(m => m.GhiChu).Caption("Ghi chú");

                                            })

                                            .Selection(s => s.Mode(SelectionMode.Single))
                                            .HoverStateEnabled(true)
                                            .Export(e => e.Enabled(true))
                                            .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                            .HeaderFilter(hearder => hearder.Visible(true))
                                            .AllowColumnResizing(true)
                                            .AllowColumnReordering(true)
                                            .ColumnAutoWidth(true)
                                            .ColumnChooser(c => c.Enabled(true))
                                            .ColumnFixing(c => c.Enabled(true))
                                            .ShowBorders(true)
                                            .Grouping(group => group.AutoExpandAll(true))
                                            .SearchPanel(searchPanel => searchPanel.Visible(true))
                                            .GroupPanel(groupPanel => groupPanel.Visible(true))
                                            .Paging(paging => paging.PageSize(10))
                                            .Pager(paper =>
                                            {
                                                paper.ShowPageSizeSelector(true);
                                                paper.AllowedPageSizes(new[] { 5, 10, 20 });
                                                paper.ShowInfo(true);
                                            }
                            )
                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 338 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\QuanLiNhanSu\thongtinnhansu.cshtml"
                         
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /page content -->\r\n<!-- /page content -->\r\n<!-- footer content -->\r\n<!-- /page content -->\r\n<!-- /page content -->\r\n<!-- footer content -->\r\n");
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
