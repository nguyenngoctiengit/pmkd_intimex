#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\_PartiView_AddArchive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bec81de68761ceb4e4557615ad3c47b4bcb9815d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocCome__PartiView_AddArchive), @"mvc.1.0.view", @"/Views/DocCome/_PartiView_AddArchive.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec81de68761ceb4e4557615ad3c47b4bcb9815d", @"/Views/DocCome/_PartiView_AddArchive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_DocCome__PartiView_AddArchive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-body\">\r\n    <input type=\"text\" id=\"DocId\"");
            BeginWriteAttribute("value", " value=\"", 59, "\"", 81, 1);
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\_PartiView_AddArchive.cshtml"
WriteAttributeValue("", 67, ViewBag.DocId, 67, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden>\r\n    <div class=\"card-box table-responsive\">\r\n        ");
#nullable restore
#line 4 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\_PartiView_AddArchive.cshtml"
    Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Sp_GetArchivesForAdd>().ID("dataGrib_archive")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("DocCome")
                                        .LoadAction("GetArchive")
                                        .LoadParams(new { id = ViewBag.DocId })
                                        .Key("ArchivesId")
                                    )
                                    .Columns(columns => {
                                        columns.AddFor(a => a.ArchivesId).Visible(false);

                                        columns.AddFor(a => a.ArchivesName).Caption("Tên công việc");

                                        columns.AddFor(a => a.ArchivesTypeArchives).Caption("Loại hồ sơ");

                                        columns.AddFor(a => a.StatusArchives).Caption("Trạng thái");
                                    })
                                    .Selection(s => s.Mode(SelectionMode.Multiple).Deferred(true))
                                    .HoverStateEnabled(true)
                                    .ShowBorders(true)
                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                    .HeaderFilter(hearder => hearder.Visible(true))
                                    .AllowColumnResizing(true)
                                    .AllowColumnReordering(true)
                                    .ColumnAutoWidth(true)
                                    .ColumnFixing(c => c.Enabled(true))
                                    .Grouping(group => group.AutoExpandAll(true))
                                    .Paging(paging => paging.PageSize(5))
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
<div class=""modal-footer"">
    <button type=""button"" id=""btn_Save"" onclick=""AddArchive()"" class=""btn btn-outline-dark"">Lưu</button>
</div>
<script type=""text/javascript"">
    function getDataGridInstance() {
        return $(""#dataGrib_archive"").dxDataGrid(""instance"");
    }
    var DocId = document.getElementById('DocId').value; 
    function AddArchive() {
        getDataGridInstance().getSelectedRowsData().done(function (rowData) {
            var array = []
            rowData.forEach(element => { array.push(element.ArchivesId) })
            $.ajax({
                traditional: true,
                type: 'POST',
                url: '/DocCome/addarchive1',
                dataType: 'JSON',
                data: { array: array, DocId: DocId },
                success: function (data) {
                    window.location.href = data
                },
                error: function (request) {
                    $.notify(""Something went wrong!!"", ""error"");
");
            WriteLiteral(@"                }
            })
        })
    }
    function SaveForDocProcess() {
        getDataGridInstance().getSelectedRowsData().done(function (rowData) {
            var array = []
            rowData.forEach(element => { array.push(element.ArchivesId) })
            $.ajax({
                traditional: true,
                type: 'POST',
                url: '/DocProcess/addarchive1',
                dataType: 'JSON',
                data: { array: array, DocId: DocId },
                success: function (data) {
                    window.location.href = data
                },
                error: function (request) {
                    $.notify(""Something went wrong!!"", ""error"");
                }
            })
        })
    }
    function SaveForDocGo() {
        getDataGridInstance().getSelectedRowsData().done(function (rowData) {
            var array = []
            rowData.forEach(element => { array.push(element.ArchivesId) })
            $.ajax({
         ");
            WriteLiteral(@"       traditional: true,
                type: 'POST',
                url: '/DocGo/addarchive1',
                dataType: 'JSON',
                data: { array: array, DocId: DocId },
                success: function (data) {
                    window.location.href = data
                },
                error: function (request) {
                    $.notify(""Something went wrong!!"", ""error"");
                }
            })
        })
    }
</script>");
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
