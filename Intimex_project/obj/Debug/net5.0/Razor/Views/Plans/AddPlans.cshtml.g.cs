#pragma checksum "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b4443a9b4592f7d425f48cf2773eaee4d24edf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plans_AddPlans), @"mvc.1.0.view", @"/Views/Plans/AddPlans.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4443a9b4592f7d425f48cf2773eaee4d24edf9", @"/Views/Plans/AddPlans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Plans_AddPlans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Form_PairedPlans"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
  
    ViewData["Title"] = "AddPlans";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .text-box-hdmb {
        height: 28px;
        position: relative;
        min-height: 1px;
        float: left;
        padding-right: 10px;
        padding-left: 10px;
        font-size: small;
    }
</style>
<div class=""right_col"" role=""main"">
    <div");
            BeginWriteAttribute("class", " class=\"", 372, "\"", 380, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 19 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 652, "\"", 678, 1);
#nullable restore
#line 27 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 660, ViewBag.SystemRef, 660, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""Id_HDMB"" hidden>
        <div class=""clearfix""></div>
        <div class=""row"" id=""row"">
            <div class=""col-md-12 col-sm-12"" style=""height:auto"">
                <div class=""form-group row"" style=""margin-bottom:0px"">
                    <label class=""col-form-label col-md-2 col-sm-2"">Số PA</label>
                    <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""SoPa"">
                    <label class=""col-form-label col-md-2 col-sm-2"">ID PAKD</label>
                    <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""PlansId"" disabled />
                </div>
                <div class=""form-group row"" style=""margin-bottom:0px"">
                    <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng PA</label>
                    <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""Trongluong"" disabled>
                    <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng cần ghép</l");
            WriteLiteral(@"abel>
                    <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""TLCanGhep"" disabled />
                </div>
                <div class=""form-group row"" style=""margin-bottom:0px"">
                    <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""true"" id=""Pakd"" disabled>
                    <input type=""hidden"" value=""false"" hidden>
                    <label class=""col-form-label"">PA hoàn thành ghép</label>
                </div>
                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 2237, "\"", 2265, 1);
