#pragma checksum "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\EquipmentInventory\Settings\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df1fb6284819fbb916d43db4b61bdd64a877ff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EquipmentInventory_Settings_Department_Index), @"mvc.1.0.view", @"/Views/EquipmentInventory/Settings/Department/Index.cshtml")]
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
#line 1 "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\_ViewImports.cshtml"
using EquipmentInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\_ViewImports.cshtml"
using EquipmentInventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df1fb6284819fbb916d43db4b61bdd64a877ff0", @"/Views/EquipmentInventory/Settings/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e7a5362560f99a9627ff310bf76e7e6808f5ed", @"/Views/_ViewImports.cshtml")]
    public class Views_EquipmentInventory_Settings_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/SettingsTab/Department/DepartmentDashBoard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\EquipmentInventory\Settings\Department\Index.cshtml"
  
    Layout = "~/Views/EquipmentInventory/Settings/_SettingsTabLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0df1fb6284819fbb916d43db4b61bdd64a877ff04443", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    .footer_logo {
        background-repeat: no-repeat, repeat;
        background-size: 25%;
        background-position: left center;
        background-image: url('../Resources/logo3.png');
    }
</style>

<div class=""index_headerArea"">
    <h4>Department</h4>
</div>

<div class=""index_cardArea"">

    <div class=""menu_card grid-col1 grid_row1"">
        <div class=""menu_card_div1 grid-col1 grid_row1"">
            <div class=""menu_card_div1_1"" style="" background-image: url('Resources/AddDepartment_icon.png'); "">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Create Department</h6>
        </div>

    </div>

    <div class=""menu_card grid_col2 grid_row1"">
        <div class=""menu_card_div1 sgrid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('Resources/Updatedepartment.png');"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">");
            WriteLiteral(@"
            <h6>Edit Department</h6>
        </div>

    </div>

    <div class=""menu_card grid_col3 grid_row1"">
        <div class=""menu_card_div1 sgrid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('Resources/removeDepartment_Icon.png');"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Deactive Department</h6>
        </div>

    </div>

    <div class=""menu_card grid_col4 grid_row1"">
        <div class=""menu_card_div1 sgrid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('Resources/Reactivate_Department_Icon.png');"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Reactive Department</h6>
        </div>

    </div>




</div>
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
