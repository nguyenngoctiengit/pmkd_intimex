#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5321774aff343281c31150e5edfeb2f85e32af53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currency__PartiView_AddOrEdit_Currency), @"mvc.1.0.view", @"/Views/Currency/_PartiView_AddOrEdit_Currency.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5321774aff343281c31150e5edfeb2f85e32af53", @"/Views/Currency/_PartiView_AddOrEdit_Currency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Currency__PartiView_AddOrEdit_Currency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Trading_system.Dmtte>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit_Currency", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Currency", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5321774aff343281c31150e5edfeb2f85e32af535007", async() => {
                WriteLiteral("\r\n    <div class=\"modal-body\">\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Currency code</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 7 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml"
            Write(Html.DevExtreme().SelectBoxFor(m => m.MaTte).DataSource(new[] { "USD","EUR","VND","AUD","CAD"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Date of Exchange</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 13 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml"
           Write(Html.DevExtreme().DateBoxFor(m => m.NgayAd));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            \r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Tranfer rate</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml"
           Write(Html.DevExtreme().TextBoxFor(m => m.Tyle));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            \r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Buying rate</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.Tyle1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-form-label col-md-2 col-sm-2\">Selling rate</label>\r\n            <div class=\"col-md-10 col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml"
            Write(Html.DevExtreme().TextBoxFor(m => m.Tyle2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"modal-footer\">\r\n        ");
#nullable restore
#line 39 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml"
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
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Currency\_PartiView_AddOrEdit_Currency.cshtml"
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
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Trading_system.Dmtte> Html { get; private set; }
    }
}
#pragma warning restore 1591
