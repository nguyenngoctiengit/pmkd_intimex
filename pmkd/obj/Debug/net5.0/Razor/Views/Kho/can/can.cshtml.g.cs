#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b13de85b0142e3db971f5368ab265d944860f6c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kho_can_can), @"mvc.1.0.view", @"/Views/Kho/can/can.cshtml")]
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
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\_ViewImports.cshtml"
using pmkd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b13de85b0142e3db971f5368ab265d944860f6c8", @"/Views/Kho/can/can.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f3fdee9548d5779914426f2f6cb4c3005f9059", @"/Views/_ViewImports.cshtml")]
    public class Views_Kho_can_can : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label-left input_mask"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 191, "\"", 199, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Thông tin hàng hóa</h3>
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
#line 26 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 32 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml"
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml"
          
            if (TempData["alertMessage1"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml"
               Write(TempData["alertMessage1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\can\can.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix""></div>
        <div class=""row"" style=""display: block;"">
            <div class=""col-md-12 col-sm-12 "">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Hàng hóa</h2>
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
            WriteLiteral(@"                     </li>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b13de85b0142e3db971f5368ab265d944860f6c88804", async() => {
                WriteLiteral(@"
                                        <div class=""form-group row"">
                                            <label class=""col-form-label col-md-2 col-sm-2"">TL hiện tại trên cân</label>
                                            <label class=""col-form-label col-md-2 col-sm-2"">TL xe và Hàng NK</label>
                                            <label class=""col-form-label col-md-2 col-sm-2""></label>
                                            <label class=""col-form-label col-md-2 col-sm-2""></label>
                                            <label class=""col-form-label col-md-2 col-sm-2"">TL xe</label>
                                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng hàng</label>
                                        </div>
                                        <div class=""form-group row"">
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" ");
                WriteLiteral(@"style=""height:60px"">
                                            </div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:60px"">
                                            </div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:60px"">
                                            </div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:60px"">
                                            </div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:60px"">
                                            </");
                WriteLiteral(@"div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:60px"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:30px"">
                                            </div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:30px"">
                                            </div>
                                            <div class=""col-md-2 col-sm-2"" style=""display: flex; flex-direction: row; justify-content: center; align-items: center"">
                 ");
                WriteLiteral(@"                               <input type=""text"" class=""form-control"" style=""height:30px"">
                                                <button style=""height:30px"">S2</button>
                                            </div>
                                            <div class=""col-md-2 col-sm-2"" style=""display: flex; flex-direction: row; justify-content: center; align-items: center"">
                                                <input type=""text"" class=""form-control"" style=""height:30px"">
                                                <button style=""height:30px"">S2</button>
                                            </div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input type=""text"" class=""form-control"" style=""height:30px"">
                                            </div>
                                            <div class=""col-md-2 col-sm-2"">
                                                <input ty");
                WriteLiteral(@"pe=""text"" class=""form-control"" style=""height:30px"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <div class=""col-md-12 col-sm-12"">
                                                <input type=""text"" class=""form-control"" style=""height:60px"">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 col-sm-6"" style=""border:1px solid black;height:511px"">
                                            aaaaa
                                            a
                                            a
                                            a
                                            a
                                        </div>
                                        <div class=""col-md-6 col-sm-6"" style=""border:1px solid black"">
    ");
                WriteLiteral(@"                                        <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Hình thức cân</label>
                                                <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <label class=""col-form-label col-md-2 col-sm-2"">Cách cân</label>
                                                <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
                                            <div class=""");
                WriteLiteral(@"form-group row"">
                                                <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:10px"">Xe VC1</label>
                                                <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"" >
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:10px;padding:5px 0px 0px 5px"">Xe VC2</label>
                                                <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:10px;padding:5px 0px 0px 5px"">Lệ");
                WriteLiteral(@"nh XK</label>
                                                <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <div class=""col-md-3 col-sm-3"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-md-12 col-sm-12"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
            ");
                WriteLiteral(@"                                <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Hợp đồng</label>
                                                <div class=""col-md-5 col-sm-5"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <div class=""col-md-5 col-sm-5"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
                                            <div class=""form-group row"" style=""padding:5px 0px 0px 5px"">
                                                <label class=""col-form-label ");
                WriteLiteral(@"col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Hàng hóa</label>
                                                <div class=""col-md-5 col-sm-5"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <div class=""col-md-5 col-sm-5"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Loại bao</label>
                                                <div class=""col-md-1 col-sm-1"" style=""p");
                WriteLiteral(@"adding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <div class=""col-md-3 col-sm-3"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <div class=""col-md-1 col-sm-1"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">Đóng</label>
                                                <div class=""col-md-1 col-sm-1"" style=""padding:5px 0px 0px");
                WriteLiteral(@" 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <label class=""col-form-label col-md-3 col-sm-3"" style=""font-size:12px"">Bao-Bao thổi-Bigbag/Cont-xe VC</label>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Tổng số bao</label>
                                                <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:1");
                WriteLiteral(@"2px;padding:5px 0px 0px 5px"">Tổng TL bao bì</label>
                                                <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Mã khách</label>
                                                <div class=""col-md-5 col-sm-5"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                                <div class=""col-md-5 col-sm-5"" style=""padding:5px 0px 0px 5px"">
     ");
                WriteLiteral(@"                                               <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Tên khách</label>
                                                <div class=""col-md-10 col-sm-10"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Ghi chú</label>
");
                WriteLiteral(@"                                                <div class=""col-md-10 col-sm-10"" style=""padding:5px 0px 0px 5px;display: flex; flex-direction: row; justify-content: center; align-items: center"">
                                                    <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    <button>save</button>
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-md-12 col-sm-12"" style=""margin-left:30px"">
                                                    <input class=""form-check-input"" type=""checkbox"">
                                                    <label class=""form-check-label"">
                                                        Nhận số cân
                                                    </label>
                              ");
                WriteLiteral(@"                  </div>
                                            </div>
                                        </div>
                                        <div class=""col-md-12 col-sm-12"" style=""border:1px solid black;float:left"">
                                            <div class=""col-md-6 col-sm-6"">
                                                <div class=""form-group row"">
                                                    <div class=""col-md-1 col-sm-1"" style=""padding:5px 0px 0px 5px"">
                                                        <input class=""form-check-input"" type=""checkbox"" style=""margin-left:5px"">
                                                        <label class=""form-check-label"" style=""margin-left:22px"">
                                                            All
                                                        </label>
                                                    </div>
                                                    <div class=""col-md-2 ");
                WriteLiteral(@"col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">Bags</label>
                                                    <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">NW</label>
                                                    <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""t");
                WriteLiteral(@"ext"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">kg</label>
                                                    <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <button type=""button"">Warehouse receipt</button>
                                                    </div>
                                                </div>
                                                <div class=""form-group row"">
                                                    <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">Cộng</label>
                                                    <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <input");
                WriteLiteral(@" type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">Xe</label>
                                                    <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">Bao</label>
                                                    <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>");
                WriteLiteral(@"
                                                    <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:12px;padding:5px 0px 0px 5px"">kg</label>
                                                    <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                        <button type=""button"">Print WH receipt</button>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-6"" style=""border-left:1px solid black"">
                                                <div class=""form-group row"">
                                                    <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Ng giao/Lái xe</label>
                                                    <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5p");
                WriteLiteral(@"x"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Người lập phiếu</label>
                                                    <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                </div>
                                                <div class=""form-group row"">
                                                    <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Nhân viên cân</label>
                                                    <div class=""col-md");
                WriteLiteral(@"-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Thủ kho</label>
                                                    <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                </div>
                                                <div class=""form-group row"">
                                                    <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">Bảo vệ</label>
                                           ");
                WriteLiteral(@"         <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                    <label class=""col-form-label col-md-2 col-sm-2"" style=""font-size:12px;padding:5px 0px 0px 5px"">LĐạo B.Phận</label>
                                                    <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                        <input type=""text"" class=""form-control"" style=""height:30px"">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-md-12 col-sm-12"" style=""border:1px solid black;float:left"">
                                    ");
                WriteLiteral(@"        <div class=""form-group row"">
                                                <label class=""col-form-label col-md-1 col-sm-1"" style=""font-size:15px;padding:15px 0px 0px 15px"">Kho</label>
                                                <div class=""col-md-4 col-sm-4"" style=""padding:5px 0px 0px 5px"">
                                                    <input type=""text"" class=""form-control"">
                                                </div>
                                                <div class=""col-md-1 col-sm-1"" style=""padding:5px 0px 0px 5px"">
                                                    <button type=""button"">New</button>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"" style=""padding:5px 0px 0px 5px"">
                                                    <button type=""button"">Save</button>
                                                </div>
                                                <d");
                WriteLiteral(@"iv class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                    <button type=""button"">Weight Notes</button>
                                                </div>
                                                <div class=""col-md-2 col-sm-2"" style=""padding:5px 0px 0px 5px"">
                                                    <button type=""button"">Re_weight</button>
                                                </div>
                                                <div class=""col-md-1 col-sm-1"" style=""padding:5px 0px 0px 5px"">
                                                    <button type=""button"">Excel</button>
                                                </div>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
