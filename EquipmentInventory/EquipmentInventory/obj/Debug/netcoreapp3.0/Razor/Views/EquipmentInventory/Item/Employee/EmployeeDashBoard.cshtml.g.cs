#pragma checksum "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\EquipmentInventory\Item\Employee\EmployeeDashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d563c3b3eec917d54c99879b4a43359479387f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EquipmentInventory_Item_Employee_EmployeeDashBoard), @"mvc.1.0.view", @"/Views/EquipmentInventory/Item/Employee/EmployeeDashBoard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d563c3b3eec917d54c99879b4a43359479387f0", @"/Views/EquipmentInventory/Item/Employee/EmployeeDashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e7a5362560f99a9627ff310bf76e7e6808f5ed", @"/Views/_ViewImports.cshtml")]
    public class Views_EquipmentInventory_Item_Employee_EmployeeDashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ItemTab/Employee/EmployeeDashBoard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\EquipmentInventory\Item\Employee\EmployeeDashBoard.cshtml"
  
    Layout = "~/Views/EquipmentInventory/Item/_ItemTabLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d563c3b3eec917d54c99879b4a43359479387f04463", async() => {
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
    <h4>Employee</h4>
</div>

<div class=""index_cardArea"">

    <div class=""menu_card grid-col1 grid_row1"">
        <div class=""menu_card_div1 grid-col1 grid_row1"">
            <div class=""menu_card_div1_1"" style="" background-image: url('../Resources/BorrowItem_icon.png'); "">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Borrow Item</h6>
        </div>

    </div>

    <div class=""menu_card grid_col2 grid_row1"">
        <div class=""menu_card_div1 sgrid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('../Resources/ReturnItem_Icon.png');"">
            </div>
        </div>
        <div class=""menu_card_div");
            WriteLiteral(@"2 grid_col1 grid_row2"">
            <h6>Return Item</h6>
        </div>

    </div>

    <div class=""menu_card grid_col3 grid_row1"">
        <div class=""menu_card_div1 sgrid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('../Resources/DamageItem_Icon.png');"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Damage Item</h6>
        </div>

    </div>

    <div class=""menu_card grid_col4 grid_row1"">
        <div class=""menu_card_div1 sgrid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('../Resources/LostItem_Icon.png');"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Lost Item</h6>
        </div>

    </div>




</div>");
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
