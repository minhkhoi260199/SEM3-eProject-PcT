#pragma checksum "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Areas/Admin/Views/Companies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69eea3f046fd958433318f0c9faf163921f53200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Companies_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Companies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69eea3f046fd958433318f0c9faf163921f53200", @"/Areas/Admin/Views/Companies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Companies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Admin/companies/companiesList.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Areas/Admin/Views/Companies/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #companiesTable tr th {
        color: white;
        font-weight: bold;
        font-size: 15px
    }

    #companiesTable tbody tr td {
        color: black;
    }
</style>
<div style=""margin-left:10px; margin-right: 10px"">
    <div style=""text-align:center; margin-bottom:10px; margin-top:5px"">
        <button id=""createNew"" type=""button"" class=""btn btn-success"">Create New Company</button>
    </div>
    <div");
            BeginWriteAttribute("style", " style=\"", 524, "\"", 532, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-group row\">\n        <div class=\"col-md-3\" style=\"text-align: center;\">\n            <label>Search Company\'s Name: </label>\n        </div>\n        <div class=\"col-md-4\">\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 744, "\"", 752, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""searchCompanyName"" class=""form-control"" />
        </div>
        <div class=""col-md-2"">
            <button type=""button"" id=""searchBtn"" class=""btn btn-success"">Search</button>
        </div>
        <div class=""col-md-2"">
            <button type=""button"" id=""showAll"" class=""btn btn-info"">Show All</button>
        </div>
    </div>
    <div class=""table-responsive table-responsive-data2"" style=""text-align:center"">
        <table class=""table table-data2"" id=""companiesTable"">
            <thead style=""background-color:black"">
                <tr>
                    <th>
                        Index
                    </th>
                    <th>
                        Company's Name
                    </th>
                    <th>
                        Address
                    </th>
                    <th>
                        Phone
                    </th>
                    <th>
                        Url
                    </th>
                    <th>
                        Fu");
            WriteLiteral(@"nction Buttons
                    </th>
                </tr>
            </thead>
            <tbody id=""companiesTableBody"">
            </tbody>
        </table>
    </div>
    <div style=""margin-top: 10px"">
        <button type=""button"" class=""btn btn-success"" id=""backBtn"">Back</button>
        <span style=""margin-left: 10px; margin-right: 10px"" id=""showPage"">1/1</span>
        <button type=""button"" class=""btn btn-success"" id=""nextBtn"">Next</button>
        <input type=""text"" style=""display:none"" id=""curPage"" value=""1"" />
        <input type=""text"" style=""display:none"" id=""totalPage"" value=""1"" />
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69eea3f046fd958433318f0c9faf163921f532006211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
