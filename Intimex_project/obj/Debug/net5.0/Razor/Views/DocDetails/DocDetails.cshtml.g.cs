#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\DocDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed196e915dd7ec74fd9b5e0aa977f66a6d88adcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocDetails_DocDetails), @"mvc.1.0.view", @"/Views/DocDetails/DocDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed196e915dd7ec74fd9b5e0aa977f66a6d88adcd", @"/Views/DocDetails/DocDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_DocDetails_DocDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/js_create/doccome.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\DocDetails.cshtml"
  
    ViewData["Title"] = "DocDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 164, "\"", 172, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Theo dõi văn bản</h3>
            </div>
            <div class=""title_right"">
                <div class=""col-md-5 col-sm-5 form-group pull-right top_search"">
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
#line 24 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\DocDetails.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\DocDetails.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\DocDetails.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Hồ sơ - công việc</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                            <li>
                                <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                            </li>
                            <li class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item"" href=""#"">Settings 1</a>
                                    <a class=""dropdown-item"" href=""#"">Settings 2</a>
                                </div>");
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
                            <div class=""col-sm-9"">
                                <div class=""card-box table-responsive"">
                                    ");
#nullable restore
#line 59 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\DocDetails.cshtml"
                                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Sp_GetDocDetails>().ID("Sp_GetDocDetails")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("DocDetails")
                                        .LoadAction("Get")
                                        .Key("DocId")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(a => a.StyleCode).Caption("Loại VB");

                                        columns.AddFor(a => a.TypeCode).Caption("Hình thức");

                                        columns.AddFor(a => a.DocDate).Caption("Ngày VB");

                                        columns.AddFor(a => a.NumberSign).Caption("Số / Ký hiệu");

                                        columns.AddFor(a => a.Contents).Caption("Tên loại và trích yếu nội dung VB");

                                        columns.AddFor(a => a.NumDocProcess).Caption("Người nhận");

                                        columns.AddFor(a => a.NumDocProcessIsView).Caption("Đã xem");

                                    })
                                    .OnToolbarPreparing("toolbar_Archives")
                                    .OnSelectionChanged("DisplayNameReceive")
                                    .HoverStateEnabled(true)
                                    .ShowBorders(true)
                                    .Selection(s => s.Mode(SelectionMode.Single))
                                    .Export(e => e.Enabled(true))
                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                    .HeaderFilter(hearder => hearder.Visible(true))
                                    .AllowColumnResizing(true)
                                    .AllowColumnReordering(true)
                                    .ColumnChooser(c => c.Enabled(true))
                                    .ColumnFixing(c => c.Enabled(true))
                                    .ColumnAutoWidth(true)
                                    .ShowBorders(true)
                                    .Grouping(group => group.AutoExpandAll(true))
                                    .SearchPanel(searchPanel => searchPanel.Visible(true))
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

                                <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-xl modal-dialog-scrollable"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                            </div>
                                            <div id=""_PartiView_AddOrUpdate_Archive"">

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                    ");
            WriteLiteral(@"            Danh sách người nhận
                                <div id=""ListUserReceive"" style=""border-style:double;height:90%"">
                                </div>
                                <input type=""text"" id=""DocId"" hidden>
                            </div>
                            <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-xl modal-dialog-scrollable"" role=""document"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <button type=""button"" class=""close"" onclick=""Close_myModal()"">&times;</button>
                                        </div>
                                        <div id=""_PartiView_AddOrUpdate_Archive"">

                                        </div>
                                    </div>
        ");
            WriteLiteral(@"                        </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed196e915dd7ec74fd9b5e0aa977f66a6d88adcd13349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n");
            WriteLiteral(@"    function SelectedImageDisplay(data) {
        var fileName = data.selectedItem;
        if (fileName.endsWith("".pdf"") == true) {
            window.open(""/FileUploads/Document/"" + fileName);
        } else if (fileName.endsWith("".png"") == true || fileName.endsWith("".jpg"") == true || fileName.endsWith("".jpeg"") == true || fileName.endsWith("".JPEG"") || fileName.endsWith("".JPG"") || fileName.endsWith("".PNG"")) {
            document.getElementById('img_id').src = '/FileUploads/Document/' + data.selectedItem;
            document.getElementById(""text_Popup_img"").style.display = ""none"";
            $(""#Popup_img"").modal(""show"");
        } else {
            location.href = '/DocCome/DownloadDocument/' + fileName;
            $(""#Popup_img"").modal(""show"");
        }
    }
    function DisplayNameReceive(selectedItems) {
        var data = selectedItems.selectedRowsData[0];
        if (data) {
            $.post('/DocDetails/DisplayNameReceive', { 'DocId': data.DocId, 'IsFeedBack': data.IsFeedBack }");
            WriteLiteral(@", function (array) {
                var parse = """";
                for (var i = 0; i < array.length; i++) {
                    parse += array[i].DepartmentCode + "" - "" + array[i].FullName1 + ""<br>"";
                }
                document.getElementById(""ListUserReceive"").innerHTML = parse;
            })
            document.getElementById(""DocId"").value = data.DocId;
        }
    }
    
    function toolbar_Archives(e) {
        e.toolbarOptions.items.unshift({
            location: ""after"",
            widget: ""dxButton"",
            options: {
                text: ""Xem VB"",
                onClick: function () {
                    var DocId = document.getElementById(""DocId"").value;
                    console.log(DocId);
                    if (DocId == """") {
                        $.notify(""Vui lòng chọn văn bản cần xem"", ""error"");
                    } else {
                        $.post('/DocDetails/ViewImage', { 'DocId': DocId }, function (respone) {
               ");
            WriteLiteral(@"             if (respone == ""false"") {
                                $.notify(""Bạn không có quyền xem văn bản này"", ""error"");
                            }
                            else {
                                $(""#_PartiView_AddOrUpdate_Archive"").html(respone);
                                $(""#myModal"").modal(""show"");
                            }
                        })
                    }
                }
            }
        });
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
