#pragma checksum "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee25225100a9212241729de6ccea3216a8e6876"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Moder), @"mvc.1.0.view", @"/Views/Account/Moder.cshtml")]
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
#line 1 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\_ViewImports.cshtml"
using Kursovik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\_ViewImports.cshtml"
using Kursovik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee25225100a9212241729de6ccea3216a8e6876", @"/Views/Account/Moder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d79d372994861d2b2220dd72d241e3be3724c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Moder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kursovik.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/AddModer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "???????????????? ??????????????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">???????????????????? ????????????????????</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dee25225100a9212241729de6ccea3216a8e68764648", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <label for=""validationDefault01"">Login</label>
                            <input id=""validationDefault01"" required type=""text"" class=""form-control"" name=""Email"" placeholder=""Login"">
                        </div>
                        <div class=""col"">
                            <label for=""validationDefault02"">Password</label>
                            <input id=""validationDefault02"" required type=""text"" class=""form-control"" name=""Password"" placeholder=""Password"">
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button style=""color:white"" type=""button"" name=""Role"" value=""User"" class=""btn btn-secondary"" data-dismiss=""modal"">??????????????</button>
                    <button style=""color:white"" type=""submit"" class=""btn btn-primary"">??????????????????</button>
  ");
                WriteLiteral("              </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<div style=""width: 500px; margin:0 auto"">
    <table class=""table border-primary"">
        <thead class=""border-primary"">
            <tr>
                <td scope=""col"">#</td>
                <td scope=""col"">Email</td>
                <td scope=""col"">Password</td>
                <td scope=""col""></td>
            </tr>
        </thead>
        <tbody class=""border-primary"">
");
#nullable restore
#line 49 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
              
                int i = 1;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">");
#nullable restore
#line 55 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
                   Write(user.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 59 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
                          if (user.Email != "Admin")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2609, "\"", 2644, 2);
            WriteAttributeValue("", 2616, "/Account/DeleteUser/", 2616, 20, true);
#nullable restore
#line 61 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
WriteAttributeValue("", 2636, user.Id, 2636, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary\">?????????????? ????????????????????</a>\r\n");
#nullable restore
#line 62 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p style=\"margin:0\">???????????????? ??????????????????</p> ");
#nullable restore
#line 64 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
                                                                         }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\Moder.cshtml"
                {
                    i = i + 1;
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <button type=\"button\" style=\"float:right\" class=\"btn btn-sm btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n        ???????????????? ????????????????????\r\n    </button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kursovik.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
