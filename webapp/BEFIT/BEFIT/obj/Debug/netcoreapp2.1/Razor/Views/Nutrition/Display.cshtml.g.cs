#pragma checksum "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c5699e14df4f69f5d2f1b057689e733e3b41ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nutrition_Display), @"mvc.1.0.view", @"/Views/Nutrition/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nutrition/Display.cshtml", typeof(AspNetCore.Views_Nutrition_Display))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c5699e14df4f69f5d2f1b057689e733e3b41ce5", @"/Views/Nutrition/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524770de368ca502fce984a7a9a5ed5013719f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Nutrition_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nutrition>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Nutrition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:1.3rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("update-article"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-nutrition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
  
    ViewBag.Title = "Plan ishrane";

#line default
#line hidden
            BeginContext(62, 39, true);
            WriteLiteral("\r\n<div class=\"container-no-flex\">\r\n    ");
            EndContext();
            BeginContext(101, 1288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfda17e2d34b41e38f629c4ae1db6b40", async() => {
                BeginContext(182, 102, true);
                WriteLiteral("\r\n        <h1>Plan ishrane</h1>\r\n        <div class=\"div-space-between\">\r\n            <p>Autor: <span>");
                EndContext();
                BeginContext(285, 22, false);
#line 10 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
                       Write(Model.Author.Firstname);

#line default
#line hidden
                EndContext();
                BeginContext(307, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(309, 21, false);
#line 10 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
                                               Write(Model.Author.Lastname);

#line default
#line hidden
                EndContext();
                BeginContext(330, 41, true);
                WriteLiteral("</span></p>\r\n            <p>Datum: <span>");
                EndContext();
                BeginContext(372, 10, false);
#line 11 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
                       Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(382, 118, true);
                WriteLiteral("</span></p>\r\n        </div>\r\n        <div class=\"nutri-plan\">\r\n            <p id=\"paragraph-n-text\">\r\n                ");
                EndContext();
                BeginContext(501, 17, false);
#line 15 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
           Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(518, 104, true);
                WriteLiteral("\r\n            </p>\r\n\r\n        </div>\r\n        \r\n        <div class=\"buttons\" style=\"margin-top:3rem;\">\r\n");
                EndContext();
#line 21 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
             if (!User.IsInRole("Clan"))
            {

#line default
#line hidden
                BeginContext(679, 430, true);
                WriteLiteral(@"                <button type=""submit"" class=""update-article"" name=""submitButton"" value=""Uredi"">
                    <i class=""fas fa-edit""></i> Uredi
                </button>
                <button class=""delete-article"" name=""submitButton"" value=""Obrisi"" onclick=""return confirm('Da li ste sigurni da želite obrisati plan ishrane?')"">
                    <i class=""fas fa-trash-alt""></i> Obriši
                </button>
");
                EndContext();
#line 29 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
            }

#line default
#line hidden
                BeginContext(1124, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(1136, 212, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63ac435ac90d4a06926c038656f6d056", async() => {
                    BeginContext(1273, 71, true);
                    WriteLiteral("\r\n                <i class=\"fas fa-download\"></i> Preuzmi\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Nutrition\Display.cshtml"
                                                                     WriteLiteral(Model.NutritionID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1348, 34, true);
                WriteLiteral("\r\n        </div>\r\n        \r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("new", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("{", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("}", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1389, 304, true);
            WriteLiteral(@"
</div>
<script type=""text/javascript"">

    document.addEventListener(""DOMContentLoaded"", function () {
        var text = document.getElementById(""paragraph-n-text"");
        var newstring = text.textContent.split('.').join('\<br>');
        text.innerHTML = newstring;



    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nutrition> Html { get; private set; }
    }
}
#pragma warning restore 1591
