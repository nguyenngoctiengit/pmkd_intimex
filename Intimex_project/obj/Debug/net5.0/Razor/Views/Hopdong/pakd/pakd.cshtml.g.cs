#pragma checksum "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ce629abad8fcbf0c2c2ee0238bc642b8798681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hopdong_pakd_pakd), @"mvc.1.0.view", @"/Views/Hopdong/pakd/pakd.cshtml")]
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
#line 1 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\_ViewImports.cshtml"
using Intimex_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\_ViewImports.cshtml"
using Intimex_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ce629abad8fcbf0c2c2ee0238bc642b8798681", @"/Views/Hopdong/pakd/pakd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Hopdong_pakd_pakd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
  
    ViewData["Title"] = "pakd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 160, "\"", 168, 0);
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
#line 25 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Phương án kinh doanh</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                            <li>
                                <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                            </li>
                            <li class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item"" href=""#"">Settings 1</a>
                                    <a class=""dropdown-item"" href=""#"">Settings 2</a>
                                </d");
            WriteLiteral(@"iv>
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
#line 68 "C:\Users\Windows 10\Desktop\Intimex_project\Intimex_project\Views\Hopdong\pakd\pakd.cshtml"
                                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Plan>()
                                        .DataSource(ds => ds.Mvc()
                                            .Controller("hopdong")
                                            .LoadAction("getpakd")
                                            .UpdateAction("updatepakd")
                                            .InsertAction("insertpakd")
                                            .DeleteAction("deletepakd")
                                            .Key("SystemId")
                                        )
                                        .RemoteOperations(true)
                                        .Columns(columns => {

                                            columns.AddFor(m => m.SystemId).Caption("System ID").Fixed(true);

                                            columns.AddFor(m => m.SoPa).Caption("Số PA").Fixed(true);

                                            columns.AddFor(m => m.NgayPa).Caption("Ngày").Fixed(true);

                                            columns.AddFor(m => m.DoiTacMua).Caption("Đối tác INT bán");

                                            columns.AddFor(m => m.HdMua).Caption("HĐ bán");

                                            columns.AddFor(m => m.DanhGiaMua).Caption("Đánh giá KH INT bán");

                                            columns.AddFor(m => m.DoiTacBan).Caption("Đối tác INT mua");

                                            columns.AddFor(m => m.HdBan).Caption("HĐ mua");

                                            columns.AddFor(m => m.DanhGiaBan).Caption("Đánh giá KH INT mua");

                                            columns.AddFor(m => m.HangHoa).Caption("Hàng hóa");

                                            columns.AddFor(m => m.Trongluong).Caption("Trọng lượng");

                                            columns.AddFor(m => m.Dvt).Caption("DVT");

                                            columns.AddFor(m => m.TyGia).Caption("Tỷ giá dự tính");

                                            columns.AddFor(m => m.NguonVon).Caption("Nguồn vốn");

                                            columns.AddFor(m => m.Songay).Caption("TG sử dụng vốn");

                                            columns.AddFor(m => m.DienGiaiNguonVon).Caption("Diễn giải NVSD");

                                            columns.AddFor(m => m.LaiSuat).Caption("Lãi xuất(%/năm)");

                                            columns.AddFor(m => m.Dieukiengiao).Caption("ĐK bán hàng");

                                            columns.AddFor(m => m.CangGiaoHang).Caption("Cảng giao hàng");

                                            columns.AddFor(m => m.NoiNhanHang).Caption("Nơi nhận hàng");

                                            columns.AddFor(m => m.Ngaygiao).Caption("TG giao hàng");

                                            columns.AddFor(m => m.SoCont).Caption("Số cont");

                                            columns.AddFor(m => m.ThanhToanMua).Caption("PTT mua");

                                            columns.AddFor(m => m.ThanhToanBan).Caption("PTT bán");

                                            columns.AddFor(m => m.GhiChu).Caption("Ghi chú");


                                        })
                                        .Editing(e => e
                                            .Mode(GridEditMode.Popup)
                                            .Popup(p => p.Title("Hợp đồng").ShowTitle(true).Width(700).Height(500))
                                            .AllowUpdating(true)
                                            .AllowDeleting(true)
                                            .AllowAdding(true)
                                            .UseIcons(true)

                                        )
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
