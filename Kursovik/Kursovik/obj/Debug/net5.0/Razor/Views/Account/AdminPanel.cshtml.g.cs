#pragma checksum "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa247b84af363cae673c9dd2cdbac6bda181f73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AdminPanel), @"mvc.1.0.view", @"/Views/Account/AdminPanel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa247b84af363cae673c9dd2cdbac6bda181f73e", @"/Views/Account/AdminPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d79d372994861d2b2220dd72d241e3be3724c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AdminPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kursovik.Models.Messange>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Админпанель";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
   if (ViewBag.Error != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 9 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
      Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table border-primary"" style=""background-color: #00BFFF"">
    <thead class=""border-primary"">
        <tr>
            <td scope=""col"">#</td>
            <td scope=""col"">Имя</td>
            <td scope=""col"">Фамилия</td>
            <td scope=""col"">Email</td>
            <td scope=""col"">Заметка</td>
            <td scope=""col"">Статус заявки</td>
            <td scope=""col""></td>
            <td scope=""col""></td>
        </tr>
    </thead>
    <tbody class=""border-primary"" style=""background-color: #00BFFF"">
");
#nullable restore
#line 27 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
          
            int i = 1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
         foreach (var messeng in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td scope=\"row\">");
#nullable restore
#line 33 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
           Write(messeng.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
           Write(messeng.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
           Write(messeng.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
           Write(messeng.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
           Write(messeng.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1126, 2);
            WriteAttributeValue("", 1098, "/Account/Editing/", 1098, 17, true);
#nullable restore
#line 39 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
WriteAttributeValue("", 1115, messeng.Id, 1115, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary\">Редактировать</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1208, "\"", 1242, 2);
            WriteAttributeValue("", 1215, "/Account/Delete/", 1215, 16, true);
#nullable restore
#line 40 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
WriteAttributeValue("", 1231, messeng.Id, 1231, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" class=\"btn btn-primary\">Удалить</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Gashik\Desktop\Kursovik\Kursovik\Views\Account\AdminPanel.cshtml"
            {
                i = i + 1;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kursovik.Models.Messange>> Html { get; private set; }
    }
}
#pragma warning restore 1591
