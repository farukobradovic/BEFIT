#pragma checksum "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "737be83f3e4859d93801cc99bec87574c3b2f5e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_List), @"mvc.1.0.view", @"/Views/Statistics/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Statistics/List.cshtml", typeof(AspNetCore.Views_Statistics_List))]
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
#line 1 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\_ViewImports.cshtml"
using BEFIT;

#line default
#line hidden
#line 2 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\_ViewImports.cshtml"
using BEFIT.Models;

#line default
#line hidden
#line 3 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\_ViewImports.cshtml"
using BEFIT.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"737be83f3e4859d93801cc99bec87574c3b2f5e7", @"/Views/Statistics/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524770de368ca502fce984a7a9a5ed5013719f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Statistic>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete-product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Da li ste sigurni da želite obrisati BMI test?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
  
    ViewBag.Title = "Pregled svih testova";

#line default
#line hidden
            BeginContext(87, 138, true);
            WriteLiteral("\r\n<div class=\"container-no-flex\">\r\n    <h1 style=\"font-weight: 400; text-align: center; margin-bottom: 3rem;\">Uvid u statistiku</h1>\r\n    ");
            EndContext();
            BeginContext(225, 959, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb735dffd0c04442982cc78e5db7078c", async() => {
                BeginContext(245, 335, true);
                WriteLiteral(@"
        <table class=""products-table"">
            <tr>
                <th>BMI</th>
                <th>Ime i prezime</th>
                <th>Visina</th>
                <th>Težina</th>
                <th>Datum mjerenja</th>
                <th style=""width: 15%;""><i class=""fas fa-trash-alt""></i></th>
            </tr>
");
                EndContext();
#line 20 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
             foreach (var m in Model)
            {

#line default
#line hidden
                BeginContext(634, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(681, 29, false);
#line 23 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
                   Write(m.CalculatedBMI.ToString("F"));

#line default
#line hidden
                EndContext();
                BeginContext(710, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(742, 16, false);
#line 24 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
                   Write(m.User.Firstname);

#line default
#line hidden
                EndContext();
                BeginContext(758, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(760, 15, false);
#line 24 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
                                     Write(m.User.Lastname);

#line default
#line hidden
                EndContext();
                BeginContext(775, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(807, 8, false);
#line 25 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
                   Write(m.Height);

#line default
#line hidden
                EndContext();
                BeginContext(815, 33, true);
                WriteLiteral(" m</td>\r\n                    <td>");
                EndContext();
                BeginContext(849, 15, false);
#line 26 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
                   Write(m.WeightInKilos);

#line default
#line hidden
                EndContext();
                BeginContext(864, 34, true);
                WriteLiteral(" kg</td>\r\n                    <td>");
                EndContext();
                BeginContext(899, 16, false);
#line 27 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
                   Write(m.DateCalculated);

#line default
#line hidden
                EndContext();
                BeginContext(915, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(946, 164, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a037ec02034f439da51b0b2fd4821b", async() => {
                    BeginContext(1095, 6, true);
                    WriteLiteral("Obriši");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
                                                                      WriteLiteral(m.StatisticID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1110, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 30 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Statistics\List.cshtml"
            }

#line default
#line hidden
                BeginContext(1155, 22, true);
                WriteLiteral("        </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1184, 10, true);
            WriteLiteral("\r\n\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Statistic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
