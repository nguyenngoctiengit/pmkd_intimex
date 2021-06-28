#pragma checksum "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\bangtinh\SpreadsheetBT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8cf256800b95877085e5aa087c80b8edde36fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kho_bangtinh_SpreadsheetBT), @"mvc.1.0.view", @"/Views/Kho/bangtinh/SpreadsheetBT.cshtml")]
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
#line 2 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using pmkd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8cf256800b95877085e5aa087c80b8edde36fe", @"/Views/Kho/bangtinh/SpreadsheetBT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb5032fc71ad384771cb309a8213e095deb506", @"/Views/_ViewImports.cshtml")]
    public class Views_Kho_bangtinh_SpreadsheetBT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpreadsheetViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Máy tính\pmkd_intimex\pmkd\Views\Kho\bangtinh\SpreadsheetBT.cshtml"
Write(Html.DevExpress()
        .Spreadsheet("spreadsheet")
        .Height("500px")
        .Width("100%")
        .Ribbon(r => r
            .Visible(true)
            .ActiveTabIndex(0)
            .Tabs(tabs => {
                tabs.Clear();
                tabs.Add()
                        .Title("File")
                            .Items(items =>
                            {
                                items.AddButton()
                                        .Text("Save")
                                        .CommandName("save")
                                        .ShowText(true)
                                        .Icon("save");
                                items.AddButton()
                                        .Text("Download as XLSX")
                                        .CommandName("download")
                                        .ShowText(true)
                                        .Icon("download");
                                items.AddPrintItem().BeginGroup(true);
                            });
                tabs.AddHomeTab()
                        .Items(items =>
                        {
                            items.Clear();
                            items.AddUndoItem();
                            items.AddRedoItem();
                            items.AddCutItem();
                            items.AddCopyItem();
                            items.AddPasteItem();
                        });
                tabs.AddInsertTab();

                tabs.AddFormulasTab();

                tabs.AddDataTab();

                tabs.AddReviewTab();

                tabs.AddViewTab();
            })
        )
        .ClientSideEvents(events => {
            events.OnCustomCommandExecuted("onCustomCommandExecuted");

        })
        .ConfirmOnLosingChanges(confirm => confirm.Enabled(false))
        .DocumentRequestHandlerUrl(Url.Action("DxDocRequest"))
        .Open(Model.DocumentId, Model.DocumentFormat, Model.ContentAccessorByBytes)
    );

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpreadsheetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
