#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6887cc465642a20f0ab1e5018a42e4b2468196ec"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6887cc465642a20f0ab1e5018a42e4b2468196ec", @"/Views/Hopdong/hdmb.cshtml")]
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
            WriteLiteral("<style>\r\n    .text-box-hdmb{\r\n        height:28px;\r\n    }\r\n</style>\r\n<div class=\"right_col\" role=\"main\" style=\"height: 500px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 259, "\"", 267, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 13 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
          
            if (TempData["alertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"color:red;font-size:30px\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
               Write(TempData["alertMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix\"></div>\r\n        <div class=\"row\" style=\"display: block;\">\r\n            <div class=\"col-md-12 col-sm-12\">\r\n                <div class=\"col-md-3 col-sm-3\" style=\"border: 1px solid; border-color: black; height: 1000px\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
                      
                        DateTime now = DateTime.Now;
                        var startDate = new DateTime(now.Year, now.Month, 1);
                        var endDate = startDate.AddMonths(1).AddDays(-1);
                        var filterValue = new object[] {new object[] { "Ngaylam", FilterBuilderFieldFilterOperations.Between, new object[] { startDate, endDate } } };
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 32 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
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
#line 47 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Hopdong\hdmb.cshtml"
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
                                    .Selection(s => s.Mode(SelectionMode.Single))
                                    .HoverStateEnabled(true)
                                    .FilterRow(filter => filter.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
                                    .HeaderFilter(hearder => hearder.Visible(true))
                                    .AllowColumnResizing(true)
                                    .AllowColumnReordering(true)
                                    .ShowBorders(true)
                                    .Grouping(group => group.AutoExpandAll(true))
                                    .Paging(paging => paging.PageSize(23))
                                );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
                <div class=""col-md-9 col-sm-9"" style=""border: 1px solid; border-color: black; height: 1000px"">
                    <div class=""form-group row"" style=""margin-bottom:0px"">
                        <div class=""col-md-8 col-sm-8"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Mã ĐV</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"">
                            <label class=""col-form-label col-md-2 col-sm-2"">Người tạo</label>
                            <input type=""text"" class=""form-control col-md-4 col-sm-4 text-box-hdmb"">
                        </div>
                        <div class=""col-md-4 col-sm-4"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""t"" checked><label for=""y"">Tr");
            WriteLiteral(@"ực tiếp</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""t""><label for=""y"">Ủy thác</label>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-md-8 col-sm-8"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" name=""x"" checked><label for=""y"">Mua hàng</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" name=""x""><label for=""y"">Bán hàng</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" name=""x""><label for=""y"">Mượn hàng</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" name=""x""><label for=""y"">Cho mượn</label>
                  ");
            WriteLiteral(@"          <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px "" name=""x""><label for=""y"">Khách trả</label>
                        </div>
                        <div class=""col-md-4 col-sm-4"" style=""border: 1px solid; border-color: black;text-align:center"">
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""t"" checked><label for=""y"">Giá outright</label>
                            <input type=""radio"" style=""display: inline-block; margin: 5px 10px 5px 10px"" name=""t""><label for=""y"">Giá trừ lùi</label>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">System ID</label>
                        <input type=""text"" class=""form-control col-md-3 col-sm-3 text-box-hdmb"">
                        <div class=""col-md-7 col-sm-7"" style=""text-align:left"">
                            <input type=""che");
            WriteLiteral(@"ckbox"" style=""margin-right:10px;margin-left:10px""><label class=""col-form-label"">Hợp đồng bắt buộc có PAKD</label>
                            <input type=""checkbox"" style=""margin-right: 10px; margin-left: 10px""><label class=""col-form-label"">Hợp đồng nợ khó đòi</label>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Ref</label>
                        <input type=""text"" class=""form-control col-md-3 col-sm-3 text-box-hdmb"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Số hợp đồng</label>
                        <input type=""text"" class=""form-control col-md-5 col-sm-5 text-box-hdmb"">
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Tiền tệ</label>
                        <input type=""text"" class=""form-control col-md-3 col-sm-3 text-b");
            WriteLiteral(@"ox-hdmb"">
                        <input type=""text"" class=""form-control col-md-7 col-sm-7 text-box-hdmb"">
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Khách hàng</label>
                        <input type=""text"" class=""form-control col-md-3 col-sm-3 text-box-hdmb"">
                        <input type=""text"" class=""form-control col-md-7 col-sm-7 text-box-hdmb"">
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">INT Ký</label>
                        <input type=""text"" class=""form-control col-md-3 col-sm-3 text-box-hdmb"">
                        <input type=""text"" class=""form-control col-md-7 col-sm-7 text-box-hdmb"">
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Khách ký</label>
              ");
            WriteLiteral(@"          <input type=""text"" class=""form-control col-md-3 col-sm-3 text-box-hdmb"">
                        <input type=""text"" class=""form-control col-md-7 col-sm-7 text-box-hdmb"">
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-form-label col-md-2 col-sm-2"">Thanh toán</label>
                        <input type=""text"" class=""form-control col-md-3 col-sm-3 text-box-hdmb"">
                        <input type=""text"" class=""form-control col-md-7 col-sm-7 text-box-hdmb"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
