#pragma checksum "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662cd37c4e0093781d725819a9177b4d65a85f61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lenhgiaohang_lenhgiaohang), @"mvc.1.0.view", @"/Views/Lenhgiaohang/lenhgiaohang.cshtml")]
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
#line 2 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using pmkd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662cd37c4e0093781d725819a9177b4d65a85f61", @"/Views/Lenhgiaohang/lenhgiaohang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb5032fc71ad384771cb309a8213e095deb506", @"/Views/_ViewImports.cshtml")]
    public class Views_Lenhgiaohang_lenhgiaohang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hdmb>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
  
    ViewData["Title"] = "lenhgiaohang";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 194, "\"", 202, 0);
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
#line 26 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 32 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
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
#nullable restore
#line 69 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                      
                                        var filterValue = new object[]
                                        {
                                            new object[] { "CreateDate", DateTime.Now }
};
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 76 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                Write(Html.DevExtreme().DataGrid<pmkd.Models.LenhGiaoHang>()
                                                    .ID("gridLenhGiaoHang")
                                                    .DataSource(d => d.Mvc().Controller("lenhgiaohang")
                                                    .LoadAction("GetLenhGiaoHang")
                                                    .InsertAction("InsertLenhGiaoHang")
                                                    .UpdateAction("UpdateLenhGiaoHang")
                                                    .DeleteAction("DeleteLenhGiaoHang")
                                                    .Key("IdLenhGiaoHang" ))
                                                    .Columns(columns => {

                                                        columns.AddFor(m => m.SoLenh).Caption("Số lệnh").Fixed(true);

                                                        columns.AddFor(m => m.KhoXuatId).Caption("Kho").Lookup(lookup => lookup.DataSource(d => d.Mvc()
                                                                                                                                                    .Controller("lookup")
                                                                                                                                                    .LoadAction("getkhohang"))
                                                                                                                                .DisplayExpr("StockName")
                                                                                                                                .ValueExpr("StockCode"));

                                                        columns.AddFor(m => m.TenKhoXuat).Caption("Tên kho").Visible(false);

                                                        columns.AddFor(m => m.MaKhach).Caption("Mã khách").Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("lookup")
                                                                                                                                                        .LoadAction("getkhachhang"))
                                                                                                                                    .DisplayExpr("TenKhach")
                                                                                                                                    .ValueExpr("MaKhach")
                                                                                                                                    .AllowClearing(true))
                                                                                                            .EditCellTemplate(new TemplateName("DropDownBoxTemplate_khachhang"));

                                                        columns.AddFor(m => m.TenKhach).Caption("Tên khách").Visible(false);

                                                        columns.AddFor(m => m.Hdmb).Caption("Hợp đồng").Lookup(lookup => lookup
                                                                                                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethopdong").Key("Sohd"))
                                                                                                                        .ValueExpr("Sohd")
                                                                                                                        .DisplayExpr("Sohd")
                                                                                                                        .AllowClearing(true))
                                                                                                                   .EditCellTemplate(new TemplateName("DropDownBoxTemplate_hdmb"));

                                                        columns.AddFor(m => m.HdmbId).Caption("Mã hợp đồng");

                                                        columns.AddFor(m => m.KhachMua).Caption("Khách mua").Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("lookup")
                                                                                                                                                        .LoadAction("getkhachhang"))
                                                                                                                                    .DisplayExpr("TenKhach")
                                                                                                                                    .ValueExpr("MaKhach")
                                                                                                                                    .AllowClearing(true))
                                                                                                            .EditCellTemplate(new TemplateName("DropDownBoxTemplate_khachhang"));

                                                        columns.AddFor(m => m.HopdongMua).Caption("Hợp đồng mua");

                                                        columns.AddFor(m => m.Xuatkhau).Caption("Loại hình").GroupIndex(0).Lookup(lookup => lookup.DataSource(new JS("loaixuatkhau"))
                                                                                                                                                        .DisplayExpr("name")
                                                                                                                                                        .ValueExpr("id"));

                                                        columns.AddFor(m => m.Nw).Caption("Lượng giao");

                                                        columns.AddFor(m => m.MaHang).Caption("Mã hàng").Lookup(lookup => lookup
                                                                                                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethanghoa").Key("Mahang"))
                                                                                                                        .ValueExpr("Mahang")
                                                                                                                        .DisplayExpr("Tenhang")
                                                                                                                        .AllowClearing(true))
                                                                                                                   .EditCellTemplate(new TemplateName("DropDownBoxTemplate_hanghoa"));

                                                        columns.AddFor(m => m.TenHang).Caption("Tên hàng");

                                                        columns.AddFor(m => m.Soluongcont).Caption("Số lượng Container/Xe");

                                                        columns.AddFor(m => m.Loaicont).Caption("Loại cont").Lookup(lookup => lookup.DataSource(new JS("loaicont")).DisplayExpr("name").ValueExpr("id"));

                                                        columns.AddFor(m => m.Cachdong).Caption("Cách đóng").Lookup(lookup => lookup.DataSource(new JS("cachdongbao")).DisplayExpr("name").ValueExpr("id"));

                                                        columns.AddFor(m => m.Trongluong1con).Caption("Trọng lượng (Kg/Cont-Xe)").DataType(GridColumnDataType.Number)
                                                                                                                                    .Format(Format.FixedPoint)
                                                                                                                                    .EditorOptions(Format.FixedPoint);

                                                        columns.AddFor(m => m.TypeOfBag).Caption("Loại bao bì").Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("lookup").LoadAction("getloaibao")).DisplayExpr("Name").ValueExpr("BagTypeId"));

                                                        columns.AddFor(m => m.Bags).Caption("Số bao");

                                                        columns.AddFor(m => m.Gw).Caption("Tl bao bì");

                                                        columns.AddFor(m => m.GiamDinh).Caption("Giám định");

                                                        columns.AddFor(m => m.KhuTrung).Caption("Khử trùng");

                                                        columns.AddFor(m => m.CreateDate).Caption("Ngày tạo").Visible(false);

                                                        columns.AddFor(m => m.GiayChongAm).Caption("Giấy chống ẩm").Visible(false);

                                                        columns.AddFor(m => m.Booking).Caption("Booking").Visible(false);

                                                        columns.AddFor(m => m.HangTau).Caption("Hãng tàu").Visible(false);

                                                        columns.AddFor(m => m.VanChuyen).Caption("Vận chuyển").Visible(false);

                                                        columns.AddFor(m => m.Marking).Caption("Marking").Visible(false);

                                                        columns.AddFor(m => m.GhiChu).Caption("Người liên hệ").Visible(false);

                                                        columns.AddFor(m => m.NgayGiao).Caption("Ngày giao").Visible(false);

                                                        columns.AddFor(m => m.TgcatMang).Caption("Thời gian cắt máng").Visible(false);

                                                        columns.AddFor(m => m.GhiChuBaobi).Caption("Ghi chú").Visible(false);

                                                    })
                                                    .Editing(e => e
                                                        .Mode(GridEditMode.Popup)
                                                        .AllowUpdating(true)
                                                        .AllowDeleting(true)
                                                        .AllowAdding(true)
                                                        .UseIcons(true)
                                                        .Popup(e => e.Width(700).Height(500))
                                                        .Form(f => f.Items(items => {
                                                            items.AddGroup().ColCount(2).ColSpan(2)
                                                                .Items(groupItems =>
                                                                {
                                                                    groupItems.AddSimpleFor(m => m.SoLenh);
                                                                    groupItems.AddSimpleFor(m => m.KhoXuatId);
                                                                    groupItems.AddSimpleFor(m => m.MaKhach).ColSpan(2);
                                                                    groupItems.AddSimpleFor(m => m.Hdmb).ColSpan(2);
                                                                    groupItems.AddSimpleFor(m => m.Xuatkhau);
                                                                    groupItems.AddSimpleFor(m => m.Nw);
                                                                    groupItems.AddSimpleFor(m => m.MaHang);
                                                                    groupItems.AddSimpleFor(m => m.GiamDinh);
                                                                    groupItems.AddSimpleFor(m => m.KhuTrung);
                                                                    groupItems.AddSimpleFor(m => m.GiayChongAm);
                                                                    groupItems.AddSimpleFor(m => m.Booking);
                                                                    groupItems.AddSimpleFor(m => m.HangTau);
                                                                    groupItems.AddSimpleFor(m => m.VanChuyen);
                                                                    groupItems.AddSimpleFor(m => m.Marking);
                                                                    groupItems.AddSimpleFor(m => m.GhiChu);
                                                                    groupItems.AddSimpleFor(m => m.NgayGiao);
                                                                    groupItems.AddSimpleFor(m => m.TgcatMang);
                                                                    groupItems.AddSimpleFor(m => m.GhiChuBaobi);
                                                                });
                                                            items.AddGroup()
                                                                    .Caption("Số lượng - quy cách đóng hàng")
                                                                    .ColCount(2)
                                                                    .ColSpan(2)
                                                                    .Items(groupItems =>
                                                                    {
                                                                        groupItems.AddSimpleFor(m => m.Soluongcont);
                                                                        groupItems.AddSimpleFor(m => m.Loaicont);
                                                                        groupItems.AddSimpleFor(m => m.Cachdong);
                                                                        groupItems.AddSimpleFor(m => m.Trongluong1con);
                                                                        groupItems.AddSimpleFor(m => m.TypeOfBag);
                                                                        groupItems.AddSimpleFor(m => m.Bags);
                                                                        groupItems.AddSimpleFor(m => m.Gw);
                                                                    });
                                                            items.AddGroup()
                                                                    .Caption("Xuất khẩu")
                                                                    .Name("noidia")
                                                                    .ColCount(2)
                                                                    .ColSpan(2)
                                                                    .Items(groupItems =>
                                                                    {
                                                                        groupItems.AddSimpleFor(m => m.KhachMua).Visible(true).ColSpan(2);
                                                                        groupItems.AddSimpleFor(m => m.HopdongMua).Visible(true).ColSpan(2);
                                                                    });
                                                        }).ID("formLenhgiaohang"))

                                        )


                                        .Selection(s => s.Mode(SelectionMode.Single).Deferred(true))
                                        .FilterPanel(f => f.Visible(true))
                                        .HoverStateEnabled(true)
                                        .Export(e => e.Enabled(true))
                                        .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                        .HeaderFilter(hearder => hearder.Visible(true))
                                        .FilterValue(filterValue)
                                        .FilterBuilder(f =>
                                        f.CustomOperations(co =>
                                        {
                                            var o = co.Add();
                                            o.Name("today");
                                            o.Caption("today");
                                            o.DataTypes(new[] { FilterBuilderFieldDataType.DateTime });
                                            o.Icon("check");
                                            o.HasValue(false);
                                            o.CalculateFilterExpression("calculateFilterExpression_lenhgiaohang");
                                        })
                                        .AllowHierarchicalFields(true))
                                        .FilterBuilderPopup(p =>
                                        p.Position(pos =>
                                            pos.At(HorizontalAlignment.Center, VerticalAlignment.Top)
                                                .My(HorizontalAlignment.Center, VerticalAlignment.Top)
                                                .Offset(0, 10)
                                            )
                                        )
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
                                            paper.AllowedPageSizes(new[] { 5, 10, 20, 50 });
                                            paper.ShowInfo(true);
                                        })
                                     );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 281 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("DropDownBoxTemplate_hanghoa"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 283 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                    Write(Html.DevExtreme().DropDownBox()
                                            .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethanghoa").Key("Mahang"))
                                            .Value(new JS("value"))
                                            .ValueExpr("Mahang")
                                            .DisplayExpr("Tenhang")
                                            .DropDownOptions(options => options.Width(700))
                                            .Option("setValue", new JS("setValue"))
                                            .ContentTemplate(new TemplateName("ContentTemplate_hanghoa"))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 291 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 293 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("ContentTemplate_hanghoa"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 295 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethanghoa").Key("Mahang"))
                                                .RemoteOperations(true)
                                                .Height(250)
                                                .Width(700)
                                                .Columns(c =>
                                                {
                                                    c.Add().DataField("Mahang").Caption("Mã hàng");
                                                    c.Add().DataField("Tenhang").Caption("Tên hàng");
                                                    c.Add().DataField("MaNhom").Caption("Nhóm hàng");
                                                })
                                                .Scrolling(s => s.Mode(GridScrollingMode.Virtual))
                                                .HoverStateEnabled(true)
                                                .RemoteOperations(true)
                                                .Selection(s => s.Mode(SelectionMode.Single))
                                                .SelectedRowKeys(new JS("[component.option('value')]"))
                                                .FocusedRowEnabled(true)
                                                .FocusedRowKey(new JS("component.option('value')"))
                                                .OnSelectionChanged("function(selectionChangedArgs) { onSelectionChanged(selectionChangedArgs, component) }")
                                                .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))

                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 316 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 318 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("DropDownBoxTemplate_khachhang"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 320 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                    Write(Html.DevExtreme().DropDownBox()
                                            .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getkhachhang").Key("MaKhach"))
                                            .Value(new JS("value"))
                                            .ValueExpr("MaKhach")
                                            .DisplayExpr("TenKhach")
                                            .DropDownOptions(options => options.Width(700))
                                            .Option("setValue", new JS("setValue"))
                                            .ContentTemplate(new TemplateName("ContentTemplate_khachhang"))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 328 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                         

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 331 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("ContentTemplate_khachhang"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 333 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getkhachhang").Key("MaKhach"))
                                                .RemoteOperations(true)
                                                .Height(250)
                                                .Width(700)
                                                .Columns(c =>
                                                {
                                                    c.Add().DataField("MaKhach").Caption("Mã khách").Width(100);
                                                    c.Add().DataField("TenKhach").Caption("Tên khách").Width(200);
                                                    c.Add().DataField("TenFull").Caption("Tên full");
                                                })
                                                .Scrolling(s => s.Mode(GridScrollingMode.Virtual))
                                                .HoverStateEnabled(true)
                                                .RemoteOperations(true)
                                                .Selection(s => s.Mode(SelectionMode.Single))
                                                .SelectedRowKeys(new JS("[component.option('value')]"))
                                                .FocusedRowEnabled(true)
                                                .FocusedRowKey(new JS("component.option('value')"))
                                                .OnSelectionChanged("function(selectionChangedArgs) { onSelectionChanged(selectionChangedArgs, component) }")
                                                .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))

                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 354 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 356 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("DropDownBoxTemplate_hdmb"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 358 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                    Write(Html.DevExtreme().DropDownBox()
                                            .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethopdong").Key("Sohd"))
                                            .Value(new JS("value"))
                                            .ValueExpr("Sohd")
                                            .DisplayExpr("Sohd")
                                            .DropDownOptions(options => options.Width(700))
                                            .Option("setValue", new JS("setValue"))
                                            .ContentTemplate(new TemplateName("ContentTemplate_hdmb"))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 366 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 368 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("ContentTemplate_hdmb"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 370 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethopdong").Key("Sohd"))
                                                .RemoteOperations(true)
                                                .Height(250)
                                                .Width(700)
                                                .Columns(c =>
                                                {
                                                    c.Add().DataField("Systemref").Caption("Mã hệ thống").Width(100);
                                                    c.Add().DataField("Sohd").Caption("Số hợp đồng");
                                                    c.Add().DataField("Tenfull").Caption("Tên hợp đồng");
                                                })
                                                .Scrolling(s => s.Mode(GridScrollingMode.Virtual))
                                                .HoverStateEnabled(true)
                                                .RemoteOperations(true)
                                                .Selection(s => s.Mode(SelectionMode.Single))
                                                .SelectedRowKeys(new JS("[component.option('value')]"))
                                                .FocusedRowEnabled(true)
                                                .FocusedRowKey(new JS("component.option('value')"))
                                                .OnSelectionChanged("function(selectionChangedArgs) { onSelectionChanged(selectionChangedArgs, component) }")
                                                .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))

                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 391 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Lenhgiaohang\lenhgiaohang.cshtml"
                                         
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
