#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4ba0b6d9dc912b9c093052bb162d5e275e1d6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Archives__PartiView_DocArchive), @"mvc.1.0.view", @"/Views/Archives/_PartiView_DocArchive.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4ba0b6d9dc912b9c093052bb162d5e275e1d6a", @"/Views/Archives/_PartiView_DocArchive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Archives__PartiView_DocArchive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Trading_system.ArchivesAssignTask>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Archives", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAssignTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d4ba0b6d9dc912b9c093052bb162d5e275e1d6a4684", async() => {
                WriteLiteral("\r\n    <div class=\"modal-body\">\r\n        <div class=\"form-group row\">\r\n            <div class=\"form-group col-md-12\">\r\n                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 310, "\"", 329, 1);
#nullable restore
#line 8 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
WriteAttributeValue("", 318, ViewBag.id, 318, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"id\" hidden>\r\n                <label class=\"col-form-label col-md-1 col-sm-1\">Mã CV</label>\r\n                <div class=\"col-md-2 col-sm-2\">\r\n                    <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 535, "\"", 564, 1);
#nullable restore
#line 11 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
WriteAttributeValue("", 543, ViewBag.ArchivesCode, 543, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n                </div>\r\n                <label class=\"col-form-label col-md-1 col-sm-1\">Ngày tạo</label>\r\n                <div class=\"col-md-2 col-sm-2\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
                Write(Html.DevExtreme().DateBox().Disabled(true).DisplayFormat("dd/MM/yyyy").Value(@ViewBag.DateCreate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <label class=\"col-form-label col-md-1 col-sm-1\">Tên CV</label>\r\n                <div class=\"col-md-5 col-sm-5\">\r\n                    <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1066, "\"", 1095, 1);
#nullable restore
#line 19 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
WriteAttributeValue("", 1074, ViewBag.ArchivesName, 1074, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                </div>
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""form-group col-md-12"">
                <label class=""col-form-label col-md-1 col-sm-1"">Trích yếu</label>
                <div class=""col-md-11 col-sm-11"">
                    <input type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1447, "\"", 1472, 1);
#nullable restore
#line 27 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
WriteAttributeValue("", 1455, ViewBag.Contents, 1455, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                </div>
            </div>
        </div>
        <div class=""ln_solid""></div>
        <div class=""form-group row"">
            <div class=""form-group col-md-6"">
                <table class=""table"" id=""List_file_attach"">
                    <tr>
                        <th>
                            Tên file
                        </th>
                        <th>
                            Action
                        </th>
                    </tr>
");
#nullable restore
#line 43 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
                      
                        foreach (var item in ViewBag.ListFileAttach)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 48 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
                               Write(item.FileSource);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a href=\'#\'");
                BeginWriteAttribute("onclick", " onclick=\'", 2349, "\'", 2387, 4);
                WriteAttributeValue("", 2359, "DeleteFile(this,", 2359, 16, true);
                WriteAttributeValue(" ", 2375, "\"", 2376, 2, true);
#nullable restore
#line 51 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
WriteAttributeValue("", 2377, item.Id, 2377, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2385, "\")", 2385, 2, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\'glyphicon glyphicon-remove red\' aria-hidden=\"true\"> | </span></a>\r\n                                    <a href=\'#\'");
                BeginWriteAttribute("onclick", " onclick=\'", 2516, "\'", 2564, 3);
                WriteAttributeValue("", 2526, "DownloadFileAttach(\"", 2526, 20, true);
#nullable restore
#line 52 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
WriteAttributeValue("", 2546, item.FileSource, 2546, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2562, "\")", 2562, 2, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\'fa fa-download\' aria-hidden=\"true\"> | </span></a>\r\n                                    <a href=\'#\'");
                BeginWriteAttribute("onclick", " onclick=\'", 2677, "\'", 2721, 3);
                WriteAttributeValue("", 2687, "ViewFileAttach(\"", 2687, 16, true);
#nullable restore
#line 53 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
WriteAttributeValue("", 2703, item.FileSource, 2703, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2719, "\")", 2719, 2, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\'fa fa-eye\' aria-hidden=\"true\"></span></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <div class=\"card-box table-responsive\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Sp_GetDocument_Archive>()
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("Archives")
                                        .LoadAction("GetDocument_HasArchive")
                                        .LoadParams(new { id = ViewBag.id })
                                        .DeleteAction("DeleteDocument_Archive")
                                        .Key("DocId")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.NumberSign).Caption("Số văn bản");

                                        columns.AddFor(m => m.Contents).Caption("Nội dung văn bản");

                                    })
                                    .Editing(e => e.AllowDeleting(true).UseIcons(true))
                                    .HoverStateEnabled(true)
                                    .ShowBorders(true)
                                    .Selection(s => s.Mode(SelectionMode.Single).Deferred(true))
                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                    .HeaderFilter(hearder => hearder.Visible(true))
                                    .AllowColumnResizing(true)
                                    .AllowColumnReordering(true)
                                    .ColumnFixing(c => c.Enabled(true))
                                    .ColumnAutoWidth(true)
                                    .ColumnFixing(c => c.Enabled(true))
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
        </div>
        <div class=""form-group row"">
            <div class=""form-group col-md-6"">
                <label for=""Add_file_attach"" class=""btn btn-secondary btn-sm"">File đính kèm</label>
                <input type=""file"" id=""Add_file_attach"" onchange=""uploadMultipleFile(event)"" name=""files"" style=""display:none"">
            </div>
            <div class=""form-group col-md-6"">
                <button type=""button"" class=""btn btn-secondary btn-sm"" onclick=""choose_Document_NoHasArchive()"">Add văn bản</button>
            </div>
        </div>
        <div class=""modal fade"" id=""Popup_img"" tabindex=""-1"" role=""dialog"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-body"">
                        <img id=""img_id"" style=""width:100%;height:100%"">
                    </div>

                    <div class=""modal-footer"">
                        <button ty");
                WriteLiteral(@"pe=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#Popup_img"" onclick=""Close_Popup_img()"">Close</button>
                    </div>

                </div>
            </div>
        </div>
        <div class=""modal fade"" id=""choose_Document_NoHasArchive"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" style=""display:table"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"" id=""myModalLabel"">Chọn văn bản đính kèm</h4>
                        <button type=""button"" class=""close"" onclick=""Close_choose_Document_NoHasArchive()"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        ");
#nullable restore
#line 131 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
                    Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Sp_GetDocument_Archive>().ID("grid_document_archive")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("Archives")
                                        .LoadAction("GetDocument_NoHasArchive")
                                        .LoadParams(new { id = ViewBag.id })
                                        .Key("DocId")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.NumberSign).Caption("Số văn bản");

                                        columns.AddFor(m => m.Contents).Caption("Nội dung văn bản");

                                    })
                                    .Selection(s => s.Mode(SelectionMode.Multiple).Deferred(true))
                                    .HoverStateEnabled(true)
                                    .ShowBorders(true)
                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                    .HeaderFilter(hearder => hearder.Visible(true))
                                    .AllowColumnResizing(true)
                                    .AllowColumnReordering(true)
                                    .ColumnFixing(c => c.Enabled(true))
                                    .ColumnAutoWidth(true)
                                    .ColumnFixing(c => c.Enabled(true))
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
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-primary"" onclick=""Choose_Document()"">Chọn</button>
                        <button type=""button"" class=""btn btn-default"" data-target=""#choose_Document_NoHasArchive"" onclick=""Close_choose_Document_NoHasArchive()"">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal-footer"">
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 4 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Archives\_PartiView_DocArchive.cshtml"
                                                                           WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"<script type=""text/javascript"">
    function DeleteFile(r, Id) {
        var result = confirm(""Are you sure you want to delete this file ?"");
        if (result) {
            var i = r.parentNode.parentNode.rowIndex;
            document.getElementById('List_file_attach').deleteRow(i);
            try {
                $.post('/Archives/DeleteFileAttach', { 'Id': Id }, function (respone) {

                    $.notify(""delete success"", ""success"");
                });
            } catch {
                $.notify(""something went wrong"", ""error"");
            }
        }
    }
    function uploadMultipleFile(e) {
        var id = document.getElementById(""id"").value;
        var files = e.target.files;
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append(""files"", files[i]);
            formData.append(""id"", id);
            var extensionFile = files[i].name;
            var markup = ""<tr><td><a>"" + extensionFile + ""</a></td");
            WriteLiteral(@"><td><a href='#' onclick='ViewFileAttach(\"""" + extensionFile + ""\"")'><span class='fa fa-eye' aria-hidden='true'></span></a></td></tr>"";
            $(""#List_file_attach tbody"").append(markup);
        }
        axios.post(""/Archives/Add_file_attach"", formData);
    }
    function ViewFileAttach(ex) {
        if (ex.endsWith("".png"") || ex.endsWith("".jpeg"") || ex.endsWith("".jpg"")) {
            document.getElementById(""img_id"").src = '/FileUploads/ArchivesFileAttach/' + ex;
            $('#Popup_img').modal('show');
        }
        else {
            location.href = '/Archives/DownloadDocument/' + ex;
        }
    }
    function DownloadFileAttach(ex) {
        location.href = '/Archives/DownloadDocument/' + ex;
    }
    function choose_Document_NoHasArchive() {
        $('#choose_Document_NoHasArchive').modal('show');
    }
    function Close_choose_Document_NoHasArchive() {
        $(""#choose_Document_NoHasArchive"").modal('hide');
    }
    function Close_Popup_img() {
        $(""#");
            WriteLiteral(@"Popup_img"").modal('hide');
    }
    function getDataGridInstance() {
        return $(""#grid_document_archive"").dxDataGrid(""instance"");
    }
    function Choose_Document() {
        getDataGridInstance().getSelectedRowsData().done(function (rowData) {
            var id = document.getElementById(""id"").value;
            var array = [];
            rowData.forEach(element => { array.push(element.DocId) })
            if (array.length != 0) {
                $.ajax({
                    traditional: true,
                    dataType: 'JSON',
                    url: '/Archives/Add_document_Archive',
                    type: 'POST',
                    data: { array: array, id: id },
                    success: function (data) {
                        $.notify(data, ""success"");
                        $(""#choose_Document_NoHasArchive"").modal('toggle');
                        $(""#myModal"").modal('toggle');
                    },
                    error: function () {
              ");
            WriteLiteral("          $.notify(\"something went wrong\",\"error\")\r\n                    }\r\n\r\n                })\r\n                   \r\n            }\r\n        })\r\n    }\r\n\r\n</script>\r\n    \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Trading_system.ArchivesAssignTask> Html { get; private set; }
    }
}
#pragma warning restore 1591