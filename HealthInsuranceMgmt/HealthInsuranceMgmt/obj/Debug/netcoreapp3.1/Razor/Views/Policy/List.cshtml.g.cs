#pragma checksum "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1be8f3e143954744372be266161abb9fda03cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_List), @"mvc.1.0.view", @"/Views/Policy/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1be8f3e143954744372be266161abb9fda03cd", @"/Views/Policy/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Policy_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive table-responsive-data2"">
    <table class=""table table-data2"">
        <thead>
            <tr>
                <th>No</th>
                <th>Policy Name</th>
                <th>Description</th>
                <th>Hospital</th>
                <th>Amount</th>
                <th>Emi</th>
                <th>Duration</th>
                <th>Mecical</th>
                <th>Insurance Company</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
               var i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
             foreach (var policy in ViewBag.policies)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><span>");
#nullable restore
#line 29 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td>");
#nullable restore
#line 30 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.PolicyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.PolicyDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.Medical.Hospital.HospitalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.Emi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.PolicyDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.Medical.MedicalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
                   Write(policy.Medical.Company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b1be8f3e143954744372be266161abb9fda03cd8002", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "E:\Aptech_HK3\9_eProject\HealthInsuranceMgmt2\HealthInsuranceMgmt\Views\Policy\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"spacer\"></tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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