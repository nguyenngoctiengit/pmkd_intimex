#pragma checksum "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Bangtinh\SpreadsheetBT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf4ac6f2fd446cb79203c455266f7667142c342e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bangtinh_SpreadsheetBT), @"mvc.1.0.view", @"/Views/Bangtinh/SpreadsheetBT.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf4ac6f2fd446cb79203c455266f7667142c342e", @"/Views/Bangtinh/SpreadsheetBT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573e96834c164d2bbf2071589b32bff03f054d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Bangtinh_SpreadsheetBT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel.SpreadsheetViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\project_intimex\Intimex_project\Views\Bangtinh\SpreadsheetBT.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel.SpreadsheetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
