#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8955f1a412c782e8b47fa968a3a9ca070caf3a92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocCome_DocCome), @"mvc.1.0.view", @"/Views/DocCome/DocCome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8955f1a412c782e8b47fa968a3a9ca070caf3a92", @"/Views/DocCome/DocCome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_DocCome_DocCome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Models.Trading_system.Document>>
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
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
  
    ViewData["Title"] = "DocCome";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 218, "\"", 226, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Thông tin văn bản đến</h3>
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
#line 25 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Văn bản đến</h2>
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
            WriteLiteral(@"                        </li>
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
#line 68 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
                                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Document>().ID("gridContainer")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("doccome")
                                        .LoadAction("Get")
                                        .InsertAction("Post")
                                        .UpdateAction("Put")
                                        .DeleteAction("Delete")
                                        .Key("DocId")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.DocDate).Caption("Ngày VB");

                                        columns.AddFor(m => m.DateCome).Caption("Ngày nhận");

                                        columns.AddFor(m => m.NumberCome).Caption("Số văn bản đến");

                                        columns.AddFor(m => m.Contents).Caption("Tên loại và trích yếu nội dung văn bản");

                                        columns.AddFor(m => m.DocTypeId).Caption("Hình thức").Lookup(lookup => lookup
                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getDoctype").Key("DocTypeId"))
                                        .DisplayExpr("TypeName")
                                        .ValueExpr("DocTypeId")
                                        );

                                        columns.AddFor(m => m.NumberSign).Caption("Số / Ký hiệu");

                                        columns.AddFor(m => m.DocPlaceId).Caption("Nơi gửi").Lookup(lookup => lookup
                                        .DataSource(d => d.Mvc().Controller("lookup").LoadAction("getDocplace").Key("DocPlaceId"))
                                        .DisplayExpr("DocPlaceName")
                                        .ValueExpr("DocPlaceId")
                                        );


                                        columns.AddFor(m => m.DocLever).Caption("Độ khẩn").Lookup(lookup => lookup.DataSource(new JS("DocLever")).ValueExpr("id").DisplayExpr("name"));

                                        columns.Add().DataField("IsChuyen").Caption("Đã chuyển");

                                        columns.Add().DataField("Image").Caption("Image");
                                    })
                                    .Editing(e => e
                                        .Mode(GridEditMode.Popup)
                                        .Popup(p => p.Title("Hàng hóa").ShowTitle(true).Width(700).Height(500))
                                        .AllowDeleting(true)
                                        .UseIcons(true)
                                    )
                                    .MasterDetail(md => {
                                        md.Enabled(true);
                                        md.Template(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                                            <img src=\"<%- data.Image %>\">\r\n\r\n                                        ");
    PopWriter();
}
));

                                    })
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
#nullable restore
#line 144 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("templete_Doccome"))
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div>Nguyễn Ngọc Tiến</div>\r\n");
#nullable restore
#line 148 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocCome\DocCome.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8955f1a412c782e8b47fa968a3a9ca070caf3a9214473", async() => {
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
            WriteLiteral("\r\n<script>\r\n</script>\r\n<!-- /page content -->\r\n<!-- /page content -->\r\n<!-- footer content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Models.Trading_system.Document>> Html { get; private set; }
    }
}
#pragma warning restore 1591
