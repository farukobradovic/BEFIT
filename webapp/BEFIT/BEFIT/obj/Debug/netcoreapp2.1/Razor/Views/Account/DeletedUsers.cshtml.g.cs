#pragma checksum "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b081c95dbe9597b4b734a7f964091e1193ed03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_DeletedUsers), @"mvc.1.0.view", @"/Views/Account/DeletedUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/DeletedUsers.cshtml", typeof(AspNetCore.Views_Account_DeletedUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b081c95dbe9597b4b734a7f964091e1193ed03", @"/Views/Account/DeletedUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524770de368ca502fce984a7a9a5ed5013719f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_DeletedUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeletedUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
  
    ViewBag.Title = "Pregled obrisanih korisnika na sistemu";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(129, 54, true);
            WriteLiteral("    <div class=\"container-no-flex\">\r\n       \r\n        ");
            EndContext();
            BeginContext(183, 841, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045318dfe8e54ec69ceb6a565aeea966", async() => {
                BeginContext(203, 405, true);
                WriteLiteral(@"
            <h1 style=""font-weight:400; text-align:center; margin-bottom:3rem;"">Obrisani korisnici</h1>
            <table class=""products-table"">
                <tr>
                    <th>Ime i prezime</th>
                    <th>Email</th>
                    <th>Uloga</th>
                    <th>Datum kreiranja</th>
                    <th>Datum brisanja</th>

                </tr>
");
                EndContext();
#line 22 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                 foreach (var u in @Model)
                {

#line default
#line hidden
                BeginContext(671, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(726, 6, false);
#line 25 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                       Write(u.Name);

#line default
#line hidden
                EndContext();
                BeginContext(732, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(734, 10, false);
#line 25 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                               Write(u.Lastname);

#line default
#line hidden
                EndContext();
                BeginContext(744, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(780, 7, false);
#line 26 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                       Write(u.Email);

#line default
#line hidden
                EndContext();
                BeginContext(787, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(823, 10, false);
#line 27 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                       Write(u.RoleName);

#line default
#line hidden
                EndContext();
                BeginContext(833, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(869, 16, false);
#line 28 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                       Write(u.DateRegistered);

#line default
#line hidden
                EndContext();
                BeginContext(885, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(921, 13, false);
#line 29 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                       Write(u.DateDeleted);

#line default
#line hidden
                EndContext();
                BeginContext(934, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 31 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
                }

#line default
#line hidden
                BeginContext(987, 30, true);
                WriteLiteral("            </table>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1024, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 35 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"


}
else
{

#line default
#line hidden
            BeginContext(1054, 63, true);
            WriteLiteral("    <p>Trenutno ne postoje obrisani korisnici na sistemu.</p>\r\n");
            EndContext();
#line 41 "C:\Users\Faruk\source\repos\seminarski_rad\webapp\BEFIT\BEFIT\Views\Account\DeletedUsers.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeletedUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591