#nullable restore
#line 48 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 2245, ViewBag.checkMuaBan, 2245, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden id=\"txtCheckMuaBan\">\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b4443a9b4592f7d425f48cf2773eaee4d24edf98350", async() => {
                WriteLiteral(@"
                    <hr size=""3"">
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-12 col-sm-12"">Hợp đồng bán</label>
                    </div>
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Số HĐ</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtSoHD_BAN"" name=""txtSoHD_BAN"">
                        <label class=""col-form-label col-md-2 col-sm-2"">ID HĐ</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtIdHD_BAN"" name=""txtIdHD_BAN"" />
                    </div>
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng HĐ</label>
                        <input type=""text"" class=""form-control col-");
                WriteLiteral(@"md-4 col-sm-4 text-box-hdmb"" id=""txtTrongLuongHD_BAN"" name=""txtTrongLuongHD_BAN"">
                        <label class=""col-form-label col-md-2 col-sm-2"">ĐVT</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtDvtHD_BAN"" name=""txtDvtHD_BAN"" />
                    </div>
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng ghép</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtTrongLuongGhepHD_BAN"" name=""txtTrongLuongGhepHD_BAN"">
                        <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""0"" id=""ChbHoangThanhGhepHd_BAN"" name=""ChbHoangThanhGhepHd_BAN"">
                        <input type=""hidden"" value=""1"" hidden id=""ChbHoangThanhGhepHd_BAN"" name=""ChbHoangThanhGhepHd_BAN"">
                        <label class=""col-form-label"">HĐ hoàn thành ghép</label>");
                WriteLiteral("\n                    </div>\r\n");
                WriteLiteral(@"                    <hr size=""3"">
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-12 col-sm-12"">Hợp đồng mua</label>
                    </div>
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Số HĐ</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtSoHD_MUA"" name=""txtSoHD_MUA"">
                        <label class=""col-form-label col-md-2 col-sm-2"">ID HĐ</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtIdHD_MUA"" name=""txtIdHD_MUA"" />
                    </div>
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng HĐ</label>
                        <input type=""text"" class=""form-control col-md");
                WriteLiteral(@"-4 col-sm-4 text-box-hdmb"" id=""txtTrongLuongHD_MUA"" name=""txtTrongLuongHD_MUA"">
                        <label class=""col-form-label col-md-2 col-sm-2"">ĐVT</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtDvtHD_MUA"" name=""txtDvtHD_MUA"" />
                    </div>
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng ghép</label>
                        <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""txtTrongLuongGhepHD_MUA"" name=""txtTrongLuongGhepHD_MUA"">
                        <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""0"" id=""ChbHoangThanhGhepHd_MUA"" name=""ChbHoangThanhGhepHd_MUA"">
                        <input type=""hidden"" value=""1"" hidden name=""ChbHoangThanhGhepHd_MUA"" id=""ChbHoangThanhGhepHd_MUA"">
                        <label class=""col-form-label"">HĐ hoàn thành ghép</label>
 ");
                WriteLiteral("                   </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                ");
#nullable restore
#line 101 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
            Write(Html.DevExtreme().DataGrid().ID("DataGrid_Plans")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("Plans")
                                        .LoadAction("getPlans")
                                        .Key("Systemref")
                                        .LoadParams(new { id = new JS("GetPlansId") })
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.Add().DataField("PlansId").Caption("Plans Id");

                                        columns.Add().DataField("ContracId").Caption("Contrac Id");

                                        columns.Add().DataField("SystemId").Caption("System Id");

                                        columns.Add().DataField("Trongluong").Caption("Trọng lượng");

                                        columns.Add().DataField("Macn").Caption("Mã Cn");

                                        columns.Add().DataField("Systemref").Caption("Systemref");

                                        columns.Add().DataField("Ref").Caption("Ref");

                                        columns.Add().DataField("Sohd").Caption("Số HĐ");

                                        columns.Add().DataField("Trangthai").Caption("Trạng thái");

                                        columns.Add().DataField("MuaBan").Caption("Mua bán");

                                        columns.Add().DataField("Makhach").Caption("Mã khách");

                                        columns.Add().DataField("Ngayky").Caption("Ngày ký");

                                        columns.Add().DataField("Ngaygiao").Caption("Ngày giao");

                                        columns.Add().DataField("Ngayhl").Caption("Ngày hiệu lực");

                                        columns.Add().DataField("Ngaytl").Caption("Ngày tl");

                                        columns.Add().DataField("Nguoitl").Caption("Người tl");

                                        columns.Add().DataField("Nguoilam").Caption("Người làm");

                                        columns.Add().DataField("Ghichu").Caption("Ghi chú");

                                        columns.Add().DataField("Pakd").Caption("PAKD");

                                        columns.Add().DataField("SoPakd").Caption("Số PAKD");

                                        columns.Add().DataField("IsFix").Caption("IsFix");

                                        columns.Add().DataField("Tiente").Caption("Tiền tệ");

                                        columns.Add().DataField("ThanhtoanId").Caption("Thanh toán Id");

                                        columns.Add().DataField("Thanhtoan").Caption("Thanh toán");

                                        columns.Add().DataField("Ngaylam").Caption("Ngày làm");

                                        columns.Add().DataField("IntKy").Caption("Int ký");

                                        columns.Add().DataField("ClientKy").Caption("Client ký");

                                        columns.Add().DataField("Docstatus").Caption("Doc status");

                                        columns.Add().DataField("TrangthaiGhep").Caption("Trạng thái ghép");

                                        columns.Add().DataField("TienUngHd").Caption("Tiền ứng HĐ");

                                        columns.Add().DataField("TienUngTt").Caption("Tiền ứng TT");

                                        columns.Add().DataField("HdcmuonId").Caption("Id HĐ cho mượn");

                                        columns.Add().DataField("SoHdcmuon").Caption("Số HĐ cho mượn");

                                        columns.Add().DataField("DiaDiemGiaoHang").Caption("Địa điểm giao hàng");

                                        columns.Add().DataField("IsNoKhoDoi").Caption("Is nợ khó đòi");

                                        columns.Add().DataField("TypeKd").Caption("Type KD");

                                        columns.Add().DataField("VanChuyen").Caption("Vận chuyển");

                                        columns.Add().DataField("NgayTraPhaitra").Caption("Ngày trả phải trả");

                                        columns.Add().DataField("Tenfull").Caption("Tên full");

                                    })
                                    .ColumnAutoWidth(true)
                                    .Selection(s => s.Mode(SelectionMode.Single))
                                    .HoverStateEnabled(true)
                                    .HeaderFilter(hearder => hearder.Visible(true))
                                    .AllowColumnResizing(true)
                                    .AllowColumnReordering(true)
                                    .ShowBorders(true)
                                    .Grouping(group => group.AutoExpandAll(true))
                                    .Paging(paging => paging.PageSize(24))
                                );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div style=""text-align:right"">
                    <button type=""button"" class=""btn btn-secondary"" onclick=""Add_Pairedplans()"">Add</button>
                    <button type=""button"" class=""btn btn-secondary"" onclick=""close_Popup_Plans()"" id=""btn_EditPairedPlans"">Edit</button>
                    <button type=""button"" class=""btn btn-secondary"" onclick=""close_Popup_Plans()"" id=""btn_DeletePairedPlans"">Delete</button>
                </div>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral("<div class=\"modal fade bd-example-modal-lg\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myLargeModalLabel\" aria-hidden=\"true\" id=\"selected_Plans\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            ");
#nullable restore
#line 213 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
        Write(Html.DevExtreme().DataGrid()
                                    .DataSource(d => d.Mvc().Controller("Plans").LoadAction("GetPlansToAddContract").Key("SystemId"))
                                    .Columns(columns => {
                                        columns.Add().DataField("SystemId").Caption("System Id");
                                        columns.Add().DataField("soPA").Caption("Số PA");
                                        columns.Add().DataField("Trongluong").Caption("Trọng lượng");
                                        columns.Add().DataField("TLCanGhep").Caption("Trọng lượng cần ghép");
                                        columns.Add().DataField("dvt").Caption("Đơn vị tính");
                                    })
                                    .OnSelectionChanged("Selected_Plans")
                                    .HoverStateEnabled(true)
                                    .Paging(p => p.PageSize(10))
                                    .FilterRow(f => f.Visible(true))
                                    .Selection(s => s.Mode(SelectionMode.Single))
                                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" onclick=\"close_Popup_Plans()\">Selected</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<div class=\"modal fade bd-example-modal-lg\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myLargeModalLabel\" aria-hidden=\"true\" id=\"selected_HD\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            ");
#nullable restore
#line 239 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
        Write(Html.DevExtreme().DataGrid()
                                                        .DataSource(d => d.Mvc().Controller("Plans").LoadAction("GetHDMB").Key("mahang").LoadParams(new { id = new JS("Return_MuaBan") }))
                                                        .ID("dataGrid_hdmb")
                                                        .Columns(columns => {
                                                        columns.Add().DataField("mahang").Caption("Mã hàng");
                                                        columns.Add().DataField("tenhang").Caption("Tên hàng");
                                                        columns.Add().DataField("IsCheck").CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
#nullable restore
#line 245 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                                                                           Write(Html.DevExtreme().CheckBox()
                                                                                                                    .Value(new JS("data.IsCheck"))
                                                                                                                );

#line default
#line hidden
#nullable disable
    PopWriter();
}
)).Caption("Check Item");
                                                            columns.Add().DataField("dvt").Caption("ĐVT");
                                                            columns.Add().DataField("vat").Caption("VAT");
                                                            columns.Add().DataField("TLGD").Caption("TLGD");
                                                        })
                                                        .HoverStateEnabled(true)
                                                        .Paging(p => p.PageSize(10))
                                                        .FilterRow(f => f.Visible(true))
                                                        .Selection(s => s.Mode(SelectionMode.Single))
                                                    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" onclick=\"close_Popup_HangHoa()\">Selected</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<script>
    window.onload = function () {
        load_data_hdmb();
        load_disable_button();
    }
    function load_disable_button() {
        var txtSoHD_BAN = document.getElementById(""txtSoHD_BAN"").value;
        var txtSoHD_MUA = document.getElementById(""txtSoHD_MUA"").value;
        if (txtSoHD_MUA == """" && txtSoHD_BAN == """") {
            document.getElementById(""btn_EditPairedPlans"").disabled = false;
            document.getElementById(""btn_DeletePairedPlans"").disabled = false;
        }
        else if (txtSoHD_BAN != """" || txtSoHD_MUA != """")
        {
            document.getElementById(""btn_EditPairedPlans"").disabled = true;
            document.getElementById(""btn_DeletePairedPlans"").disabled = true;
        }

    }
    function Disable_HDBan() {
        document.getElementById(""txtSoHD_BAN"").disabled  = true;
        document.getElementById(""txtIdHD_BAN"").disabled  = true;
        document.getElementById(""txtTrongLuongHD_BAN"").disabled  = true;
        document.getEl");
            WriteLiteral(@"ementById(""txtTrongLuongGhepHD_BAN"").disabled = true;
        document.getElementById(""txtDvtHD_BAN"").disabled = true;
    }
    function Disable_HDMua() {
        document.getElementById(""txtSoHD_MUA"").disabled = true;
        document.getElementById(""txtIdHD_MUA"").disabled = true;
        document.getElementById(""txtTrongLuongHD_MUA"").disabled = true;
        document.getElementById(""txtTrongLuongGhepHD_MUA"").disabled = true;
        document.getElementById(""txtDvtHD_MUA"").disabled = true;
    }
    function load_data_hdmb() {
        var txtCheckMuaBan = document.getElementById(""txtCheckMuaBan"").value;
        if (txtCheckMuaBan == ""MUA"") {
            document.getElementById(""txtSoHD_MUA"").value = '");
#nullable restore
#line 300 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                       Write(ViewBag.Sohd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            document.getElementById(\"txtIdHD_MUA\").value = \'");
#nullable restore
#line 301 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                       Write(ViewBag.SystemRef);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            document.getElementById(\"txtTrongLuongHD_MUA\").value = \'");
#nullable restore
#line 302 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                               Write(ViewBag.TrongLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            document.getElementById(\"txtTrongLuongGhepHD_MUA\").value = \'");
#nullable restore
#line 303 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                                   Write(ViewBag.TrongLuongDuocGhep);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            Disable_HDBan();
            document.getElementById(""txtIdHD_MUA"").disabled = true;
            document.getElementById(""txtTrongLuongHD_MUA"").disabled = true;
            document.getElementById(""txtDvtHD_MUA"").disabled = true;
        }
        else {
            document.getElementById(""txtSoHD_BAN"").value = '");
#nullable restore
#line 310 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                       Write(ViewBag.Sohd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            document.getElementById(\"txtIdHD_BAN\").value = \'");
#nullable restore
#line 311 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                       Write(ViewBag.SystemRef);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            document.getElementById(\"txtTrongLuongHD_BAN\").value = \'");
#nullable restore
#line 312 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                               Write(ViewBag.TrongLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            document.getElementById(\"txtTrongLuongGhepHD_BAN\").value = \'");
#nullable restore
#line 313 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                                                                   Write(ViewBag.TrongLuongDuocGhep);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            Disable_HDMua();
            document.getElementById(""txtIdHD_BAN"").disabled = true;
            document.getElementById(""txtTrongLuongHD_BAN"").disabled = true;
            document.getElementById(""txtDvtHD_BAN"").disabled = true;
        }
    }
    function GetPlansId() {
        return document.getElementById(""PlansId"").value;
    }
    $(""#SoPa"").keyup(function (event) {
        if (event.keyCode === 13) {
            $(""#selected_Plans"").modal('show');
        }
    });
    $(""#txtSoHD_BAN"").keyup(function (event) {
        if (event.keyCode === 13) {
            console.log(1);
            $(""#selected_HD"").modal('show');
        }
    });
    $(""#txtSoHD_MUA"").keyup(function (event) {
        if (event.keyCode === 13) {
            console.log(0);
            $(""#selected_HD"").modal('show');
        }
    });
    function Return_MuaBan() {
        var MuaBan = ""MUA""
        return MuaBan;
    }
    function Selected_Plans(selectedItems) {
        var data =");
            WriteLiteral(@" selectedItems.selectedRowsData[0];
        var IdHDMB = document.getElementById(""Id_HDMB"").value;
        var txtCheckMuaBan = document.getElementById(""txtCheckMuaBan"").value;
        if (data) {
            $.post('/Plans/Fill_data_plans', { 'SystemId': data.SystemId, 'Id_HDMB': IdHDMB }, function (item) {
                if (item == 1) {
                    $.notify(""Phương án này đã có hợp đồng bán. Bạn không thể thêm hợp đồng bán cho PAKD này"",""error"");
                }
                else {
                    document.getElementById(""PlansId"").value = item.SystemId;
                    document.getElementById(""SoPa"").value = item.SoPa;
                    document.getElementById(""Trongluong"").value = item.Trongluong;
                    document.getElementById(""TLCanGhep"").value = item.TLCanGhep;
                    if (txtCheckMuaBan == ""MUA"") {
                        document.getElementById(""txtDvtHD_MUA"").value = item.Dvt;
                    }
                    else {
        ");
            WriteLiteral(@"                document.getElementById(""txtDvtHD_BAN"").value = item.Dvt;
                    }
                    $(""#DataGrid_Plans"").dxDataGrid(""refresh"");
                }


            })
        }
    }
    function close_Popup_Plans() {
        $(""#selected_Plans"").modal('hide');
    }
    function Add_Pairedplans() {
        var PlansId = document.getElementById(""PlansId"").value;
        var txtSoHD_BAN = document.getElementById(""txtSoHD_BAN"").value;
        var txtSoHD_MUA = document.getElementById(""txtSoHD_MUA"").value;
        if (txtSoHD_BAN == """" && txtSoHD_MUA == """") {
            $.notify(""vui lòng chọn hợp đồng cần ghép"", ""error"");
        } else {
            document.getElementById(""Form_PairedPlans"").action = '/Plans/Add_PairedPlans/' + PlansId;
            document.getElementById(""Form_PairedPlans"").submit();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
