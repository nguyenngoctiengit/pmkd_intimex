#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "400d13e65a00a95516333dba938de19ea4195354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocGo__PartiView_EditDocGo), @"mvc.1.0.view", @"/Views/DocGo/_PartiView_EditDocGo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"400d13e65a00a95516333dba938de19ea4195354", @"/Views/DocGo/_PartiView_EditDocGo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_DocGo__PartiView_EditDocGo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Trading_system.Document>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit_DocGo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DocGo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "400d13e65a00a95516333dba938de19ea41953545186", async() => {
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
#line 22 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.NumberSign));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <div class=\"form-group col-md-4\">\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                  
                    if (Model.DocLever == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-check form-check-inline\">\r\n                            <input class=\"form-check-input\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 1283, "\"", 1320, 1);
#nullable restore
#line 31 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 1290, Html.NameFor(m => m.DocLever), 1290, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""0"" checked>
                            <label class=""form-check-label"" for=""inlineRadio1"">Văn bản thường</label>
                        </div>
                        <div class=""form-check form-check-inline"">
                            <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("name", " name=\"", 1617, "\"", 1654, 1);
#nullable restore
#line 35 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 1624, Html.NameFor(m => m.DocLever), 1624, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\">\r\n                            <label class=\"form-check-label\" for=\"inlineRadio2\">Văn bản khẩn</label>\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-check form-check-inline\">\r\n                            <input class=\"form-check-input\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 2013, "\"", 2050, 1);
#nullable restore
#line 42 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 2020, Html.NameFor(m => m.DocLever), 2020, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""0"">
                            <label class=""form-check-label"" for=""inlineRadio1"">Văn bản thường</label>
                        </div>
                        <div class=""form-check form-check-inline"">
                            <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("name", " name=\"", 2339, "\"", 2376, 1);
#nullable restore
#line 46 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 2346, Html.NameFor(m => m.DocLever), 2346, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" checked>\r\n                            <label class=\"form-check-label\" for=\"inlineRadio2\">Văn bản khẩn</label>\r\n                        </div>\r\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-4\">\r\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                  
                    if (Model.DocStyleId == 2)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-check form-check-inline\">\r\n                            <input class=\"form-check-input\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 2873, "\"", 2912, 1);
#nullable restore
#line 58 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 2880, Html.NameFor(m => m.DocStyleId), 2880, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""2"" id=""DocPlace2"" checked onclick=""openDocPlace()"">
                            <label class=""form-check-label"" for=""inlineRadio1"">Gửi nội bộ</label>
                        </div>
                        <div class=""form-check form-check-inline"">
                            <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("name", " name=\"", 3245, "\"", 3284, 1);
#nullable restore
#line 62 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 3252, Html.NameFor(m => m.DocStyleId), 3252, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" id=\"DocPlace1\" onclick=\"openDocPlace()\">\r\n                            <label class=\"form-check-label\" for=\"inlineRadio2\">Gửi ra ngoài</label>\r\n                        </div>\r\n");
#nullable restore
#line 65 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                    }
                    else if (Model.DocStyleId == 1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-check form-check-inline\">\r\n                            <input class=\"form-check-input\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 3710, "\"", 3749, 1);
#nullable restore
#line 69 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 3717, Html.NameFor(m => m.DocStyleId), 3717, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""2"" id=""DocPlace2"" onclick=""openDocPlace()"">
                            <label class=""form-check-label"" for=""inlineRadio1"">Gửi nội bộ</label>
                        </div>
                        <div class=""form-check form-check-inline"">
                            <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("name", " name=\"", 4074, "\"", 4113, 1);
