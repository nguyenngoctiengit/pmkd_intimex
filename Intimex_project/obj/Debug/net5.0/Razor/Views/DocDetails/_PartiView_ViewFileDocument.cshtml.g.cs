#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\_PartiView_ViewFileDocument.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e31769d5c58de2e3e04a7730e5ecd80919445c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocDetails__PartiView_ViewFileDocument), @"mvc.1.0.view", @"/Views/DocDetails/_PartiView_ViewFileDocument.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e31769d5c58de2e3e04a7730e5ecd80919445c", @"/Views/DocDetails/_PartiView_ViewFileDocument.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_DocDetails__PartiView_ViewFileDocument : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-body\">\r\n    ");
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\DocDetails\_PartiView_ViewFileDocument.cshtml"
Write(Html.DevExtreme().SelectBox().OnSelectionChanged("SelectedImageDisplay").DataSource(ViewBag.ListImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<div class=""modal fade"" id=""Popup_img"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <img id=""img_id"" style=""width:100%;height:100%"">
                <div id=""text_Popup_img"">Đây là file Tif. Không thể xem. Hãy xem file trong thư mục Download.</div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" onclick=""Close_Popup_img()"">Close</button>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"
<div class=""modal-footer"">

</div>
<script>
    function Close_Popup_img() {
        $(""#Popup_img"").modal(""hide"");
    }
    function EOffice(fileName) {
        var DocId = document.getElementById(""DocId"").value;
        $.post('/DocProcess/EOffice', { 'fileName': fileName, 'DocId': DocId }, function (response) {
            $.notify(response, ""success"");
            $(""#Popup_img"").modal(""hide"");
        })
    }
    function Reply(fileName) {
        var DocId = document.getElementById(""DocId"").value;
        $.post('/DocProcess/Reply', { 'fileName': fileName, 'DocId': DocId }, function (response) {
            $.notify(response, ""success"");
            $(""#Popup_img"").modal(""hide"");
        })
    }
    function Send(fileName) {
        document.getElementById(""fileName"").value = fileName;
        $(""#choose_receiver"").modal(""show"");
    }
    function getDataGridInstance1() {
        return $(""#dsnv"").dxDataGrid(""instance"");
    }
    function choose_receiver() {
        g");
            WriteLiteral(@"etDataGridInstance1().getSelectedRowsData().done(function (rowData) {
            var array = []
            var DocId = document.getElementById(""DocId"").value;
            var fileName = document.getElementById(""fileName"").value
            rowData.forEach(element => { array.push(element.UserName1) })
            for (var i = 0; i < array.length; i++) {
                if (array.length != 0) {
                    $.ajax({
                        traditional: true,
                        dataType: 'json',
                        type: 'POST',
                        url: '/DocProcess/SendToReceiver',
                        data: { fileName: fileName, DocId: DocId, array: array },
                        success: function (data) {
                            $(""#choose_receiver"").modal(""hide"");
                            $.notify(data, ""success"");
                        },
                        error: function () {
                            $.notify(""Something went wrong"", ""error"");
");
            WriteLiteral(@"                        }
                    })
                }
                else if (array_ListReciever.length == 0) {
                    $.notify(""please choose reciever!"", ""error"");
                }
            }
            $('#choose_handler_participant').modal('toggle');
        })
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