#pragma checksum "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec8dc757d106bd879adcd1a960cf6a6d1f3e16fe"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8dc757d106bd879adcd1a960cf6a6d1f3e16fe", @"/Views/Plans/AddPlans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Plans_AddPlans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral(@" id=""Id_HDMB"">
        <div class=""clearfix""></div>
        <div class=""row"" id=""row"">
            <div class=""col-md-12 col-sm-12"" style=""height:auto"">
                <div class=""form-group row"" style=""margin-bottom:0px"">
                    <label class=""col-form-label col-md-2 col-sm-2"">Số PA</label>
                    <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""SoPa"">
                    <label class=""col-form-label col-md-2 col-sm-2"">ID PAKD</label>
                    <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""PlansId"" />
                </div>
                <div class=""form-group row"" style=""margin-bottom:0px"">
                    <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng PA</label>
                    <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""Trongluong"">
                    <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng cần ghép</label>
                  ");
            WriteLiteral(@"  <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""TLCanGhep""/>
                </div>
                <div class=""form-group row"" style=""margin-bottom:0px"">
                    <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""true"" id=""Pakd"" disabled>
                    <input type=""hidden"" value=""false"" hidden>
                    <label class=""col-form-label"">PA hoàn thành ghép</label>
                </div>
");
#nullable restore
#line 48 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                  
                    if (ViewBag.checkMuaBan == "BAN")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <hr size=""3"">
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-12 col-sm-12"">Hợp đồng bán</label>
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Số HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb""");
            BeginWriteAttribute("value", " value=\"", 2787, "\"", 2808, 1);
#nullable restore
#line 57 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 2795, ViewBag.Sohd, 2795, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <label class=\"col-form-label col-md-2 col-sm-2\">ID HĐ</label>\r\n                            <input type=\"text\" class=\"form-control col-md-4 col-sm-4 text-box-hdmb\"");
            BeginWriteAttribute("value", " value=\"", 3002, "\"", 3028, 1);
#nullable restore
#line 59 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 3010, ViewBag.SystemRef, 3010, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb""");
            BeginWriteAttribute("value", " value=\"", 3344, "\"", 3371, 1);
#nullable restore
#line 63 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 3352, ViewBag.TrongLuong, 3352, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <label class=""col-form-label col-md-2 col-sm-2"">ĐVT</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" />
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng ghép</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb""");
            BeginWriteAttribute("value", " value=\"", 3881, "\"", 3916, 1);
#nullable restore
#line 69 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 3889, ViewBag.TrongLuongDuocGhep, 3889, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""true"" id=""Pakd"" disabled>
                            <input type=""hidden"" value=""false"" hidden>
                            <label class=""col-form-label"">HĐ hoàn thành ghép</label>
                        </div>
                        <hr size=""3"">
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-12 col-sm-12"">Hợp đồng mua</label>
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Số HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"">
                            <label class=""col-form-label col-md-2 col-sm-2"">ID HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdm");
            WriteLiteral(@"b"" />
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"">
                            <label class=""col-form-label col-md-2 col-sm-2"">ĐVT</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" />
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng ghép</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"">
                            <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""true"" id=""Pakd"" disabled>
                            <input type=""hidden"" value=""false"" hidden>
   ");
            WriteLiteral("                         <label class=\"col-form-label\">HĐ hoàn thành ghép</label>\r\n                        </div>\r\n");
#nullable restore
#line 97 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <hr size=""3"">
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-12 col-sm-12"">Hợp đồng bán</label>
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Số HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"">
                            <label class=""col-form-label col-md-2 col-sm-2"">ID HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" />
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box");
            WriteLiteral(@"-hdmb"">
                            <label class=""col-form-label col-md-2 col-sm-2"">ĐVT</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" />
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng ghép</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"">
                            <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""true"" id=""Pakd"" disabled>
                            <input type=""hidden"" value=""false"" hidden>
                            <label class=""col-form-label"">HĐ hoàn thành ghép</label>
                        </div>
                        <hr size=""3"">
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-12 col-sm-12"">");
            WriteLiteral(@"Hợp đồng mua</label>
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Số HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb""");
            BeginWriteAttribute("value", " value=\"", 8524, "\"", 8545, 1);
#nullable restore
#line 129 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 8532, ViewBag.Sohd, 8532, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <label class=\"col-form-label col-md-2 col-sm-2\">ID HĐ</label>\r\n                            <input type=\"text\" class=\"form-control col-md-4 col-sm-4 text-box-hdmb\"");
            BeginWriteAttribute("value", " value=\"", 8739, "\"", 8765, 1);
#nullable restore
#line 131 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 8747, ViewBag.SystemRef, 8747, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng HĐ</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb""");
            BeginWriteAttribute("value", " value=\"", 9081, "\"", 9108, 1);
#nullable restore
#line 135 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 9089, ViewBag.TrongLuong, 9089, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <label class=""col-form-label col-md-2 col-sm-2"">ĐVT</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" />
                        </div>
                        <div class=""form-group row"" style=""margin-bottom:0px"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Trọng lượng ghép</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb""");
            BeginWriteAttribute("value", " value=\"", 9618, "\"", 9653, 1);
#nullable restore
#line 141 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
WriteAttributeValue("", 9626, ViewBag.TrongLuongDuocGhep, 9626, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <input type=""checkbox"" style=""margin:10px 10px 0px 10px"" value=""true"" id=""Pakd"" disabled>
                            <input type=""hidden"" value=""false"" hidden>
                            <label class=""col-form-label"">HĐ hoàn thành ghép</label>
                        </div>
");
#nullable restore
#line 146 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 149 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<div class=\"modal fade bd-example-modal-lg\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myLargeModalLabel\" aria-hidden=\"true\" id=\"selected_Plans\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            ");
#nullable restore
#line 256 "C:\Users\Sterben\Desktop\pmkd_intimex\Intimex_project\Views\Plans\AddPlans.cshtml"
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
            WriteLiteral(@"<script>
    function GetPlansId() {
        return document.getElementById(""PlansId"").value;
    }
    $(""#SoPa"").keyup(function (event) {
        if (event.keyCode === 13) {
            $(""#selected_Plans"").modal('show');
        }
    });
    function Selected_Plans(selectedItems) {
        var data = selectedItems.selectedRowsData[0];
        var IdHDMB = document.getElementById(""Id_HDMB"").value;
        if (data) {
            $.post('/Plans/Fill_data_plans', { 'SystemId': data.SystemId, 'Id_HDMB': IdHDMB }, function (item) {
                if (item == 1) {
                    $.notify(""Phương án này đã có hợp đồng bán. Bạn không thể thêm hợp đồng bán cho PAKD này"",""error"");
                }
                else {
                    document.getElementById(""PlansId"").value = item.SystemId;
                    document.getElementById(""SoPa"").value = item.SoPa;
                    document.getElementById(""Trongluong"").value = item.Trongluong;
                    document.getElementB");
            WriteLiteral(@"yId(""TLCanGhep"").value = item.TLCanGhep;
                    $(""#DataGrid_Plans"").dxDataGrid(""refresh"");
                }


            })
        }
    }
    function close_Popup_Plans() {
        $(""#selected_Plans"").modal('hide');
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
