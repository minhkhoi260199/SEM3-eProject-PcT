#pragma checksum "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1565adeabfde79ebebdb236b32728cff75c93f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_Index), @"mvc.1.0.view", @"/Views/Policy/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1565adeabfde79ebebdb236b32728cff75c93f29", @"/Views/Policy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Policy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 7 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
 foreach (var policy in ViewBag.policies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6\">\r\n\r\n        <div class=\"card\">\r\n\r\n            <div class=\"card-header\">\r\n\r\n                <strong class=\"card-title\">");
#nullable restore
#line 15 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                      Write(policy.PolicyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"alert alert-success\" role=\"alert\">\r\n\r\n                    <h4 class=\"alert-heading\">Policies</h4>\r\n                    <p>\r\n                        ");
#nullable restore
#line 22 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                   Write(policy.PolicyDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <hr>\r\n                    <p class=\"mb-0\">\r\n                        <a>Amount: </a> ");
#nullable restore
#line 26 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                   Write(policy.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        <a>Emi: </a> ");
#nullable restore
#line 27 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                Write(policy.Emi);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        <a>Duration(months): </a> ");
#nullable restore
#line 28 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                             Write(policy.PolicyDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1565adeabfde79ebebdb236b32728cff75c93f296915", async() => {
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
            WriteLiteral("\r\n            </div>\r\n         </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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