#pragma checksum "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee5de0dafaf7faeae87854662a7985720dd86927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hanghoa_hanghoa), @"mvc.1.0.view", @"/Views/Hanghoa/hanghoa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5de0dafaf7faeae87854662a7985720dd86927", @"/Views/Hanghoa/hanghoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb5032fc71ad384771cb309a8213e095deb506", @"/Views/_ViewImports.cshtml")]
    public class Views_Hanghoa_hanghoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hanghoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
  
    ViewData["Title"] = "hanghoa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 186, "\"", 194, 0);
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
#line 23 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
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
#line 66 "C:\Users\Windows 10\Desktop\pmkd_project\pmkd\Views\Hanghoa\hanghoa.cshtml"
                                Write(Html.DevExtreme().DataGrid<pmkd.Models.Hanghoa>().ID("gridContainer")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("hanghoa")
                                        .LoadAction("Get")
                                        .InsertAction("Post")
                                        .UpdateAction("Put")
                                        .DeleteAction("Delete")
                                        .Key("Idhanghoa", "Mahang")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.Idhanghoa).Visible(false).Caption("ID hàng hóa").AllowEditing(false);

                                        columns.AddFor(m => m.Mahang).Fixed(true).Caption("Mã hàng");

                                        columns.AddFor(m => m.Tenhang).Caption("Tên hàng");

                                        columns.AddFor(m => m.Tenhangvat).Caption("Tên hàng VAT");

                                        columns.AddFor(m => m.MaNhom).Caption("Mã nhóm").Lookup(lookup => lookup
                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("Getnhomhang").Key("Manhom"))
                                        .DisplayExpr("Manhom")
                                        .ValueExpr("Manhom")
                                        );

                                        columns.AddFor(m => m.Dvt).Caption("DVT").Lookup(lookup => lookup
                                        .DataSource(new[] { "KGS","TAN","CAI"})
                                        );

                                        columns.AddFor(m => m.Vat).Caption("Vat").Lookup(lookup => lookup
                                        .DataSource(new[] { "0","5","10"})
                                        );

                                        columns.AddFor(m => m.Sudung).Caption("Sử dụng").Visible(false).Lookup(lookup => lookup.DataSource(new JS("sudung_hanghoa")).ValueExpr("id").DisplayExpr("name"));

                                        columns.AddFor(m => m.Fullname).Caption("Tên đầy đủ").Visible(false);

                                        columns.AddFor(m => m.Quicach).Caption("Qui cách").Visible(false);

                                        columns.AddFor(m => m.Baobi).Caption("Bao bì").Visible(false);

                                        columns.AddFor(m => m.Kiemdinh).Caption("Kiểm định").Visible(false);

                                    })
                                    .Editing(e => e
                                        .Mode(GridEditMode.Popup)
                                        .Popup(p => p.Title("Hàng hóa").ShowTitle(true).Width(700).Height(500))
                                        .AllowAdding(true)
                                        .AllowUpdating(true)
                                        .AllowDeleting(true)
                                        .UseIcons(true)
                                        .Form(f => f.Items(items => {
                                            items.AddGroup()
                                                    .ColCount(2)
                                                    .ColSpan(2)
                                                    .Items(groupItems =>
                                                    {
                                                        groupItems.AddSimpleFor(m => m.Mahang);
                                                        groupItems.AddSimpleFor(m => m.Tenhang);
                                                        groupItems.AddSimpleFor(m => m.Tenhangvat);
                                                        groupItems.AddSimpleFor(m => m.Dvt);
                                                        groupItems.AddSimpleFor(m => m.Vat);
                                                        groupItems.AddSimpleFor(m => m.Sudung);
                                                        groupItems.AddSimpleFor(m => m.Fullname).ColSpan(2);
                                                        groupItems.AddSimpleFor(m => m.Quicach).ColSpan(2).Editor(e => e.TextArea().Height(70));
                                                        groupItems.AddSimpleFor(m => m.Baobi).ColSpan(2).Editor(e => e.TextArea().Height(70));
                                                        groupItems.AddSimpleFor(m => m.Kiemdinh).ColSpan(2).Editor(e => e.TextArea().Height(70));

                                                    });


                                        }))
                                    )

                                    .OnToolbarPreparing("toolbarhanghoa")
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hanghoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
