#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3434ef26f9abb2d612e12f151a600979e3369ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocGo__PartiView_AddDocGo), @"mvc.1.0.view", @"/Views/DocGo/_PartiView_AddDocGo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3434ef26f9abb2d612e12f151a600979e3369ba0", @"/Views/DocGo/_PartiView_AddDocGo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_DocGo__PartiView_AddDocGo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Trading_system.Document>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add_docgo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DocGo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .custom-file-upload {\r\n        border: 1px solid #161515;\r\n        display: inline-block;\r\n        padding: 6px 12px;\r\n        cursor: pointer;\r\n        color: black;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3434ef26f9abb2d612e12f151a600979e3369ba06020", async() => {
                WriteLiteral(@"
    <div class=""modal-body"">
        <div class=""form-group row"">
            <div class=""form-group col-md-4"">
                <label class=""col-form-label col-md-4 col-sm-4"">Độ khẩn</label>
            </div>
            <div class=""form-group col-md-4"">
                <label class=""col-form-label col-md-4 col-sm-4"">Loại văn bản</label>
            </div>
            <label class=""col-form-label col-md-1 col-sm-1"">Số/Ký hiệu</label>
            <div class=""col-md-3 col-sm-3"">
                ");
#nullable restore
#line 22 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.NumberSign));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <div class=\"form-group col-md-4\">\r\n                <div class=\"form-check form-check-inline\">\r\n                    <input class=\"form-check-input\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 1147, "\"", 1184, 1);
#nullable restore
#line 28 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
WriteAttributeValue("", 1154, Html.NameFor(m => m.DocLever), 1154, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""0"" checked>
                    <label class=""form-check-label"" for=""inlineRadio1"">Văn bản thường</label>
                </div>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("name", " name=\"", 1449, "\"", 1486, 1);
#nullable restore
#line 32 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
WriteAttributeValue("", 1456, Html.NameFor(m => m.DocLever), 1456, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""1"">
                    <label class=""form-check-label"" for=""inlineRadio2"">Văn bản khẩn</label>
                </div>
            </div>
            <div class=""form-group col-md-4"">
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("name", " name=\"", 1808, "\"", 1847, 1);
#nullable restore
#line 38 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
WriteAttributeValue("", 1815, Html.NameFor(m => m.DocStyleId), 1815, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""2"" id=""DocPlace2"" checked onclick=""openDocPlace()"">
                    <label class=""form-check-label"" for=""inlineRadio1"">Gửi nội bộ</label>
                </div>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("name", " name=\"", 2148, "\"", 2187, 1);
#nullable restore
#line 42 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
WriteAttributeValue("", 2155, Html.NameFor(m => m.DocStyleId), 2155, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""1"" id=""DocPlace1"" onclick=""openDocPlace()"">
                    <label class=""form-check-label"" for=""inlineRadio2"">Gửi ra ngoài</label>
                </div>
            </div>
            <label class=""col-form-label col-md-1 col-sm-1"">Ngày phát hành</label>
            <div class=""col-md-3 col-sm-3"">
                ");
#nullable restore
#line 48 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
            Write(Html.DevExtreme().DateBoxFor(m => m.DocDate));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""form-group col-md-12"">
                <label class=""col-form-label col-md-1 col-sm-1"">Hình thức</label>
                <div class=""col-md-3 col-sm-3"">
                    ");
#nullable restore
#line 55 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
                Write(Html.DevExtreme().SelectBoxFor(m => m.DocTypeId).DataSource(d => d
                                                                                                .Mvc()
                                                                                                .Controller("lookup")
                                                                                                .LoadAction("getDoctype")
                                                                                                .LoadMode(DataSourceLoadMode.Raw)
                                                                                                .Key("DocTypeId"))
                                                                                            .DisplayExpr("TypeName")
                                                                                            .ValueExpr("DocTypeId")
                                                                                            .SearchEnabled(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <label class=\"col-form-label col-md-1 col-sm-1\">Số tờ</label>\r\n                <div class=\"col-md-1 col-sm-1\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
               Write(Html.DevExtreme().TextBoxFor(m => m.NumberOfPage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <label class=\"col-form-label col-md-1 col-sm-1\">Người kí</label>\r\n                <div class=\"col-md-5 col-sm-5\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
                Write(Html.DevExtreme().SelectBoxFor(m => m.Singer).DataSource(d => d
                                                                                                .Mvc()
                                                                                                .Controller("lookup")
                                                                                                .LoadAction("getSigner")
                                                                                                .LoadMode(DataSourceLoadMode.Raw)
                                                                                                .Key("UserName1"))
                                                                                            .DisplayExpr("FullName1")
                                                                                            .ValueExpr("FullName1")
                                                                                            .SearchEnabled(true));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""form-group row"" id=""DocPlace"" style=""display:none"">
            <div class=""form-group col-md-12"">
                <label class=""col-form-label col-md-1 col-sm-1"">Nơi gửi</label>
                <div class=""col-md-11 col-sm-11"">
                    ");
#nullable restore
#line 87 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
                Write(Html.DevExtreme().SelectBoxFor(m => m.DocPlaceId).DataSource(d => d
                                                                                                .Mvc()
                                                                                                .LoadAction("getDocplace")
                                                                                                .Controller("lookup")
                                                                                                .LoadMode(DataSourceLoadMode.Raw)
                                                                                                .Key("DocPlaceId"))
                                                                                            .DisplayExpr("DocPlaceName")
                                                                                            .ValueExpr("DocPlaceId")
                                                                                            .SearchEnabled(true));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""form-group col-md-12"">
                <div class=""col-md-1 col-sm-1"">
                    <label class=""custom-file-upload"">
                        <input type=""file"" id=""fileUpload"" onchange=""uploadMultipleFile(event)"" name=""files"" multiple hidden />
                        <i class=""fa fa-cloud-upload""></i>
                    </label>
                </div>
                <div class=""col-md-1 col-sm-1"">
");
                WriteLiteral(@"                </div>
                <div class=""col-md-10 col-sm-10"">
                    <table class=""table"" id=""ListofFiles"">
                        <tr>
                            <th>
                                Files
                            </th>
                            <th>
                                Action
                            </th>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <div class=""form-group row"" style=""margin-bottom:0px"">
            <div class=""form-group col-md-12"">
                <label class=""col-form-label col-md-12 col-sm-12"">Tên và loại trích yếu văn bản</label>
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""col-md-12 col-sm-12"">
                ");
#nullable restore
#line 131 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
            Write(Html.DevExtreme().TextAreaFor(m => m.Contents));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group row"" style=""margin-bottom:0px"">
            <div class=""form-group col-md-12"">
                <label class=""col-form-label col-md-12 col-sm-12"">Ghi chú</label>
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""col-md-12 col-sm-12"">
                ");
#nullable restore
#line 141 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_AddDocGo.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.Note));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"modal-footer\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3434ef26f9abb2d612e12f151a600979e3369ba018072", async() => {
                    WriteLiteral("Save");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
<script type=""text/javascript"">

    function openDocPlace() {
        if (document.getElementById('DocPlace1').checked) {
            document.getElementById('DocPlace').style.display = 'block';
        } else {
            document.getElementById('DocPlace').style.display = 'none';
        }
    }
    /* event submit form upload*/
    function uploadMultipleFile(e) {

        var files = e.target.files;
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append(""files"", files[i]);
            var extensionFile = files[i].name;
            var markup = ""<tr><td><a data-toggle='modal' data-target='#exampleModal' data-imageid="" + extensionFile + "">"" + extensionFile + ""</a></td><td><a href='#' onclick='DeleteFile(this,\"""" + extensionFile + ""\"")'><span class='glyphicon glyphicon-remove red'></span></a></td></tr>"";
            $(""#ListofFiles tbody"").append(markup);
    ");
            WriteLiteral(@"    }
        axios.post(""/DocGo/upLoadFiles"", formData);
    }

    $('#exampleModal').on('show.bs.modal', function (event) {
        let bookId = $(event.relatedTarget).data('imageid');
        $(this).find('.modal-body input').val(bookId);
        document.getElementById('myImg').src = ""/FileUploads/Document/"" + bookId;
    })

    function DeleteFile(r, extensionFile) {
        var i = r.parentNode.parentNode.rowIndex;
        document.getElementById('ListofFiles').deleteRow(i);
        try {
            $.post(""/DocCome/DeleteFile"", $.param({ extensionFile: extensionFile }, true));
        }
        catch {
            $.notify(""something wrong"", ""error"");
        }
    }
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Trading_system.Document> Html { get; private set; }
    }
}
#pragma warning restore 1591
