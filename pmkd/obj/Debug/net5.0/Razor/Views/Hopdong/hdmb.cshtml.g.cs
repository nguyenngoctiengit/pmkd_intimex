#pragma checksum "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1d0088112cfdb493ab7b0c777a7453a0cbbc22"
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
#line 2 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d0088112cfdb493ab7b0c777a7453a0cbbc22", @"/Views/Hopdong/hdmb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f3fdee9548d5779914426f2f6cb4c3005f9059", @"/Views/_ViewImports.cshtml")]
    public class Views_Hopdong_hdmb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hdmb>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
  
    ViewData["Title"] = "hdmb";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 201, "\"", 209, 0);
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
#line 24 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
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
#line 67 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                Write(Html.DevExtreme().DataGrid<pmkd.Models.Hdmb>()
                                        .DataSource(ds => ds.Mvc()
                                            .Controller("hopdong")
                                            .LoadAction("Get")
                                            .UpdateAction("Put")
                                            .DeleteAction("Delete")
                                            .Key("Systemref")
                                        )
                                        .RemoteOperations(true)
                                        .Columns(columns => {

                                            columns.AddFor(m => m.Macn).Caption("Mã chi nhánh").Visible(false).Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("lookup").LoadAction("getdonvi").Key("Id"))
                                                                                                                                      .DisplayExpr("NameE").ValueExpr("Id"));
                                            columns.AddFor(m => m.Systemref).Caption("ID hệ thống").Fixed(true);

                                            columns.AddFor(m => m.Ref).Caption("Ref").Fixed(true);

                                            columns.AddFor(m => m.Sohd).Caption("Số HĐ");

                                            columns.AddFor(m => m.Trangthai).GroupIndex(1).Caption("Trạng thái").Lookup(lookup => lookup.DataSource(new JS("Trangthai")).ValueExpr("id").DisplayExpr("name"));

                                            columns.AddFor(m => m.MuaBan).GroupIndex(0).Caption("Mua bán");

                                            columns.AddFor(m => m.Makhach).Caption("Mã khách").Visible(false);

                                            columns.AddFor(m => m.Ngayky).Caption("Ngày ký");

                                            columns.AddFor(m => m.Ngaygiao).Caption("Ngày giao");

                                            columns.AddFor(m => m.Ngayhl).Caption("Ngày hiệu lực");

                                            columns.AddFor(m => m.IntKy).Caption("INT kí").CalculateCellValue("intky");

                                            columns.AddFor(m => m.ClientKy).Caption("Khách kí").CalculateCellValue("khachky");

                                            columns.AddFor(m => m.Nguoilam).Caption("Người làm").Visible(false);

                                            columns.AddFor(m => m.Ghichu).Caption("Ghi chú").Visible(false);

                                            columns.AddFor(m => m.Pakd).Caption("PAKD").Visible(false);

                                            columns.AddFor(m => m.IsFix).Caption("Hình thức giá").Visible(false).Lookup(lookup => lookup
                                                                                                                        .DataSource(new JS("isfix")).ValueExpr("id").DisplayExpr("name"));

                                            columns.AddFor(m => m.Tiente).Caption("Tiền tệ").Visible(false);

                                            columns.AddFor(m => m.ThanhtoanId).Caption("Thanh toán").Visible(false).Lookup(lookup => lookup
                                                                                                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getpttt").Key("Id"))
                                                                                                                        .ValueExpr("Id")
                                                                                                                        .DisplayExpr("TenTt")
                                                                                                                        .AllowClearing(true))
                                                                                                                   .EditCellTemplate(new TemplateName("DropDownBoxTemplate"));

                                            columns.AddFor(m => m.Thanhtoan).Caption("CT thanh toán").Visible(false);

                                            columns.AddFor(m => m.Ngaylam).Caption("Ngày làm").Visible(false);

                                            columns.AddFor(m => m.TrangthaiGhep).Caption("Trạng thái ghép").Visible(false);

                                            columns.AddFor(m => m.TienUngHd).Caption("Tạm ứng theo HĐ").Visible(false);

                                            columns.AddFor(m => m.TienUngTt).Caption("Tạm ứng thực tế").Visible(false);

                                            columns.AddFor(m => m.HdcmuonId).Caption("Hợp đồng cho mượn").Visible(false);

                                            columns.AddFor(m => m.SoHdcmuon).Caption("Số hợp đồng cho mượn").Visible(false);

                                            columns.AddFor(m => m.DiaDiemGiaoHang).Caption("Địa điểm giao hàng").Visible(false).Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("lookup").LoadAction("getdiadiemgiaohang").Key("DiaDiemGiaoHang"))
                                                                                                                                                .ValueExpr("DiaDiemGiaoHang")
                                                                                                                                                .DisplayExpr("DiaDiemGiaoHang"));

                                            columns.AddFor(m => m.IsNoKhoDoi).Caption("Nợ khó đòi").Visible(false);

                                            columns.AddFor(m => m.TypeKd).Caption("Hình thức kinh doanh").Visible(false).Lookup(lookup => lookup.DataSource(new JS("TypeKd")).ValueExpr("id").DisplayExpr("name"));

                                            columns.AddFor(m => m.VanChuyen).Caption("Vận chuyển").Visible(false);

                                            columns.AddFor(m => m.NgayTraPhaitra).Caption("Ngày trả").Visible(false);

                                        })
                                        .Editing(e => e
                                            .Mode(GridEditMode.Popup)
                                            .Popup(p => p.Title("Hợp đồng").ShowTitle(true).Width(700).Height(500))
                                            .AllowUpdating(true)
                                            .AllowDeleting(true)
                                            .UseIcons(true)

                                        )
                                        .OnToolbarPreparing("toolbarhdmb")
                                        .ID("hdmb")
                                        .MasterDetail(m => m.Enabled(true).Template(new TemplateName("cthdmb")))
                                        .Selection(s => s.Mode(SelectionMode.Single).Deferred(true))
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
                                            paper.AllowedPageSizes(new[] { 5, 10, 20, 50 });
                                            paper.ShowInfo(true);
                                        })
                                    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 180 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("DropDownBoxTemplate"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 182 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                    Write(Html.DevExtreme().DropDownBox()
                                            .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getpttt").Key("Id"))
                                            .Value(new JS("value"))
                                            .ValueExpr("Id")
                                            .DisplayExpr("TenTt")
                                            .DropDownOptions(options => options.Width(500))
                                            .Option("setValue", new JS("setValue"))
                                            .ContentTemplate(new TemplateName("ContentTemplate"))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 193 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("ContentTemplate"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getpttt").Key("Id"))
                                                .RemoteOperations(true)
                                                .Height(250)
                                                .Columns(c =>
                                                {
                                                    c.Add().DataField("Matt").Caption("Mã thanh toán");
                                                    c.Add().DataField("TenTt").Caption("Tên thanh toán");
                                                    c.Add().DataField("Mucung").Caption("Mức ứng");
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
#line 215 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 218 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("cthdmb"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 220 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                    Write(Html.DevExtreme().DataGrid<pmkd.Models.CtHdmb>()
                                                .DataSource(ds => ds.Mvc()
                                                    .Controller("hopdong")
                                                    .LoadAction("Getcthdmb")
                                                    .Key("Id")
                                                    .LoadParams(new { id = new JS("data.Systemref") })
                                                )
                                                .RemoteOperations(true)
                                                .Columns(columns =>
                                                {
                                                columns.Add().CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                                                <% if");
    BeginWriteAttribute("(data.isfix", " (data.isfix =", 15275, "", 15289, 0);
    EndWriteAttribute();
    WriteLiteral("= false) { %>\r\n                                                <div>\r\n                                                    <a class=\'btn btn-default btn-sm\' onclick=PopupFormEdit(\'");
#nullable restore
#line 233 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                                                        Write(Url.Action("updatecthdoutright","hopdong"));

#line default
#line hidden
#nullable disable
    WriteLiteral(@"/<%= data.Id%>')><i class='fa fa-pencil'></i> Edit</a> /
                                                    <a class='btn btn-default btn-sm' style='margin-left:5px' onclick=""return confirm('Are you sure you want to delete this item?');"" href=""hopdong/deletecthd/<%= data.Id%>"" type=""submit""><i class='fa fa-trash'></i> Delete</a>
                                                </div>
                                                <% } else {%>
                                                    <div>
                                                        <a class='btn btn-default btn-sm' onclick=PopupFormEdit('");
#nullable restore
#line 238 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                                                                                            Write(Url.Action("updatecthd","hopdong"));

#line default
#line hidden
#nullable disable
    WriteLiteral(@"/<%= data.Id%>')><i class='fa fa-pencil'></i> Edit</a> /
                                                        <a class='btn btn-default btn-sm' style='margin-left:5px' onclick=""return confirm('Are you sure you want to delete this item?');"" href=""hopdong/deletecthd/<%= data.Id%>"" type=""submit""><i class='fa fa-trash'></i> Delete</a>
                                                    </div>
                                                <% } %>
                                                ");
    PopWriter();
}
)).VisibleIndex(0).Fixed(true);

                                                columns.AddFor(m => m.Systemref).Caption("ID hệ thống").AllowFixing(false).Fixed(true);

                                                columns.AddFor(m => m.Mahang).Caption("Mã hàng").Fixed(true);

                                                columns.Add().Caption("Tên hàng").CalculateCellValue(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("function(data){return data.tenhang}");
    PopWriter();
}
)).AllowFixing(false);

                                                columns.AddFor(m => m.Ref).Caption("Ref").Visible(false);

                                                columns.AddFor(m => m.Soluong).Caption("Số lượng");

                                                columns.AddFor(m => m.Trongluong).Caption("Trọng lượng");

                                                columns.AddFor(m => m.Dvt).Caption("Đơn vị tính");

                                                columns.AddFor(m => m.Giact).Caption("Giá").Format(Format.FixedPoint);

                                                columns.AddFor(m => m.Giatt).Caption("Giá tạm tính").Format(Format.FixedPoint);

                                                columns.AddFor(m => m.Vat).Caption("VAT");

                                                columns.AddFor(m => m.Sig).Caption("+ / -");

                                                columns.AddFor(m => m.Diff).Caption("Mức trừ");

                                                columns.AddFor(m => m.Stoploss).Caption("Stop loss");

                                                columns.AddFor(m => m.Giacuoi).Caption("Giá cuối");

                                                columns.AddFor(m => m.Solot).Caption("Số lot");

                                                columns.AddFor(m => m.Status).Caption("Trạng thái").Visible(false);

                                                columns.AddFor(m => m.Giathang).Caption("Giá tháng").Visible(false);

                                                columns.AddFor(m => m.Gianam).Caption("Giá năm").Visible(false);

                                                columns.AddFor(m => m.Giathitruong).Caption("Giá thị trường").Visible(false);

                                                columns.AddFor(m => m.Mucthuong).Caption("Mức thưởng").Visible(false);

                                                })
                                                .OnToolbarPreparing("toolbarcthdmb")
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
                                                    paper.AllowedPageSizes(new[] { 5, 10, 20, 50 });
                                                    paper.ShowInfo(true);
                                                })
                                                .Summary(s => s.TotalItems(item =>
                                                {

                                                    item.AddFor(m => m.Soluong).SummaryType(SummaryType.Sum).ValueFormat(Format.FixedPoint);
                                                    item.AddFor(m => m.Trongluong).SummaryType(SummaryType.Sum).ValueFormat(Format.FixedPoint);

                                                }).RecalculateWhileEditing(true))
                                           );

#line default
#line hidden
#nullable disable
#nullable restore
#line 314 "C:\Users\User\Desktop\pmkd_intimex\pmkd\Views\Hopdong\hdmb.cshtml"
                                            
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
