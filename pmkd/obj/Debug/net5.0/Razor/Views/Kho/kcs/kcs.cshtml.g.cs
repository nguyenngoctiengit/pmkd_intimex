#pragma checksum "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\kcs\kcs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db9425e3168b4dd0336c9751b8e30ff827fe708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kho_kcs_kcs), @"mvc.1.0.view", @"/Views/Kho/kcs/kcs.cshtml")]
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
#line 2 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db9425e3168b4dd0336c9751b8e30ff827fe708", @"/Views/Kho/kcs/kcs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb5032fc71ad384771cb309a8213e095deb506", @"/Views/_ViewImports.cshtml")]
    public class Views_Kho_kcs_kcs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\kcs\kcs.cshtml"
  
    ViewData["Title"] = "kcs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 157, "\"", 165, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Kiểm tra chất lượng</h3>
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
                        <h2>Kiểm tra chất lượng</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
            ");
            WriteLiteral(@"                <li>
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
");
#nullable restore
#line 45 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\kcs\kcs.cshtml"
                          
                            if (TempData["alertMessage"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div style=\"color:red;font-size:30px\">\r\n                                    ");
#nullable restore
#line 49 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\kcs\kcs.cshtml"
                               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 51 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\kcs\kcs.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <div class=""card-box table-responsive"">
");
#nullable restore
#line 59 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\kcs\kcs.cshtml"
                                      
                                        var filterValue = new object[]
                                        {
                                            new object[]{ "NgayNhap", DateTime.Now }
                                        };
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 65 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\kcs\kcs.cshtml"
                                Write(Html.DevExtreme().DataGrid<pmkd.Models.Kc>()
                                        .ID("gridKcs")
                                        .DataSource(d => d.Mvc().LoadAction("getKcs")
                                                                .Controller("kho")
                                                                .Key("SoPhieu")
                                                                .InsertAction("insertKcs")
                                                                .UpdateAction("updateKcs"))
                                        .RemoteOperations(true)
                                        .Columns(colunms => {
                                            colunms.AddFor(m => m.SoPhieu).Caption("Số phiếu");

                                            colunms.AddFor(m => m.XeVc).Caption("Số xe");

                                            colunms.AddFor(m => m.NgayNhap).Caption("Ngày cân");

                                            colunms.AddFor(m => m.KhachHang).Caption("Khách hàng");

                                            colunms.AddFor(m => m.TenKhach).Caption("Tên khách");

                                            colunms.AddFor(m => m.LoaiBao).Caption("Loại bao").Lookup(a => a.DataSource(d => d.Mvc()
                                                                                                                                .Controller("lookup")
                                                                                                                                .LoadAction("getloaibao"))
                                                                                                            .DisplayExpr("Name")
                                                                                                            .ValueExpr("BagTypeId"));

                                            colunms.AddFor(m => m.TenHang).Caption("Hàng hóa");

                                            colunms.AddFor(m => m.SoLuong).Caption("Số bao");

                                            colunms.AddFor(m => m.TrongLuong).Caption("Trọng lượng GW");

                                            colunms.AddFor(m => m.TrongLuongNw).Caption("Trọng lượng NW");

                                            colunms.AddFor(m => m.NguonHang).Caption("Nguồn hàng");

                                            colunms.AddFor(m => m.NguoiKiem).Caption("Người kiểm");

                                            colunms.AddFor(m => m.NguoiLayMau).Caption("Người lấy mẫu");

                                            colunms.AddFor(m => m.PhuTrach).Caption("Người phụ trách");

                                            colunms.AddFor(m => m.Ghichu).Caption("Ghi chú");

                                            colunms.AddFor(m => m.DoAm).Caption("Độ ẩm").Visible(false);

                                            colunms.AddFor(m => m.TapChat).Caption("Tạp chất").Visible(false);

                                            colunms.AddFor(m => m.DenVo).Caption("Độ vỡ").Visible(false);

                                            colunms.AddFor(m => m.HatMoc).Caption("Mốc").Visible(false);

                                            colunms.AddFor(m => m.HatNau).Caption("Nâu").Visible(false);

                                            colunms.AddFor(m => m.HatCxk).Caption("K.loài").Visible(false);

                                            colunms.AddFor(m => m.TrangXop).Caption("Tr.Xốp").Visible(false);

                                            colunms.AddFor(m => m.HatChay).Caption("H.cháy").Visible(false);

                                            colunms.AddFor(m => m.Sang20).Caption("Sàng 20").Visible(false);

                                            colunms.AddFor(m => m.Sang19).Caption("Sàng 19").Visible(false);

                                            colunms.AddFor(m => m.Sang18).Caption("Sàng 18").Visible(false);

                                            colunms.AddFor(m => m.Sang17).Caption("Sàng 17").Visible(false);

                                            colunms.AddFor(m => m.Sang16).Caption("Sàng 16").Visible(false);

                                            colunms.AddFor(m => m.Sang15).Caption("Sàng 15").Visible(false);

                                            colunms.AddFor(m => m.Sang14).Caption("Sàng 14").Visible(false);

                                            colunms.AddFor(m => m.Sang13).Caption("Sàng 13").Visible(false);

                                            colunms.AddFor(m => m.Sang12).Caption("Sàng 12").Visible(false);

                                            colunms.AddFor(m => m.Sang8).Caption("Sàng 8").Visible(false);

                                        })
                                        .MasterDetail(m => m.Enabled(true).Template(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-4 col-sm-4"">Tiêu chuẩn chất lượng</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Độ ẩm</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Tạp chất</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Độ vỡ</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Mốc</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Nâu</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">K.loài</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Tr.Xốp</label>
                                           ");
    WriteLiteral(@"     <label class=""col-form-label col-md-1 col-sm-1"">H.cháy</label>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-4 col-sm-4""></label>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.DoAm%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.TapChat%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" ");
    WriteLiteral(@"class=""form-control"" style=""height:30px"" value=""<%- data.DenVo%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.HatMoc%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.HatNau%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.HatCxk%>"" readonly>
                                                </div>
                                 ");
    WriteLiteral(@"               <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.TrangXop%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.HatChay%>"" readonly>
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"">Tiêu chuẩn cơ lý</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 20</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 19</label>
        ");
    WriteLiteral(@"                                        <label class=""col-form-label col-md-1 col-sm-1"">Sàng 18</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 17</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 16</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 15</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 14</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 13</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 12</label>
                                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 8</label>
                                            </div>
                                            <div class=""form-group row"">
   ");
    WriteLiteral(@"                                             <label class=""col-form-label col-md-2 col-sm-2""></label>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang20%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang19%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang18%>"" readonly>
                                                </div>
                                                <div class=""col");
    WriteLiteral(@"-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang17%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang16%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang15%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang14%>"" readonly>");
    WriteLiteral(@"
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang13%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang12%>"" readonly>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"" value=""<%- data.Sang8%>"" readonly>
                                                </div>
                                            </div>
                                        ");
    PopWriter();
}
)))
                                        .Editing(e => e.Mode(GridEditMode.Popup)
                                            .AllowUpdating(true)
                                            .UseIcons(true)
                                            .Popup(p => p
                                                    .Title("KCS")
                                                    .ShowTitle(true)
                                                    .Width(700)
                                                    .Height(500))
                                            .Form(f => f.Items(items => {
                                                items.AddGroup()
                                                    .ColCount(2)
                                                    .ColSpan(2)
                                                    .Items(groupItems =>
                                                    {
                                                        groupItems.AddSimpleFor(a => a.XeVc).Editor(e => e.TextBox().Disabled(true));

                                                        groupItems.AddSimpleFor(a => a.NgayNhap).Editor(e => e.DateBox().Disabled(true));

                                                        groupItems.AddSimpleFor(a => a.TenKhach).Editor(e => e.TextBox().Disabled(true));

                                                        groupItems.AddSimpleFor(a => a.TenHang).Editor(e => e.TextBox().Disabled(true));

                                                        groupItems.AddSimpleFor(a => a.SoLuong).Editor(e => e.TextBox().Disabled(true));

                                                        groupItems.AddSimpleFor(a => a.LoaiBao).Editor(e => e.TextBox().Disabled(true));

                                                        groupItems.AddSimpleFor(a => a.TrongLuong).Editor(e => e.TextBox().Disabled(true));

                                                        groupItems.AddSimpleFor(a => a.TrongLuongNw).Editor(e => e.TextBox().Disabled(true));
                                                    });
                                                items.AddGroup()
                                                    .Caption("Tiêu chuẩn chất lượng")
                                                    .ColCount(2)
                                                    .ColSpan(2)
                                                    .Items(groupItems =>
                                                    {

                                                        groupItems.AddSimpleFor(a => a.DoAm);

                                                        groupItems.AddSimpleFor(a => a.TapChat);

                                                        groupItems.AddSimpleFor(a => a.DenVo);

                                                        groupItems.AddSimpleFor(a => a.HatMoc);

                                                        groupItems.AddSimpleFor(a => a.HatNau);

                                                        groupItems.AddSimpleFor(a => a.HatCxk);

                                                        groupItems.AddSimpleFor(a => a.TrangXop);

                                                        groupItems.AddSimpleFor(a => a.HatChay);

                                                    });
                                                items.AddGroup()
                                                    .Caption("Tiêu chuẩn cơ lý")
                                                    .ColCount(2)
                                                    .ColSpan(2)
                                                    .Items(groupItems =>
                                                    {

                                                        groupItems.AddSimpleFor(a => a.Sang20);

                                                        groupItems.AddSimpleFor(a => a.Sang19);

                                                        groupItems.AddSimpleFor(a => a.Sang18);

                                                        groupItems.AddSimpleFor(a => a.Sang17);

                                                        groupItems.AddSimpleFor(a => a.Sang16);

                                                        groupItems.AddSimpleFor(a => a.Sang15);

                                                        groupItems.AddSimpleFor(a => a.Sang14);

                                                        groupItems.AddSimpleFor(a => a.Sang13);

                                                        groupItems.AddSimpleFor(a => a.Sang12);

                                                        groupItems.AddSimpleFor(a => a.Sang8);


                                                    });
                                                items.AddGroup()
                                                    .ColCount(2)
                                                    .ColSpan(2)
                                                    .Items(groupItems =>
                                                    {

                                                        groupItems.AddSimpleFor(a => a.NguonHang).ColSpan(2);

                                                        groupItems.AddSimpleFor(a => a.NguoiKiem);

                                                        groupItems.AddSimpleFor(a => a.NguoiLayMau);

                                                        groupItems.AddSimpleFor(a => a.PhuTrach);

                                                        groupItems.AddSimpleFor(a => a.Ghichu);

                                                    });

                                            }))

                                        )

                                        .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                        .FilterPanel(f => f.Visible(true))
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
                                            o.CalculateFilterExpression("calculateFilterExpression_kcs");
                                        })
                                        .AllowHierarchicalFields(true))
                                        .FilterBuilderPopup(p =>
                                        p.Position(pos =>
                                            pos.At(HorizontalAlignment.Center, VerticalAlignment.Top)
                                                .My(HorizontalAlignment.Center, VerticalAlignment.Top)
                                                .Offset(0, 10)
                                            )
                                        )
                                        .OnToolbarPreparing("toolbar_kcs")
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
            WriteLiteral(@"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
