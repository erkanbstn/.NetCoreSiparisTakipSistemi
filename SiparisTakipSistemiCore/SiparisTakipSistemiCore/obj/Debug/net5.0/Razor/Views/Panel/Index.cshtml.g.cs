#pragma checksum "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc5a46d49ae0396b43a8030d202831a1bd219e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_Index), @"mvc.1.0.view", @"/Views/Panel/Index.cshtml")]
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
#line 1 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\_ViewImports.cshtml"
using SiparisTakipSistemiCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\_ViewImports.cshtml"
using SiparisTakipSistemiCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
using SiparisTakipSistemiCore.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc5a46d49ae0396b43a8030d202831a1bd219e1c", @"/Views/Panel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"783dacec858d9e8307b10a111e2d979dcfb2b464", @"/Views/_ViewImports.cshtml")]
    public class Views_Panel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Musteri>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Panel/MusteriEkle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
  
    ViewData["Title"] = "Musteri Listesi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center;color:orange"">Müşteri Listesi</h1>
<br />
<br />

<table class=""table table-hover"">
    <tr>
        <th>
            ID
        </th>
        <th>
            Müşteri
        </th>
        <th>
            Email
        </th>
        <th>
            Telefon
        </th>
        <th>
            Sil
        </th>
        <th>
            Düzenle
        </th>
    </tr>
");
#nullable restore
#line 33 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 37 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
   Write(i.MusteriID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 40 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
   Write(i.MusteriAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 43 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
   Write(i.MusteriEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 46 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
   Write(i.MusteriTelefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc5a46d49ae0396b43a8030d202831a1bd219e1c7208", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 849, "~/Panel/MusteriSil/", 849, 19, true);
#nullable restore
#line 49 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
AddHtmlAttributeValue("", 868, i.MusteriID, 868, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc5a46d49ae0396b43a8030d202831a1bd219e1c8903", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 952, "~/Panel/MusteriGuncelle/", 952, 24, true);
#nullable restore
#line 52 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
AddHtmlAttributeValue("", 976, i.MusteriID, 976, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 55 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc5a46d49ae0396b43a8030d202831a1bd219e1c10856", async() => {
                WriteLiteral("Yeni Müşteri Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Musteri>> Html { get; private set; }
    }
}
#pragma warning restore 1591