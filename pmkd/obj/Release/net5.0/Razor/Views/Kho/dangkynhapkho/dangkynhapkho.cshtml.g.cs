#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "602c25e706142f206078c4742f55a8a1ddd6b63f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kho_dangkynhapkho_dangkynhapkho), @"mvc.1.0.view", @"/Views/Kho/dangkynhapkho/dangkynhapkho.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602c25e706142f206078c4742f55a8a1ddd6b63f", @"/Views/Kho/dangkynhapkho/dangkynhapkho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f3fdee9548d5779914426f2f6cb4c3005f9059", @"/Views/_ViewImports.cshtml")]
    public class Views_Kho_dangkynhapkho_dangkynhapkho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hdmb>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
  
    ViewData["Title"] = "dangkynhapkho";
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
#line 25 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
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
#line 68 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                      
                                        var filterValue = new object[]
                                        {
                                            new object[] { "NgayVao", DateTime.Now }
};
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 74 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                Write(Html.DevExtreme().DataGrid<pmkd.Models.XepTai>()
                                                    .ID("grid")
                                                    .DataSource(d => d.Mvc().Controller("kho")
                                                    .LoadAction("GetXepTai")
                                                    .InsertAction("InsertXepTai")
                                                    .UpdateAction("UpdateXeptai")
                                                    .DeleteAction("DeleteXepTai")
                                                    .Key("Id"))
                                                    .Columns(columns => {

                                                        columns.AddFor(m => m.SoXe).Caption("Số xe").Fixed(true);

                                                        columns.AddFor(m => m.Xeptaiso).Caption("Tài");

                                                        columns.AddFor(m => m.KhoId).Caption("Mã kho").Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("lookup").LoadAction("getkhohang").Key("StockCode"))
                                                                                                                        .DisplayExpr("StockName")
                                                                                                                        .ValueExpr("StockCode")
                                                                                                                        .AllowClearing(true));

                                                        columns.AddFor(m => m.KhoName).Caption("Tên kho").AllowEditing(false);

                                                        columns.AddFor(m => m.NgayVao).Caption("Ngày vào");

                                                        columns.AddFor(m => m.Ngaycan).Caption("Ngày cân");

                                                        columns.AddFor(m => m.MaKhach).Caption("Mã khách").Lookup(lookup => lookup
                                                                                                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getkhachhang").Key("MaKhach"))
                                                                                                                        .ValueExpr("MaKhach")
                                                                                                                        .DisplayExpr("TenKhach")
                                                                                                                        .AllowClearing(true))
                                                                                                                   .EditCellTemplate(new TemplateName("DropDownBoxTemplate_khachhang"));

                                                        columns.AddFor(m => m.KhachHang).Caption("Tên khách hàng").Visible(false);

                                                        columns.AddFor(m => m.Mahang).Caption("Mã hàng").Lookup(lookup => lookup
                                                                                                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethanghoa").Key("Mahang"))
                                                                                                                        .ValueExpr("Mahang")
                                                                                                                        .DisplayExpr("Tenhang")
                                                                                                                        .AllowClearing(true))
                                                                                                                   .EditCellTemplate(new TemplateName("DropDownBoxTemplate_hanghoa"));

                                                        columns.AddFor(m => m.Tenhang).Caption("Tên hàng").Visible(false);

                                                        columns.AddFor(m => m.HopDong).Caption("Hợp đồng").Lookup(lookup => lookup
                                                                                                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethopdong").Key("Sohd"))
                                                                                                                        .ValueExpr("Sohd")
                                                                                                                        .DisplayExpr("Sohd")
                                                                                                                        .AllowClearing(true))
                                                                                                                   .EditCellTemplate(new TemplateName("DropDownBoxTemplate_hdmb"));

                                                        columns.AddFor(m => m.BagTypeId).Caption("Loại bao").Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("lookup").LoadAction("getloaibao").Key("BagTypeId")).DisplayExpr("Name").ValueExpr("BagTypeId")).Width(190);

                                                        columns.AddFor(m => m.SoBao).Caption("Số bao");

                                                        columns.AddFor(m => m.TlBaobi).Caption("TL Bao");

                                                        columns.AddFor(m => m.Status).Caption("Trạng thái").GroupIndex(0).Lookup(lookup => lookup.DataSource(new JS("trangthaichoxeptai")).DisplayExpr("name").ValueExpr("id"));

                                                        columns.AddFor(m => m.Aprove).Caption("Duyệt mẫu").Lookup(lookup => lookup.DataSource(new JS("aprove_xeptai")).DisplayExpr("name").ValueExpr("id"));

                                                        columns.AddFor(m => m.IsHoanThanh).Caption("Hoàn thành ?");

                                                    })
                                                    .OnEditorPrepared("OnEditorPrepared")
                                                    .OnInitNewRow("OnInitNewRow")
                                                    .Editing(e => e
                                                        .Mode(GridEditMode.Popup)
                                                        .AllowUpdating(true)
                                                        .AllowDeleting(true)
                                                        .AllowAdding(true)
                                                        .UseIcons(true)
                                                        .Popup(e => e.OnShowing("OnShowing").Width(700).Height(500))

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
                                            o.CalculateFilterExpression("calculateFilterExpression");
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
#line 192 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("DropDownBoxTemplate_khachhang"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                    Write(Html.DevExtreme().DropDownBox()
                                            .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getkhachhang").Key("MaKhach"))
                                            .Value(new JS("value"))
                                            .ValueExpr("MaKhach")
                                            .DisplayExpr("TenKhach")
                                            .DropDownOptions(options => options.Width(500))
                                            .Option("setValue", new JS("setValue"))
                                            .ContentTemplate(new TemplateName("ContentTemplate_khachhang"))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 204 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("ContentTemplate_khachhang"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 206 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getkhachhang").Key("MaKhach"))
                                                .RemoteOperations(true)
                                                .Height(250)
                                                .Width(500)
                                                .Columns(c =>
                                                {
                                                    c.Add().DataField("MaKhach").Caption("Mã khách");
                                                    c.Add().DataField("TenKhach").Caption("Tên khách");
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
#line 227 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 229 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("DropDownBoxTemplate_hanghoa"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 231 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                    Write(Html.DevExtreme().DropDownBox()
                                            .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethanghoa").Key("Mahang"))
                                            .Value(new JS("value"))
                                            .ValueExpr("Mahang")
                                            .DisplayExpr("Tenhang")
                                            .DropDownOptions(options => options.Width(500))
                                            .Option("setValue", new JS("setValue"))
                                            .ContentTemplate(new TemplateName("ContentTemplate_hanghoa"))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 239 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 241 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("ContentTemplate_hanghoa"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 243 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethanghoa").Key("Mahang"))
                                                .RemoteOperations(true)
                                                .Height(250)
                                                .Width(500)
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
#line 264 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 266 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("DropDownBoxTemplate_hdmb"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 268 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                    Write(Html.DevExtreme().DropDownBox()
                                            .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethopdong").Key("Sohd"))
                                            .Value(new JS("value"))
                                            .ValueExpr("Sohd")
                                            .DisplayExpr("Sohd")
                                            .DropDownOptions(options => options.Width(500))
                                            .Option("setValue", new JS("setValue"))
                                            .ContentTemplate(new TemplateName("ContentTemplate_hdmb"))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 276 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 278 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("ContentTemplate_hdmb"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 280 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                                .DataSource(d => d.Mvc().Controller("lookup").LoadAction("gethopdong").Key("Sohd"))
                                                .RemoteOperations(true)
                                                .Height(250)
                                                .Width(500)
                                                .Columns(c =>
                                                {
                                                    c.Add().DataField("Systemref").Caption("Mã hệ thống");
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
#line 301 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\dangkynhapkho\dangkynhapkho.cshtml"
                                         
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
