#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6abab7309ac2cf153d6fb8d260bde670b529a117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hanghoa__PartiView_AddOrEdit_Hanghoa), @"mvc.1.0.view", @"/Views/Hanghoa/_PartiView_AddOrEdit_Hanghoa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abab7309ac2cf153d6fb8d260bde670b529a117", @"/Views/Hanghoa/_PartiView_AddOrEdit_Hanghoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Hanghoa__PartiView_AddOrEdit_Hanghoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Trading_system.Hanghoa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit_HangHoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<style>\r\n    .custom-file-upload {\r\n        border: 1px solid #161515;\r\n        display: inline-block;\r\n        padding: 6px 12px;\r\n        cursor: pointer;\r\n        color: black;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6abab7309ac2cf153d6fb8d260bde670b529a1175244", async() => {
                WriteLiteral("\r\n    <div class=\"modal-body\">\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Nhóm hàng</label>\r\n            <div class=\"col-md-4 col-sm-4\">\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
            Write(Html.DevExtreme().SelectBoxFor(m => m.MaNhom).DataSource(d => d.Mvc().LoadAction("Getnhomhang")
                                                                                           .Controller("Lookup"))
                                                                                            .DisplayExpr("TenNhom")
                                                                                            .ValueExpr("Manhom")
                                                                                            .SearchEnabled(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Mã hàng</label>\r\n            <div class=\"col-md-4 col-sm-4\">\r\n                ");
#nullable restore
#line 26 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().TextBoxFor(m => m.Mahang));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <label class=\"col-form-label col-md-1 col-sm-1\">Tên hàng</label>\r\n            <div class=\"col-md-5 col-sm-5\">\r\n                ");
#nullable restore
#line 30 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().TextBoxFor(m => m.Tenhang));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Tên hàng VAT</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 36 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.Tenhangvat));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Tên hàng theo niên vụ</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 42 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.Fullname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">VAT</label>\r\n            <div class=\"col-md-4 col-sm-4\">\r\n                ");
#nullable restore
#line 48 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().SelectBoxFor(m => m.Vat).DataSource(new JS("VAT")).ValueExpr("id").DisplayExpr("id"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <label class=\"col-form-label col-md-1 col-sm-1\">ĐVT</label>\r\n            <div class=\"col-md-5 col-sm-5\">\r\n                ");
#nullable restore
#line 52 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().SelectBoxFor(m => m.Dvt).DataSource(new[] { "KGS","TAN","CAI"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Giao dịch</label>\r\n            <div class=\"col-md-4 col-sm-4\">\r\n                ");
#nullable restore
#line 58 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().SelectBoxFor(m => m.Sudung).DataSource(new JS("GIAODICH")).ValueExpr("id").DisplayExpr("name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Bao bì</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 64 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().TextAreaFor(m => m.Baobi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Kiểm định</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 70 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().TextAreaFor(m => m.Baobi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Qui cách</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 76 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
           Write(Html.DevExtreme().TextAreaFor(m => m.Baobi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"modal-footer\">\r\n        ");
#nullable restore
#line 81 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
    Write(Html.DevExtreme().Button()
                                        .ID("button")
                                        .Text("Submit")
                                        .Type(ButtonType.Success)
                                        .UseSubmitBehavior(true)
                                    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hanghoa\_PartiView_AddOrEdit_Hanghoa.cshtml"
                                                                              WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
    /* event submit form upload*/
    function uploadMultipleFile(e) {
        var files = e.target.files;
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append(""files"", files[i]);
            var extensionFile = files[i].name;
            var markup = ""<tr><td><a data-toggle='modal' data-target='#exampleModal' data-imageid="" + extensionFile + "">"" + extensionFile + ""</a></td><td><a href='#' onclick='DeleteFile(this,\"""" + extensionFile + ""\"")'><span class='glyphicon glyphicon-remove red'></span></a></td></tr>"";
            $(""#ListofFiles tbody"").append(markup);
        }
        axios.post(""/DocCome/upLoadFiles"", formData);
    }

    $('#exampleModal').on('show.bs.modal', function (event) {
        let bookId = $(event.relatedTarget).data('imageid')
        $(this).find('.modal-body input').val(bookId)
        document.getElementBy");
            WriteLiteral(@"Id('myImg').src = ""/FileUploads/Document/"" + bookId;
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
    function OpenPopupAddDocPlace() {
        $(""#OpenPopupAddDocPlace"").modal(""show"");
    }
    function AddDocPlace() {
        var DocPlaceCode = document.getElementById(""DocPlaceCode"").value;
        var DocPlaceName = document.getElementById(""DocPlaceName"").value;
        var Address = document.getElementById(""Address"").value;
        var Phone = document.getElementById(""Phone"").value;
        var Email = document.getElementById(""Email"").value;
        $.post('/DocCome/AddDocPlace1', { 'DocPlaceCode': DocPlaceCode, 'DocPlaceName': DocPlaceName, 'Address': Address, 'Phone': Ph");
            WriteLiteral("one, \'Email\': Email }, function (respone) {\r\n            $(\"#OpenPopupAddDocPlace\").modal(\"hide\");\r\n            $.notify(respone, \'success\');\r\n        })\r\n    }\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Trading_system.Hanghoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