#nullable restore
#line 73 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 4081, Html.NameFor(m => m.DocStyleId), 4081, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" id=\"DocPlace1\" checked onclick=\"openDocPlace()\">\r\n                            <label class=\"form-check-label\" for=\"inlineRadio2\">Gửi ra ngoài</label>\r\n                        </div>\r\n");
#nullable restore
#line 76 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <label class=\"col-form-label col-md-1 col-sm-1\">Ngày phát hành</label>\r\n            <div class=\"col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 82 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
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
#line 89 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
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
#line 101 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
               Write(Html.DevExtreme().TextBoxFor(m => m.NumberOfPage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <label class=\"col-form-label col-md-1 col-sm-1\">Người kí</label>\r\n                <div class=\"col-md-5 col-sm-5\">\r\n                    ");
#nullable restore
#line 105 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
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
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n");
#nullable restore
#line 118 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
              
                if (Model.DocStyleId == 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-group col-md-12"" id=""DocPlace"" style=""display:block"">
                        <label class=""col-form-label col-md-1 col-sm-1"">Nơi gửi</label>
                        <div class=""col-md-11 col-sm-11"">
                            ");
#nullable restore
#line 124 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
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
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 135 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-group col-md-12"" id=""DocPlace"" style=""display:none"">
                        <label class=""col-form-label col-md-1 col-sm-1"">Nơi gửi</label>
                        <div class=""col-md-11 col-sm-11"">
                            ");
#nullable restore
#line 141 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
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
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 152 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
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
");
#nullable restore
#line 177 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                          
                            foreach (var item in ViewBag.listImage)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <a data-toggle=\"modal\" data-target=\"#exampleModal\" data-imageid=\"");
#nullable restore
#line 182 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                                                                                                    Write(item.FileAttach);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                            ");
#nullable restore
#line 183 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                                       Write(item.FileAttach);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </a>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a href=\'#\'");
                BeginWriteAttribute("onclick", " onclick=\'", 11794, "\'", 11839, 3);
                WriteAttributeValue("", 11804, "DeleteFile(this,\"", 11804, 17, true);
#nullable restore
#line 187 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
WriteAttributeValue("", 11821, item.FileAttach, 11821, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11837, "\")", 11837, 2, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\'glyphicon glyphicon-remove red\'></span></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 190 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </table>
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
#line 203 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
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
#line 213 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.Note));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-body"">
                        <img id=""myImg"" style=""width:100%;height:100%"">
                        <input type=""hidden"" name=""bookId"" id=""bookId""");
                BeginWriteAttribute("value", " value=\"", 13354, "\"", 13362, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <input type=""text"" class=""form-control"" id=""recipient-name"">
                    </div>

                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" onclick=""Close_modalImage()"">Close</button>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""submit"" class=""btn btn-primary"">Submit</button>
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
#line 11 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocGo\_PartiView_EditDocGo.cshtml"
                                                                     WriteLiteral(ViewBag.DocId);

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
    function Close_modalImage() {
        $(""#exampleModal"").modal(""hide"");
    }
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
            var markup = ""<tr><td><a data-toggle='modal' data-target='#exampleModal' data-imageid="" + extensionFile + "">"" + extensionFile + ""</a></td><td><a href='#' onclick='DeleteFile(this,\"""" + extensionFile + ""\"")'><span class='glyphicon glyphicon-remove re");
            WriteLiteral(@"d'></span></a></td></tr>"";
            $(""#ListofFiles tbody"").append(markup);
        }
        axios.post(""/DocGo/upLoadFiles"", formData);
    }

    $('#exampleModal').on('show.bs.modal', function (event) {
        let bookId = $(event.relatedTarget).data('imageid');
        $(this).find('.modal-body input').val(bookId);
        document.getElementById('myImg').src = ""/FileUploads/Document/"" + bookId;
    })

    function DeleteFile(r, extensionFile) {
        var result = confirm(""Are you sure you want to delete this file ?"");
        if (result) {
            var i = r.parentNode.parentNode.rowIndex;
            document.getElementById('ListofFiles').deleteRow(i);
            $.post(""/DocGo/DeleteFileEdit"", $.param({ extensionFile: extensionFile }, true));
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