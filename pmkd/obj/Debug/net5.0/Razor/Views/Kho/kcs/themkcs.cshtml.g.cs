#pragma checksum "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb0eb66861e3023cd8b77082bc9bfdeca7ed280"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kho_kcs_themkcs), @"mvc.1.0.view", @"/Views/Kho/kcs/themkcs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb0eb66861e3023cd8b77082bc9bfdeca7ed280", @"/Views/Kho/kcs/themkcs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f3fdee9548d5779914426f2f6cb4c3005f9059", @"/Views/_ViewImports.cshtml")]
    public class Views_Kho_kcs_themkcs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "themkcs1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "kho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
  
    ViewData["Title"] = "hdmb1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\" style=\"height:800px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 167, "\"", 175, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"col-md-12 col-sm-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb0eb66861e3023cd8b77082bc9bfdeca7ed2804796", async() => {
                WriteLiteral(@" 
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Thêm<small>KCS</small></h2>
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
                            </li>
                            <li>
                                <a class=""close-link""><i c");
                WriteLiteral("lass=\"fa fa-close\"></i></a>\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 29 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                          
                            if (TempData["alertMessage"] != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div style=\"color:red;font-size:30px\">\r\n                                    ");
#nullable restore
#line 33 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 35 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"clearfix\"></div>\r\n                    </div>\r\n                    <div class=\"x_content\">\r\n                        <br />\r\n");
#nullable restore
#line 41 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                          
                            var item = new[] { "cafe", "gạo" };
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                         using (Html.DevExtreme().ValidationGroup())
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                        Write(Html.DevExtreme().RadioGroupFor(m => m.Manhom).Items(item).Value("cafe").Layout(Orientation.Horizontal));

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-group row\">\r\n                                <label class=\"col-form-label col-md-1 col-sm-1\">Số xe</label>\r\n                                <div class=\"col-md-5 col-sm-5\">\r\n                                    ");
#nullable restore
#line 51 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().DropDownBoxFor(m => m.XeptaiId)
                                        .ValueExpr("Id")
                                        .DisplayExpr("TruckNo")
                                        .DataSource(d => d.Mvc()
                                            .Controller("lookup")
                                            .LoadAction("getxevc")
                                            .LoadMode(DataSourceLoadMode.Raw)
                                            .Key("Id")
                                        )
                                        .Placeholder("Select a value...")
                                        .ShowClearButton(true)
                                        .OnValueChanged("valuechange_xevc")
                                        .ContentTemplate(new TemplateName("template_xevc"))
                                        );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                     using (Html.DevExtreme().NamedTemplate("template_xevc"))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                    Write(Html.DevExtreme().DataGrid()
                                            .ID("xevc")
                                            .DataSource(new JS(@"component.getDataSource()"))
                                            .Columns(columns => {
                                                columns.Add().DataField("TruckNo");
                                                columns.Add().DataField("Tenhang");
                                                columns.Add().DataField("KhachHang");
                                            })
                                            .HoverStateEnabled(true)
                                            .Paging(p => p.PageSize(10))
                                            .FilterRow(f => f.Visible(true))
                                            .Scrolling(s => s.Mode(GridScrollingMode.Virtual))
                                            .Height(345)
                                            .Selection(s => s.Mode(SelectionMode.Single))
                                            .SelectedRowKeys(new JS(@"component.option(""value"") ? [component.option(""value"")] : []"))
                                            .OnSelectionChanged(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("function(selectedItems) {\r\n                                                var array = ");
#nullable restore
#line 83 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                                       Write(Html.Raw(Json.Serialize(ViewBag.xeptai)));

#line default
#line hidden
#nullable disable
    WriteLiteral(";\r\n                                                var chuoi = [];\r\n                                                var array1 = ");
#nullable restore
#line 85 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                                        Write(Html.Raw(Json.Serialize(ViewBag.can)));

#line default
#line hidden
#nullable disable
    WriteLiteral(@";
                                                var chuoi1 = [];
                                                var txtKhachhang = document.getElementById(""txtKhachhang"");
                                                var keys = selectedItems.selectedRowKeys;
                                                for (var i = 0;i ");
#nullable restore
#line 89 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                                            Write(Html.Raw("<"));

#line default
#line hidden
#nullable disable
    WriteLiteral(@" array.length; i++)
                                                {
                                                    chuoi[i] = array[i];
                                                    if (chuoi[i].Id == keys){
                                                        $(""#txtKhachhang"").dxTextBox(""instance"").option(""value"", chuoi[i].MaKhach);
                                                        $(""#txtTenkhach"").dxTextBox(""instance"").option(""value"", chuoi[i].KhachHang);
                                                        $(""#dateNgaynhap"").dxDateBox(""instance"").option(""value"", chuoi[i].Ngaycan);
                                                        $(""#txtMahang"").dxTextBox(""instance"").option(""value"", chuoi[i].Mahang);
                                                        $(""#txtTenhang"").dxTextBox(""instance"").option(""value"", chuoi[i].Tenhang);
                                                        $(""#txtSoluong"").dxTextBox(""instance"").option(""value"", chuoi[i].SoBao);
          ");
    WriteLiteral("                                              $(\"#selectLoaibao\").dxSelectBox(\"instance\").option(\"value\", chuoi[i].BagTypeId);\r\n                                                        for (var j = 0;j ");
#nullable restore
#line 100 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                                                    Write(Html.Raw("<"));

#line default
#line hidden
#nullable disable
    WriteLiteral(@" array1.length;j++){
                                                            chuoi1[j] = array1[j];
                                                            if (chuoi1[j].SystemId == chuoi[i].CanId){
                                                                $(""#trongluongGW"").dxTextBox(""instance"").option(""value"", chuoi1[j].TlBao + chuoi1[j].TlNet);
                                                                $(""#trongluongNW"").dxTextBox(""instance"").option(""value"", chuoi1[j].TlNet);
                                                            }
                                                        }
                                                        if (chuoi[i].Status == 2){
                                                            $(""#txtGhichu"").dxTextBox(""instance"").option(""value"", ""Đạt nếm thử"");
                                                        }else{
                                                            $(""#txtGhichu"").dxTextBox(""instance"").option(""value"", """);
    WriteLiteral(@"Không đạt nếm thử"");
                                                        }
                                                    }
                                                }
                                                component.option(""value"", keys);
                                                component.close();
                                            }");
    PopWriter();
}
))
                                        );

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                                <label class=\"col-form-label col-md-1 col-sm-1\">Ngày cân</label>\r\n                                <div class=\"col-form-label col-md-5 col-sm-5\">\r\n                                    ");
#nullable restore
#line 122 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().DateBoxFor(m => m.NgayNhap).ID("dateNgaynhap"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-1 col-sm-1"">Khách hàng</label>
                                <div class=""col-md-2 col-sm-2"">
                                    ");
#nullable restore
#line 128 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.KhachHang).ID("txtKhachhang"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-3 col-sm-3\">\r\n                                    ");
#nullable restore
#line 131 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.TenKhach).ID("txtTenkhach"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                                <label class=""col-form-label col-md-1 col-sm-1"">Hàng hóa</label>
                                <div class=""col-form-label col-md-2 col-sm-2"">
                                    ");
#nullable restore
#line 135 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Mahang).ID("txtMahang"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-form-label col-md-3 col-sm-3\">\r\n                                    ");
#nullable restore
#line 138 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.TenHang).ID("txtTenhang"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-1 col-sm-1"">Số bao</label>
                                <div class=""col-md-5 col-sm-5"">
                                    ");
#nullable restore
#line 144 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.SoLuong).ID("txtSoluong"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                                <label class=""col-form-label col-md-1 col-sm-1"">Loại bao</label>
                                <div class=""col-form-label col-md-5 col-sm-5"">
                                    ");
#nullable restore
#line 148 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().SelectBoxFor(m => m.LoaiBao)
                                                            .DataSource(d => d.Mvc().Controller("lookup")
                                                                                    .LoadAction("getloaibao")
                                                                                    .LoadMode(DataSourceLoadMode.Raw)
                                                                                    )
                                                            .DisplayExpr("Name")
                                                            .ValueExpr("BagTypeId")
                                                            .ID("selectLoaibao")
                                                            );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng(GW)</label>
                                <div class=""col-md-4 col-sm-4"">
                                    ");
#nullable restore
#line 162 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.TrongLuong).ID("trongluongGW"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                                <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng(NW)</label>
                                <div class=""col-form-label col-md-4 col-sm-4"">
                                    ");
#nullable restore
#line 166 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.TrongLuongNw).ID("trongluongNW"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"" style=""color:red;font-size:16px"">Tiêu chuẩn chất lượng</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Độ ẩm</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Tạp chất</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Độ vỡ</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Mốc</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Nâu</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">K.loài</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Tr.Xốp</label>
                                <label class=""col-form-label col-md-1 col-sm-1");
                WriteLiteral(@""">H.cháy</label>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2""></label>
                                <div class=""col-md-1 col-sm-1"">
                                    ");
#nullable restore
#line 183 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.DoAm));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 186 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.TapChat));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 189 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.DenVo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 192 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.HatMoc));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 195 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.HatNau));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 198 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.HatCxk));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 201 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.TrangXop));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 204 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.HatChay));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"" style=""color:red;font-size:20px"">Tiêu chuẩn cơ lý</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 20</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 19</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 18</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 17</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 16</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 15</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 14</label>
                                <label class=""col-form-label col-md-1 ");
                WriteLiteral(@"col-sm-1"">Sàng 13</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 12</label>
                                <label class=""col-form-label col-md-1 col-sm-1"">Sàng 8</label>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2""></label>
                                <div class=""col-md-1 col-sm-1"">
                                    ");
#nullable restore
#line 223 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang20));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 226 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang19));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 229 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang18));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 232 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang17));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 235 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang16));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 238 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang15));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 241 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang14));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 244 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang13));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 247 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang12));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-1 col-sm-1\">\r\n                                    ");
#nullable restore
#line 250 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Sang8));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"" style=""color:red;font-size:20px"">Nguồn hàng</label>
                                <div class=""col-md-10 col-sm-10"">
                                    ");
#nullable restore
#line 256 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.NguonHang));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"">Người kiểm hàng</label>
                                <div class=""col-md-10 col-sm-10"">
                                    ");
#nullable restore
#line 262 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.NguoiKiem).Value(ViewBag.name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"">Người lấy mẫu</label>
                                <div class=""col-md-10 col-sm-10"">
                                    ");
#nullable restore
#line 268 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.NguoiLayMau));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"">Phụ trách Bp</label>
                                <div class=""col-md-10 col-sm-10"">
                                    ");
#nullable restore
#line 274 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.PhuTrach));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-form-label col-md-2 col-sm-2"">Ghi chú</label>
                                <div class=""col-md-10 col-sm-10"">
                                    ");
#nullable restore
#line 280 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().TextBoxFor(m => m.Ghichu).ID("txtGhichu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""ln_solid""></div>
                            <div class=""form-group row"">
                                <div class=""col-md-9 col-sm-9  offset-md-5"">
                                    ");
#nullable restore
#line 286 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                                Write(Html.DevExtreme().Button()
                                        .ID("button")
                                        .Text("Submit")
                                        .Type(ButtonType.Success)
                                        .UseSubmitBehavior(true)
                                    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 294 "C:\Users\User\Desktop\pmkd_project\pmkd\Views\Kho\kcs\themkcs.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kc> Html { get; private set; }
    }
}
#pragma warning restore 1591
