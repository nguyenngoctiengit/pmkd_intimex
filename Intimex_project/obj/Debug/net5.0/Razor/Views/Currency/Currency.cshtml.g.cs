#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\Currency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ccf993cc32c70fdd29f3903b10d46bc67be3f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currency_Currency), @"mvc.1.0.view", @"/Views/Currency/Currency.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ccf993cc32c70fdd29f3903b10d46bc67be3f84", @"/Views/Currency/Currency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Currency_Currency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\Currency.cshtml"
  
    ViewData["Title"] = "Currency";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .image_DocCome {
        width: 50px;
        height: 50px;
    }

    .modal-dialog {
        overflow-y: initial !important
    }

    .modal-body {
        max-height: calc(100vh - 200px);
        overflow-y: auto;
    }
</style>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js""></script>
<link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" rel=""stylesheet"" />
<div class=""right_col"" role=""main"" style=""height: 500px"">
    <div");
            BeginWriteAttribute("class", " class=\"", 632, "\"", 640, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Thông tin tiền tệ</h3>
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
#line 41 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\Currency.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\Currency.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\Currency.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Tiền tệ</h2>
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
            WriteLiteral(@"                      </li>
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
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 79 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\Currency.cshtml"
                                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Dmtte>().ID("Dmtte")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("Currency")
                                        .LoadAction("GetCurrency")
                                        .DeleteAction("Delete")
                                        .Key("Id")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.MaTte).Caption("Mã tiền tệ");

                                        columns.AddFor(m => m.NgayAd).Caption("Ngày áp dụng");

                                        columns.AddFor(m => m.Tyle).Caption("Tranfer rate");

                                        columns.AddFor(m => m.Tyle1).Caption("Buying rate");

                                        columns.AddFor(m => m.Tyle2).Caption("Selling rate");
                                    })
                                    .Editing(e => e
                                        .AllowDeleting(true)
                                        .UseIcons(true)
                                    )
                                    .HoverStateEnabled(true)
                                    .ShowBorders(true)
                                    .OnSelectionChanged("SelectedCurrency")
                                    .Selection(a => a.Mode(SelectionMode.Single))
                                    .OnToolbarPreparing("toolbar_DocCome")
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
            WriteLiteral(@"                                    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                                        <div class=""modal-dialog modal-lg modal-dialog-scrollable"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <button type=""button"" class=""close"" onclick=""Close_myModal()"">&times;</button>
                                                </div>
                                                <div id=""_PartiView_AddOrUpdate_Currency"">

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <input type=""text"" id=""Id"" hidden>
");
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function SelectedCurrency(selectedItems) {
        var data = selectedItems.selectedRowsData[0];
        if (data) {
            document.getElementById(""Id"").value = data.Id;
        }
    }
    function Close_myModal() {
        $(""#myModal"").modal(""hide"");
    }
    function toolbar_DocCome(e) {
        e.toolbarOptions.items.unshift({
            location: ""after"",
            widget: ""dxButton"",
            options: {
                icon: ""add"",
                onClick: function () {
                    $.post('/Currency/AddOrEditCurrency', function (response) {
                        $(""#_PartiView_AddOrUpdate_Currency"").html(response);
                        $(""#myModal"").modal(""show"");

                    })
                }
            }
        }");
            WriteLiteral(@");
        e.toolbarOptions.items.unshift({
            location: ""after"",
            widget: ""dxButton"",
            options: {
                icon: ""edit"",
                onClick: function () {
                    var Id = document.getElementById(""Id"").value;
                    if (Id) {
                        $.post('/Currency/AddOrEditCurrency', { 'Id': Id }, function (response) {
                            $(""#_PartiView_AddOrUpdate_Currency"").html(response);
                            $(""#myModal"").modal(""show"");
                        })
                    } else {
                        $.notify(""please choose the document you want to edit!"", ""error"");
                    }

                },
            }
        })
    }
</script>
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
