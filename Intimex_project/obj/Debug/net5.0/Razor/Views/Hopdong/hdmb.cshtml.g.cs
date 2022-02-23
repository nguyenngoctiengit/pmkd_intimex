#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "097788302169dc67f120314a6e8e80292876f647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hopdong_hdmb), @"mvc.1.0.view", @"/Views/Hopdong/hdmb.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#nullable restore
#line 1 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"097788302169dc67f120314a6e8e80292876f647", @"/Views/Hopdong/hdmb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Hopdong_hdmb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
  
    ViewData["Title"] = "Hợp đồng mua bán";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .text-box-hdmb {\r\n        height: 28px;\r\n        position: relative;\r\n        min-height: 1px;\r\n        float: left;\r\n        padding-right: 10px;\r\n        padding-left: 10px;\r\n    }\r\n</style>\r\n<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 375, "\"", 383, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix\"></div>\r\n        <div class=\"row\" id=\"row\">\r\n            <div class=\"col-md-12 col-sm-12\">\r\n                <div class=\"col-md-3 col-sm-3\" id=\"leftdiv\">\r\n\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
                      
                        DateTime now = DateTime.Now;
                        var startDate = new DateTime(now.Year, now.Month, 1);
                        var endDate = startDate.AddMonths(1).AddDays(-1);
                        var filterValue = new object[] { new object[] { "Ngaylam", FilterBuilderFieldFilterOperations.Between, new object[] { startDate, endDate } } };
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 37 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
                Write(Html.DevExtreme().SelectBox()
                                    .DataSource(new JS("LOAIHD"))
                                    .DisplayExpr("name")
                                    .ValueExpr("id")
                                    .Value("ALL")
                                    .OnValueChanged(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                                        function(data) {
                                            var dataGrid = $(""#DataGrid_HDMB"").dxDataGrid(""instance"");
                                            if (data.value == ""ALL"")
                                                dataGrid.clearFilter();
                                            else
                                                dataGrid.filter([""MuaBan"", ""="", data.value]);
                                        }
                                    ");
    PopWriter();
}
))
                                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 52 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.Hdmb>().ID("DataGrid_HDMB")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("Hopdong")
                                        .LoadAction("GetHopdong")
                                        .Key("Systemref")
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.Systemref).Caption("Systemref");

                                        columns.AddFor(m => m.Sohd).Caption("Số HĐ").Width(120);

                                        columns.AddFor(m => m.Trangthai).Caption("Tt");

                                        columns.AddFor(m => m.Ngaylam).Visible(false);

                                        columns.AddFor(m => m.MuaBan).Visible(false);

                                    })
                                    .FilterPanel(e => e.Visible(true))
                                    .FilterValue(filterValue)
                                    .FilterBuilderPopup(p =>
                                        p.Position(pos =>
                                            pos.At(HorizontalAlignment.Center, VerticalAlignment.Top)
                                                .My(HorizontalAlignment.Center, VerticalAlignment.Top)
                                                .Offset(0, 10)
                                        )
                                    )
                                    .OnSelectionChanged("Hdmb_Selection")
                                    .Selection(s => s.Mode(SelectionMode.Single))
                                    .HoverStateEnabled(true)
                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                    .HeaderFilter(hearder => hearder.Visible(true))
                                    .AllowColumnResizing(true)
                                    .AllowColumnReordering(true)
                                    .ShowBorders(true)
                                    .Grouping(group => group.AutoExpandAll(true))
                                    .Paging(paging => paging.PageSize(15))
                                );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
                <div class=""col-md-9 col-sm-9"" id=""rightdiv"" style=""height:auto"">
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <div class=""col-md-8 col-sm-8"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Mã ĐV</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""Macn"" disabled>
                            <label class=""col-form-label col-md-2 col-sm-2"">Người tạo</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"" id=""Nguoilam"" disabled>
                        </div>
                        <div class=""col-md-4 col-sm-4"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""TypeKd"" id=""Tru");
            WriteLiteral(@"cTiep"" checked disabled><label for=""y"">Trực tiếp</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""TypeKd"" id=""UyThac"" disabled><label for=""y"">Ủy thác</label>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-md-8 col-sm-8"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" id=""MUA"" name=""MuaBan"" checked disabled><label for=""MUA"">Mua hàng</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" id=""BAN"" name=""MuaBan"" disabled><label for=""BAN"">Bán hàng</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" id=""MUON"" name=""MuaBan"" disabled><label for=""MUON"">Mượn hàng</label>
                       ");
            WriteLiteral(@"     <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" id=""CMUON"" name=""MuaBan"" disabled><label for=""CMUON"">Cho mượn</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" id=""KTRA"" name=""MuaBan"" disabled><label for=""KTRA"">Khách trả</label>
                        </div>
                        <div class=""col-md-4 col-sm-4"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""IsFix"" id=""OutRight"" checked disabled><label for=""y"">Giá outright</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""IsFix"" id=""TruLui"" disabled><label for=""y"">Giá trừ lùi</label>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 ");
            WriteLiteral(@"col-sm-2"">System ID</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Systemref"" disabled>
                        <div class=""col-md-8 col-sm-8"" style=""text-align:left"">
                            <input type=""checkbox"" style=""margin-right:10px;margin-left:10px"" disabled><label class=""col-form-label"">Hợp đồng bắt buộc có PAKD</label>
                            <input type=""checkbox"" style=""margin-right: 10px; margin-left: 10px"" disabled><label class=""col-form-label"">Hợp đồng nợ khó đòi</label>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Ref</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Ref"" disabled>
                        <label class=""col-form-label col-md-2 col-sm-2"">Số hợp đồng</label>
                        <input type=""text""");
            WriteLiteral(@" class=""form-control col-md-6 col-sm-6 text-box-hdmb"" id=""Sohd"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Tiền tệ</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Tiente"" disabled>
                        <input type=""text"" class=""form-control col-md-8 col-sm-8 text-box-hdmb"" id=""Money"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Khách hàng</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Makhach"" disabled>
                        <input type=""text"" class=""form-control col-md-5 col-sm-5 text-box-hdmb"" id=""Tenfull"" disabled>
                        <label class=""col-form-label col-md-1 col-sm-1"">V.chuyển</label>
                        <input type=""tex");
            WriteLiteral(@"t"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""VanChuyen"" disabled>
                    </div>
                    <div class=""form-group row"" style=""display:none"" id=""hdmb_chomuon"">
                        <label class=""col-form-label col-md-2 col-sm-2"">HĐ cho mượn</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""SoHdcmuon"" disabled>
                        <input type=""text"" class=""form-control col-md-8 col-sm-8 text-box-hdmb"" id=""HdcmuonId"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">INT Ký</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""IntKy"" disabled>
                        <input type=""text"" class=""form-control col-md-8 col-sm-8 text-box-hdmb"" id=""Name_IntKy"" disabled>
                    </div>
                    <div class=""form-group row"">
 ");
            WriteLiteral(@"                       <label class=""col-form-label col-md-2 col-sm-2"">Khách ký</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""ClientKy"" disabled>
                        <input type=""text"" class=""form-control col-md-8 col-sm-8 text-box-hdmb"" id=""Name_ClientKy"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Thanh toán</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Thanhtoan"" disabled>
                        <input type=""text"" class=""form-control col-md-8 col-sm-8 text-box-hdmb"" id=""TenTT"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Địa điểm giao hàng</label>
                        <input type=""text"" class=""form-control col-md-10 col-sm-10 text-box-hd");
            WriteLiteral(@"mb"" id=""DiaDiemGiaoHang"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-1 col-sm-1"">Mức ứng</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Mucung"" disabled>
                        <label class=""col-form-label col-md-auto col-sm-auto"">Tạm ứng theo HĐ(FOB)</label>
                        <input type=""text"" class=""form-control col-md-3 col-sm-3 text-box-hdmb"" id=""TienUngHd"" disabled>
                        <label class=""col-form-label col-md-auto col-sm-auto"">Tạm ứng thực tế</label>
                        <input type=""text"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""TienUngTt"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-1 col-sm-1"">Ngày hđ</label>
                        <input type=""date"" class=""form-control text-box");
            WriteLiteral(@"-hdmb col-md-2 col-sm-2"" id=""Ngayky"" disabled>
                        <label class=""col-form-label col-md-1 col-sm-1"" style=""padding-left:0px;padding-right:0px"">Ngày g.hàng</label>
                        <input type=""date"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Ngaygiao"" disabled>
                        <label class=""col-form-label col-md-1 col-sm-1"" style=""padding-left:0px;padding-right:0px"">Ngày h.lực</label>
                        <input type=""date"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""Ngayhl"" disabled>
                        <label class=""col-form-label col-md-1 col-sm-1"" style=""padding-left:0px;padding-right:0px;display:none"" id=""label_ngaytra"">Ngày trả</label>
                        <input type=""date"" class=""form-control col-md-2 col-sm-2 text-box-hdmb"" id=""NgayTraPhaitra"" style=""display:none"" disabled>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-1 col-sm");
            WriteLiteral("-1\">Ghi chú</label>\r\n                        <textarea type=\"text\" class=\"form-control col-md-11 col-sm-11 text-box-hdmb\" id=\"Ghichu\" disabled></textarea>\r\n                    </div>\r\n                    ");
#nullable restore
#line 192 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
                Write(Html.DevExtreme().DataGrid<Data.Models.Trading_system.CtHdmb>().ID("DataGrid_Ct_HDMB")
                                    .DataSource(ds => ds.Mvc()
                                        .Controller("Hopdong")
                                        .LoadAction("GetCt_HDMB")
                                        .Key("IdRow")
                                        .LoadParams(new { id = new JS("GetSystemRef") })
                                    )
                                    .RemoteOperations(true)
                                    .Columns(columns => {

                                        columns.AddFor(m => m.Systemref).Caption("Systemref");

                                        columns.AddFor(m => m.Mahang).Caption("Mã hàng");

                                        columns.Add().DataField("Tenhang").Caption("Tên hàng");

                                        columns.AddFor(m => m.Soluong).Caption("Số lượng");

                                        columns.AddFor(m => m.Trongluong).Caption("Trọng lượng");

                                        columns.AddFor(m => m.Dvt).Caption("ĐVT");

                                        columns.AddFor(m => m.Vat).Caption("VAT");

                                        columns.AddFor(m => m.Giact).Caption("Giá");

                                        columns.AddFor(m => m.Giatt).Caption("Giá tạm tính");

                                        columns.AddFor(m => m.Solot).Caption("Số LOT");

                                        columns.AddFor(m => m.Giathang).Caption("Giá tháng");

                                        columns.AddFor(m => m.Gianam).Caption("Giá năm");

                                        columns.AddFor(m => m.Sig).Caption("+ / -");

                                        columns.AddFor(m => m.Diff).Caption("Mức trừ");

                                        columns.AddFor(m => m.FNgayfix).Caption("Ngày chốt");

                                        columns.AddFor(m => m.Stoploss).Caption("Mức stoploss");

                                        columns.Add().DataField("MaNhom").Caption("Mã nhóm");

                                        columns.AddFor(m => m.Giathitruong).Caption("Giá thị trường");

                                        columns.AddFor(m => m.Mucthuong).Caption("Mức thưởng");
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
                    <input type=""text"" id=""Systemref"" hidden>
                </div>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
                <button type=""button"" class=""btn btn-primary"">Primary</button>
            </div>
            
        </div>
    </div>
</div>
<script type=""text/javascript"">
    $(document).ready(function (");
            WriteLiteral(@") {
        var height = Math.max($(""#leftdiv"").height(), $(""#rightdiv"").height());
        $(""#leftdiv"").height(height);
        $(""#rightdiv"").height(height);
        $(""#row"").height(height + 50);
    });
    function Hdmb_Selection(selectedItems) {
        var data = selectedItems.selectedRowsData[0];
        if (data) {
            $.post('/Hopdong/Fill_Form_HDMB', { 'Systemref': data.Systemref }, function (array) {
                document.getElementById(""Systemref"").value = array.Systemref;
                document.getElementById(""Ref"").value = array.Ref;
                document.getElementById(""Makhach"").value = array.Makhach;
                document.getElementById(""Sohd"").value = array.Sohd;
                document.getElementById(""Tiente"").value = array.Tiente;
                document.getElementById(""IntKy"").value = array.IntKy;
                document.getElementById(""ClientKy"").value = array.ClientKy;
                document.getElementById(""Thanhtoan"").value = array.Thanhtoan;");
            WriteLiteral(@"
                document.getElementById(""Tenfull"").value = array.Tenfull;
                document.getElementById(""DiaDiemGiaoHang"").value = array.DiaDiemGiaoHang;
                document.getElementById(""Ghichu"").value = array.Ghichu;
                document.getElementById(""Ngayky"").value = new Date(array.Ngayky).toString(""yyyy-MM-dd"");
                document.getElementById(""Ngaygiao"").value = new Date(array.Ngaygiao).toString(""yyyy-MM-dd"");
                document.getElementById(""Ngayhl"").value = new Date(array.Ngayhl).toString(""yyyy-MM-dd"");
                document.getElementById(""NgayTraPhaitra"").value = new Date(array.NgayTraPhaitra).toString(""yyyy-MM-dd"");
                document.getElementById(""TienUngHd"").value = array.TienUngHd.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, '$1,');;
                document.getElementById(""TienUngTt"").value = array.TienUngTt;
                document.getElementById(""Nguoilam"").value = array.Nguoilam;
                document.getElementById(""Macn"").value =");
            WriteLiteral(@" array.Macn;
                document.getElementById(""VanChuyen"").value = array.VanChuyen;
                document.getElementById(""SoHdcmuon"").value = array.SoHdcmuon;
                document.getElementById(""HdcmuonId"").value = array.HdcmuonId;
                document.getElementById(""Mucung"").value = array.Mucung;
                document.getElementById(""Money"").value = array.Money;
                document.getElementById(""TenTT"").value = array.TenTT;
                document.getElementById(""Name_IntKy"").value = array.Name_IntKy;
                document.getElementById(""Name_ClientKy"").value = array.Name_ClientKy;
                if (array.IsFix == false) {
                    document.getElementById(""OutRight"").checked = true;
                } else {
                    document.getElementById(""TruLui"").checked = true;
                }
                if (array.TypeKd == 0) {
                    document.getElementById(""TrucTiep"").checked = true;
                } else {
               ");
            WriteLiteral(@"     document.getElementById(""UyThac"").checked = true;
                }
                switch (array.MuaBan) {
                    case ""MUA"":
                        document.getElementById(""MUA"").checked = true;
                        document.getElementById(""label_ngaytra"").style.display = ""none"";
                        document.getElementById(""NgayTraPhaitra"").style.display = ""none"";
                        document.getElementById(""hdmb_chomuon"").style.display = ""none"";
                        break;
                    case ""BAN"":
                        document.getElementById(""BAN"").checked = true;
                        document.getElementById(""label_ngaytra"").style.display = ""none"";
                        document.getElementById(""NgayTraPhaitra"").style.display = ""none"";
                        document.getElementById(""hdmb_chomuon"").style.display = ""none"";
                        break;
                    case ""MUON"":
                        document.getElementById(""MUON"").chec");
            WriteLiteral(@"ked = true;
                        document.getElementById(""label_ngaytra"").style.display = ""block"";
                        document.getElementById(""NgayTraPhaitra"").style.display = ""block"";
                        document.getElementById(""hdmb_chomuon"").style.display = ""none"";
                        break;
                    case ""CMUON"":
                        document.getElementById(""CMUON"").checked = true;
                        document.getElementById(""label_ngaytra"").style.display = ""none"";
                        document.getElementById(""NgayTraPhaitra"").style.display = ""none"";
                        document.getElementById(""hdmb_chomuon"").style.display = ""none"";
                        break;
                    case ""KTRA"":
                        document.getElementById(""KTRA"").checked = true;
                        document.getElementById(""label_ngaytra"").style.display = ""none"";
                        document.getElementById(""NgayTraPhaitra"").style.display = ""none"";
        ");
            WriteLiteral(@"                document.getElementById(""hdmb_chomuon"").style.display = ""block"";
                        break;
                }
            })
            document.getElementById(""Systemref"").value = data.Systemref;
            $(""#DataGrid_Ct_HDMB"").dxDataGrid(""refresh"");
        }

    }
    function GetSystemRef() {
        var data = document.getElementById(""Systemref"").value;
        if (data == null || data == 0) {
            return 0;
        } else {
            return data;
        }

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
