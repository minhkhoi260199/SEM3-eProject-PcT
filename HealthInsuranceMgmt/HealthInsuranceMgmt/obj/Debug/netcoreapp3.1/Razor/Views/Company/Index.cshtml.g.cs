#pragma checksum "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df74b87a4d8618bd1842b6b1af1bc578408d590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df74b87a4d8618bd1842b6b1af1bc578408d590", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "medical", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
   
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"p-t-20\">\n    <div class=\"container\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df74b87a4d8618bd1842b6b1af1bc578408d5904852", async() => {
                WriteLiteral("\n            <div");
                BeginWriteAttribute("style", " style=\"", 233, "\"", 241, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-group row"">
                <div class=""col-md-3"" style=""text-align: center;"">
                    <label>Search Company: </label>
                </div>
                <div class=""col-md-4"">
                    <input type=""text"" name=""keyword""");
                BeginWriteAttribute("value", " value=\"", 501, "\"", 525, 1);
#nullable restore
#line 13 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
WriteAttributeValue("", 509, ViewBag.keyword, 509, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  class=\"form-control\" />\n                </div>\n                <div class=\"col-md-2\">\n                    <button type=\"submit\" class=\"btn btn-success\">Search</button>\n                </div>\n                <div class=\"col-md-2\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df74b87a4d8618bd1842b6b1af1bc578408d5906229", async() => {
                    WriteLiteral("\n                    <button type=\"button\" class=\"btn btn-info\">Show All</button>\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"        
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""table-responsive table-responsive-data2"">
                    <table class=""table table-borderless table-data3"">
                        <thead>
                            <tr>
                                <th>No</th>
                                <th>Company Name</th>
                                <th>Address</th>
                                <th>Phone Number</th>
                                <th>Website</th>
                                <th>Choose</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 40 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                               var i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                             foreach (var company in ViewBag.companies)
                            {
                                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"tr-shadow\">\n                                    <td><span>");
#nullable restore
#line 45 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                    <td>");
#nullable restore
#line 46 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                                   Write(company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 47 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                                   Write(company.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 48 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                                   Write(company.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2232, "\"", 2258, 1);
#nullable restore
#line 50 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
WriteAttributeValue("", 2239, company.CompanyUrl, 2239, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                                                                 Write(company.CompanyUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                                    <td>\n                                        <div class=\"table-data-feature\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df74b87a4d8618bd1842b6b1af1bc578408d59013081", async() => {
                WriteLiteral(@"
                                            <button class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Choose this company"">
                                                <i class=""zmdi zmdi-mail-send""> </i>
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                                                                                         WriteLiteral(company.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 61 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Company/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"spacer\"></tr>\n                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n\n");
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
