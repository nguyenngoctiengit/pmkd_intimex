#pragma checksum "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef6f27b5caf80c517d6aa1075c32b859211709ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocProcess__PartiView_DocFeedBack), @"mvc.1.0.view", @"/Views/DocProcess/_PartiView_DocFeedBack.cshtml")]
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
#line 1 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\_ViewImports.cshtml"
using Intimex_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\_ViewImports.cshtml"
using Intimex_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6f27b5caf80c517d6aa1075c32b859211709ab", @"/Views/DocProcess/_PartiView_DocFeedBack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_DocProcess__PartiView_DocFeedBack : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-body"">
    <div class=""form-group row"">
        <div class=""form-group col-md-12"">
            <label class=""col-form-label col-md-1 col-sm-1"">Nội dung</label>
            <div class=""col-md-11 col-sm-11"">
                <textarea class=""form-control"" id=""Idea"" style=""height:100px"">");
#nullable restore
#line 6 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
                                                                         Write(ViewBag.Contents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <input type=\"text\" id=\"DocProcessId\"");
            BeginWriteAttribute("value", " value=\"", 425, "\"", 454, 1);
#nullable restore
#line 10 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
WriteAttributeValue("", 433, ViewBag.DocProcessId, 433, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden>
    <input type=""text"" id=""FeedbackId"" hidden>
    <div class=""form-group row"" style=""margin-bottom:0px"">
        <div class=""form-group col-md-12"" style=""margin-bottom:0px"">
            <div class=""form-group col-md-6"">
                <button type=""button"" class=""btn btn-secondary btn-sm"" onclick=""OpenPopUp_Reciever()"">Người nhận</button>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""Add_file_attach"" class=""btn btn-secondary btn-sm"">File đính kèm</label>
                <input type=""file"" id=""Add_file_attach"" onchange=""uploadMultipleFile(event)"" name=""files"" style=""display:none"">
            </div>
        </div>
    </div>
    <div class=""form-group row"">
        <div class=""form-group col-md-6"">
            <table class=""table"" id=""ListReciever"">
                <tr>
                    <th>
                        Người nhận
                    </th>
                    <th>
                        Action
                    </");
            WriteLiteral(@"th>
                </tr>
            </table>
        </div>
        <div class=""form-group col-md-6"">
            <table class=""table"" id=""ListFileAttach"">
                <thead>
                    <tr>
                        <th>
                            Tệp
                        </th>
                        <th>
                            Action
                        </th>
                    </tr>

                </thead>
                <tbody>
");
#nullable restore
#line 50 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
                      
                        foreach (var item in ViewBag.ListFileAttach)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <a data-toggle=\"modal\" data-target=\"#exampleModal\" data-imageid=\"");
#nullable restore
#line 55 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
                                                                                                Write(item.FileSource);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        ");
#nullable restore
#line 56 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
                                   Write(item.FileSource);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </td>\r\n                                <td>\r\n                                    <a href=\'#\'");
            BeginWriteAttribute("onclick", " onclick=\'", 2503, "\'", 2548, 3);
            WriteAttributeValue("", 2513, "DeleteFile(this,\"", 2513, 17, true);
#nullable restore
#line 60 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
WriteAttributeValue("", 2530, item.FileSource, 2530, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2546, "\")", 2546, 2, true);
            EndWriteAttribute();
            WriteLiteral("><span class=\'glyphicon glyphicon-remove red\'></span></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
    <div class=""modal fade"" id=""Popup_choose_receiver"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" style=""display:table"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""myModalLabel"">Chọn nhân viên</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group row"">
                        <div class=""form-group col-md-12"">
                            ");
#nullable restore
#line 79 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
                        Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.UserRight>()
                                                    .ID("grib_dsnv")
                                                    .DataSource(d => d.Mvc().LoadAction("GetUserRight")
                                                                            .Controller("DocCome")
                                                                            .Key("UserName1"))
                                                    .RemoteOperations(true)
                                                    .Columns(colunms => {

                                                        colunms.AddFor(m => m.FullName1).Caption("Tên nhân viên").Fixed(true);

                                                        colunms.Add().DataField("BranchId").Caption("Bộ phận");

                                                        colunms.Add().DataField("NameV").Caption("Chi nhánh");

                                                        colunms.AddFor(m => m.UserName1).Caption("Mã nhân viên").Fixed(true).Visible(false);

                                                    })
                                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                                    .Selection(s => s.Mode(SelectionMode.Multiple).Deferred(true))
                                                    .HoverStateEnabled(true)
                                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                                    .HeaderFilter(header => header.Visible(true))
                                                    .AllowColumnReordering(true)
                                                    .AllowColumnResizing(true)
                                                    .ColumnAutoWidth(true)
                                                    .ColumnChooser(c => c.Enabled(true))
                                                    .ColumnFixing(c => c.Enabled(true))
                                                    .ShowBorders(true)
                                                    .Grouping(group => group.AutoExpandAll(true))
                                                    .GroupPanel(groupPanel => groupPanel.Visible(true))
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
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" onclick=""ChooseReceiver()"">Chọn</button>
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>
    <div class=""form-group row"">
        ");
#nullable restore
#line 128 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\DocProcess\_PartiView_DocFeedBack.cshtml"
    Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Sp_GetDocFeedback>()
                                                    .ID("grib_DocFeedBack")
                                                    .DataSource(d => d.Mvc().LoadAction("GetDocFeedBack")
                                                                            .DeleteAction("DeleteDocFeedBack")
                                                                            .Controller("DocProcess")
                                                                            .Key("DocFeedBackId")
                                                                            .LoadParams(new { DocProcessId = ViewBag.DocProcessId }))
                                                    .RemoteOperations(true)
                                                    .Columns(colunms => {

                                                        colunms.AddFor(m => m.Idea).Caption("Nội dung");

                                                        colunms.AddFor(m => m.DateCreate).Caption("Ngày gửi").Format("dd/MM/yyyy");

                                                        colunms.AddFor(m => m.UserReceive).Caption("Người nhận");

                                                        colunms.AddFor(m => m.StatusFeedBack).Caption("Đã xem");

                                                    })
                                                    .OnSelectionChanged("ChooseFeedbackParentId")
                                                    .Editing(editing => editing.AllowDeleting(true).UseIcons(true))
                                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                                    .Selection(s => s.Mode(SelectionMode.Single))
                                                    .HoverStateEnabled(true)
                                                    .HeaderFilter(header => header.Visible(true))
                                                    .AllowColumnReordering(true)
                                                    .AllowColumnResizing(true)
                                                    .ColumnFixing(c => c.Enabled(true))
                                                    .ShowBorders(true)
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
    <button type=""button"" class=""btn btn-primary"" onclick=""SaveDocFeedBack()"">Gửi</button>
    <button type=""button"" class=""btn btn-link"" onclick=""Close_myModal()"">Thoát</button>
</div>
<script type=""text/javascript"">
    function uploadMultipleFile(e) {
        var FeedbackId = document.getElementById(""FeedbackId"").value;
        var files = e.target.files;
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append(""files"", files[i]);
            formData.append(""FeedbackId"", FeedbackId);
            var extensionFile = files[i].name;
            var markup = ""<tr><td><a>"" + extensionFile + ""</a></td><td><a href='#' onclick='ViewFileAttach(\"""" + extensionFile + ""\"")'><span class='fa fa-eye' aria-hidden='true'></span></a></td></tr>"";
            $(""#ListFileAttach tbody"").append(markup);
        }
        axios.post(""/DocProcess/Add_file_attach"", formData);
    }
    function OpenPopUp_R");
            WriteLiteral(@"eciever() {
        $('#Popup_choose_receiver').modal('show');
    }
    function getDataGridInstance() {
        return $(""#grib_dsnv"").dxDataGrid(""instance"");
    }
    function ChooseReceiver() {
        getDataGridInstance().getSelectedRowsData().done(function (rowData) {
            var array = []
            rowData.forEach(element => { array.push(element) })
            for (var i = 0; i < array.length; i++) {
                var markup = ""<tr><td style='display: none'>"" + array[i].UserName1 + ""</td><td>"" + array[i].FullName1 + "" - "" + array[i].BranchId + ""</td><td><a href='#' onclick='DeleteReceiver(this,\"""" + array[i].UserName1 + ""\"")'><span class='glyphicon glyphicon-remove red'></span></a></td></tr>"";
                $(""#ListReciever tbody"").append(markup);
            }
            $('#Popup_choose_receiver').modal('toggle');
        })
    }
    function SaveDocFeedBack() {
        var array_ListReciever = [];
        var ListReciever = [];
        var DocProcessId = document.");
            WriteLiteral(@"getElementById(""DocProcessId"").value;
        var Idea = document.getElementById(""Idea"").value;
        var FeedbackId = document.getElementById(""FeedbackId"").value;
        $(""#ListReciever tr:not(:first)"").each(function () {
            array_ListReciever.push($(this).find(""td:first"").text()); //put elements into array
            array_ListReciever.forEach(element => { ListReciever.push(element.UserName1) })
        });
        if (array_ListReciever.length != 0) {
            $.ajax({
                traditional: true,
                dataType: 'json',
                type: 'POST',
                url: '/DocProcess/SaveDocFeedBack',
                data: { array_ListReciever: array_ListReciever, DocProcessId: DocProcessId, Idea: Idea, FeedbackId: FeedbackId },
                success: function (data) {
                    $(""#myModal"").modal(""toggle"");
                    $.notify(data, ""success"");
                },
                error: function () {
                    $.notify(""Som");
            WriteLiteral(@"ething went wrong"", ""error"");
                }
            })
        }
        else if (array_ListReciever.length == 0) {
            $.notify(""please choose reciever!"", ""error"");
        }
    }
    function Close_myModal() {
        $(""#myModal"").modal(""hide"");
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
