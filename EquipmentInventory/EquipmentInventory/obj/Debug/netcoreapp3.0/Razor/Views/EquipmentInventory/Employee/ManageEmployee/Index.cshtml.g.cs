#pragma checksum "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\EquipmentInventory\Employee\ManageEmployee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445c643272ee8f66f2db8cce195e4e131a844fc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EquipmentInventory_Employee_ManageEmployee_Index), @"mvc.1.0.view", @"/Views/EquipmentInventory/Employee/ManageEmployee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445c643272ee8f66f2db8cce195e4e131a844fc4", @"/Views/EquipmentInventory/Employee/ManageEmployee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e7a5362560f99a9627ff310bf76e7e6808f5ed", @"/Views/_ViewImports.cshtml")]
    public class Views_EquipmentInventory_Employee_ManageEmployee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/EmployeeTab/ManageEmployee/EmployeeMangementDashBoard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\jasarvn\source\repos\EquipmentInventorySystem\EquipmentInventory\EquipmentInventory\Views\EquipmentInventory\Employee\ManageEmployee\Index.cshtml"
  
    Layout = "~/Views/EquipmentInventory/Employee/_EmployeeTabLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "445c643272ee8f66f2db8cce195e4e131a844fc44443", async() => {
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
    .menu_card:hover {
        background: #7ca9fc;
    }

    .menu_card:hover h6 {
        background: #7ca9fc;
        color:white;
        font-size: 14pt;
    }
</style>

<div class=""index_headerArea"">
    <h4 >Employee Management</h4>
</div>

<div class=""index_cardArea"">

    <div id=""card"" class=""menu_card grid-col1 grid_row1"">
        <div class=""menu_card_div1 grid-col1 grid_row1"">
            <div class=""menu_card_div1_1"" style="" background-image: url('Resources/user_Icon1.png'); "">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Register Employee</h6>
        </div>

    </div>

    <div class=""menu_card grid_col2 grid_row1"">
        <div class=""menu_card_div1 sgrid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""        background-image: url('Resources/UserUpdate_Icon1.png');
"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
        ");
            WriteLiteral(@"    <h6>Update Information</h6>
        </div>

    </div>

    <div class=""menu_card grid_col3 grid_row1"" >
        <div class=""menu_card_div1 grid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('Resources/UserRemove_Icon1.png');"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Remove Employee</h6>
        </div>

    </div>

    <div class=""menu_card grid_col4 grid_row1"">
        <div class=""menu_card_div1 grid_col1 grid_row1"">
            <div class=""menu_card_div1_1"" style=""background-image: url('Resources/UserReinstate_Icon1.png');"">
            </div>
        </div>
        <div class=""menu_card_div2 grid_col1 grid_row2"">
            <h6>Re-Instate Employee</h6>
        </div>

    </div>
</div>

<!-- <div style=""-ms-grid-column: 1; -ms-grid-row: 1;
          display: grid;
          grid-template-columns: 230px 230px 230px 230px;
          grid-template-rows: 250px 250px 2");
            WriteLiteral(@"50px;
          padding-left: 20px;padding-top: 50px;

          display: -ms-grid;
          -ms-grid-columns:  200px 200px 200px 200px;
          -ms-grid-rows: 250px 250px 250px;
          "">
     <div style=""background: yellow;-ms-grid-column: 1;-ms-grid-row: 1;margin-right: 30px;""></div>
     <div style=""background: yellow;-ms-grid-column: 2;-ms-grid-row: 1;margin-right: 30px;""></div>
     <div style=""background: yellow;-ms-grid-column: 3;-ms-grid-row: 1;margin-right: 30px;""></div>
     <div style=""background: yellow;-ms-grid-column: 4;-ms-grid-row: 1;margin-right: 30px;""></div>

 </div>-->
<!--   <div id=""jsGrid""></div>
<script>
    var clients = [
        { ""Name"": ""Otto Clay"", ""Age"": 25, ""Country"": 1, ""Address"": ""Ap #897-1459 Quam Avenue"", ""Married"": false },
        { ""Name"": ""Connor Johnston"", ""Age"": 45, ""Country"": 2, ""Address"": ""Ap #370-4647 Dis Av."", ""Married"": true },
        { ""Name"": ""Lacey Hess"", ""Age"": 29, ""Country"": 3, ""Address"": ""Ap #365-8835 Integer St."", ""Married"": false");
            WriteLiteral(@" },
        { ""Name"": ""Timothy Henson"", ""Age"": 56, ""Country"": 1, ""Address"": ""911-5143 Luctus Ave"", ""Married"": true },
        { ""Name"": ""Ramona Benton"", ""Age"": 32, ""Country"": 3, ""Address"": ""Ap #614-689 Vehicula Street"", ""Married"": false }
    ];

    var countries = [
        { Name: """", Id: 0 },
        { Name: ""United States"", Id: 1 },
        { Name: ""Canada"", Id: 2 },
        { Name: ""United Kingdom"", Id: 3 }
    ];

    $(""#jsGrid"").jsGrid({
        width: ""100%"",
        height: ""400px"",

        inserting: true,
        editing: true,
        sorting: true,
        paging: true,

        data: clients,

        fields: [
            { name: ""Name"", type: ""text"", width: 150, validate: ""required"" },
            { name: ""Age"", type: ""number"", width: 50 },
            { name: ""Address"", type: ""text"", width: 200 },
            { name: ""Country"", type: ""select"", items: countries, valueField: ""Id"", textField: ""Name"" },
            { name: ""Married"", type: ""checkbox"", title: ""Is Mar");
            WriteLiteral("ried\", sorting: false },\r\n            { type: \"control\" }\r\n        ]\r\n    });\r\n</script>-->\r\n");
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
