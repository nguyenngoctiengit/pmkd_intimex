#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809264d7b5ba9528041b8c09ebf3c6d8e37fd706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Khachhang_Khachhang), @"mvc.1.0.view", @"/Views/Khachhang/Khachhang.cshtml")]
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
#nullable restore
#line 5 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809264d7b5ba9528041b8c09ebf3c6d8e37fd706", @"/Views/Khachhang/Khachhang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb5032fc71ad384771cb309a8213e095deb506", @"/Views/_ViewImports.cshtml")]
    public class Views_Khachhang_Khachhang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KhachHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
  
    ViewData["Title"] = "khachhang1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 193, "\"", 201, 0);
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
#line 24 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
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
                                    ");
#nullable restore
#line 67 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                Write(Html.DevExtreme().DataGrid<pmkd.Models.KhachHang>()
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("Danhmuc")
                                        .LoadAction("GetKH")
                                        .UpdateAction("PutKH")
                                        .DeleteAction("DeleteKH")
                                        .Key("Idkhach", "MaKhach")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.Idkhach).Visible(false);

                                        columns.AddFor(m => m.MaKhach).Fixed(true).Caption("Mã khách");

                                        columns.AddFor(m => m.TenKhach).Caption("Tên khách");

                                        columns.AddFor(m => m.TenFull).Caption("Tên đầy đủ").Visible(true);

                                        columns.AddFor(m => m.Email).Caption("Email");

                                        columns.AddFor(m => m.DiaChi).Caption("Địa chỉ").Visible(false);

                                        columns.AddFor(m => m.DienThoai).Caption("SĐT");

                                        columns.AddFor(m => m.Fax).Caption("Fax").Visible(false);

                                        columns.AddFor(m => m.MaSoThue).Caption("Mã số thuế").Visible(false);

                                        columns.AddFor(m => m.TaiKhoan).Caption("Tài khoản").Visible(false);

                                        columns.AddFor(m => m.NganHang).Caption("Ngân hàng").Visible(false);

                                        columns.AddFor(m => m.GiayPhep).Caption("Giấy phép").Visible(false);

                                        columns.AddFor(m => m.NgayCap).Caption("Ngày cấp").Visible(false);

                                        columns.AddFor(m => m.MaCn).Caption("Mã chi nhánh").Visible(false).AllowEditing(false);

                                        columns.AddFor(m => m.ThanhToanMua).Caption("Thanh toán mua").Visible(false).Lookup(lookup => lookup.DataSource(new JS("thanhtoanmua")).ValueExpr("id").DisplayExpr("name"));

                                        columns.AddFor(m => m.ThanhToanBan).Caption("Thanh toán bán").Visible(false).Lookup(lookup => lookup.DataSource(new JS("thanhtoanban")).ValueExpr("id").DisplayExpr("name"));

                                        columns.AddFor(m => m.GiaoDichMua).Caption("Giao dịch mua").Visible(false).Lookup(lookup => lookup.DataSource(new JS("giaodichmua")).ValueExpr("id").DisplayExpr("name"));

                                        columns.AddFor(m => m.GiaoDichBan).Caption("Giao dịch bán").Visible(false).Lookup(lookup => lookup.DataSource(new JS("giaodichban")).ValueExpr("id").DisplayExpr("name"));

                                        columns.AddFor(m => m.GhiChu).Caption("Ghi chú").Visible(false);

                                        columns.AddFor(m => m.GiaoDich).Caption("Giao dịch").Visible(false);

                                        columns.AddFor(m => m.MaKhuvuc).Caption("Khu vực").GroupIndex(1).Lookup(lookup => lookup
                                                .DataSource(ViewBag.khuvuc)
                                                .DisplayExpr("TenKhuvuc")
                                                .ValueExpr("MaKhuvuc")
                                                );

                                        columns.AddFor(m => m.TenQg).Caption("Tên quốc gia").GroupIndex(0).Lookup(lookup => lookup
                                                .DataSource(ViewBag.tenqg)
                                                .DisplayExpr("Name")
                                                .ValueExpr("Name")
                                                );

                                        columns.AddFor(m => m.ToaKinhTe).Caption("Tòa kinh tế").Visible(false);

                                        columns.AddFor(m => m.CreatedDate).Caption("Ngày tạo").Visible(false).AllowEditing(false);

                                        columns.AddFor(m => m.CreatedBy).Caption("Người tạo").Visible(false).AllowEditing(false);

                                        columns.AddFor(m => m.Vanchuyen).Caption("Vận chuyển").Visible(false);

                                        columns.AddFor(m => m.Bocxep).Caption("Bốc xếp").Visible(false);

                                        columns.AddFor(m => m.LoaiKhach).Caption("Loại khách").Visible(false).Lookup(lookup => lookup.DataSource(new JS("loaikhach")).ValueExpr("id").DisplayExpr("name"));

                                        columns.AddFor(m => m.Sanluong).Caption("Sản lượng").Visible(false);

                                        columns.AddFor(m => m.Dientich).Caption("Diện tích").Visible(false);

                                    })
                                    .Editing(e => e
                                        .Mode(GridEditMode.Popup)
                                        .Popup(p => p.Title("Khách hàng").ShowTitle(true).Width(700).Height(500))
                                        .AllowUpdating(true)
                                        .AllowDeleting(true)
                                        .UseIcons(true)
                                    )
                                    .OnToolbarPreparing("toolbar_khachhang")
                                    .MasterDetail(m => m.Enabled(true).Template(new TemplateName("gridContainer-details")))
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
                                    })
                                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 178 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("gridContainer-details"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                    Write(Html.DevExtreme().TabPanel()
                                            .Items(items => {
                                                items.Add()
                                                    .Title("Định mức")
                                                    .Template(new TemplateName("gridContainer-details-tab1Template"))
                                                    .Option("tabExtras", new { IDkhachhang = new JS("data.Idkhach") });

                                                items.Add()
                                                    .Title("Người đại diện")
                                                    .Template(new TemplateName("gridContainer-details-tab2Template"))
                                                    .Option("tabExtras", new { IDkhachhang = new JS("data.Idkhach") });
                                            })
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 192 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("gridContainer-details-tab1Template"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                    Write(Html.DevExtreme().DataGrid<pmkd.Models.CustomerNorm>()
                                            .DataSource(ds => ds.Mvc()
                                                .Controller("khachhang")
                                                .LoadAction("GetCN")
                                                .InsertAction("PostCN")
                                                .UpdateAction("PutCN")
                                                .DeleteAction("DeleteCN")
                                                .LoadParams(new { IDkhachhang = new JS("tabExtras.IDkhachhang") })
                                                .Key("Id")
                                            )
                                            .RemoteOperations(true)
                                            .Columns(columns => {

                                                columns.AddFor(m => m.Makhach).Caption("Mã khách").Lookup(lookup => lookup
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getmakhach").Key("Idkhach"))
                                                .DisplayExpr("MaKhach")
                                                .ValueExpr("MaKhach")
                                                );

                                                columns.AddFor(m => m.Nhomhang).Caption("Nhóm hàng").Lookup(lookup => lookup
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("Getnhomhang").Key("Manhom"))
                                                .DisplayExpr("Manhom")
                                                .ValueExpr("Manhom")
                                                );

                                                columns.AddFor(m => m.ValueNorm).Caption("ĐM HH chưa giao(KGS)")
                                                                                .DataType(GridColumnDataType.Number)
                                                                                .Format(Format.FixedPoint)
                                                                                .EditorOptions(Format.FixedPoint);

                                                columns.AddFor(m => m.Macn).Caption("Đơn vị").Lookup(lookup => lookup
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getdonvi").Key("Id"))
                                                .DisplayExpr("Id")
                                                .ValueExpr("Id")
                                                ).AllowEditing(false);

                                                columns.AddFor(m => m.NguoiGd).Caption("Người GD");

                                                columns.AddFor(m => m.ChucvuNguoigd).Caption("QH với DN");

                                                columns.AddFor(m => m.Ghichu).Caption("Ghi chú");

                                                columns.AddFor(m => m.UserCreate).Caption("Người tạo").AllowEditing(false);

                                                columns.AddFor(m => m.DateCreate).Caption("Ngày tạo").AllowEditing(false);

                                            })
                                            .Editing(e => e
                                                .Mode(GridEditMode.Popup)
                                                .Popup(p => p.Title("Định mức khách hàng").ShowTitle(true).Width(700).Height(400))
                                                .AllowAdding(true)
                                                .AllowUpdating(true)
                                                .AllowDeleting(true)
                                                .UseIcons(true)
                                                .Form(f => f.Items(items => {
                                                    items.AddGroup()
                                                        .ColSpan(2)
                                                        .ColCount(2)
                                                        .Items(groupItems =>
                                                        {
                                                            groupItems.AddSimpleFor(m => m.Makhach);
                                                            groupItems.AddSimpleFor(m => m.Nhomhang);
                                                            groupItems.AddSimpleFor(m => m.ValueNorm);
                                                            groupItems.AddSimpleFor(m => m.NguoiGd);
                                                            groupItems.AddSimpleFor(m => m.ChucvuNguoigd).ColSpan(2);
                                                            groupItems.AddSimpleFor(m => m.Ghichu).ColSpan(2).Editor(e => e.TextArea().Height(70));
                                                        });


                                                }))
                                            )
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
#line 289 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 291 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("gridContainer-details-tab2Template"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 293 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                    Write(Html.DevExtreme().DataGrid<pmkd.Models.Signer>()
                                            .DataSource(ds => ds.Mvc()
                                                .Controller("khachhang")
                                                .LoadAction("GetSN")
                                                .InsertAction("PostSN")
                                                .UpdateAction("PutSN")
                                                .DeleteAction("DeleteSN")
                                                .Key("Id")
                                                .LoadParams(new { IDkhachhang = new JS("tabExtras.IDkhachhang") })
                                            )
                                            .RemoteOperations(true)
                                            .Columns(columns => {

                                                columns.AddFor(m => m.MaKhach).Caption("Mã khách").Lookup(lookup => lookup
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getmakhach").Key("Idkhach"))
                                                .DisplayExpr("MaKhach")
                                                .ValueExpr("MaKhach")
                                                );

                                                columns.AddFor(m => m.Stt).Caption("Số thứ tự");

                                                columns.AddFor(m => m.Nguoiky).Caption("Người ký");

                                                columns.AddFor(m => m.Chucvu).Caption("Chức vụ");

                                                columns.AddFor(m => m.Uyquyen).Caption("Ủy quyền");

                                            })
                                            .Editing(e => e
                                                .Mode(GridEditMode.Popup)
                                                .Popup(p => p.Title("Người đại diện").ShowTitle(true).Width(700).Height(500))
                                                .AllowAdding(true)
                                                .AllowUpdating(true)
                                                .AllowDeleting(true)
                                                .UseIcons(true)
                                            )
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
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 344 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Khachhang\Khachhang.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
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
