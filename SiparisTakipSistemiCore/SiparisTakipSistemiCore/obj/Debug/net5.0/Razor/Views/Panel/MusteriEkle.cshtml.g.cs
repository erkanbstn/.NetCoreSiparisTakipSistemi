#pragma checksum "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\MusteriEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7ac0854398a68a1f67276e6c91b7830c74a3a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_MusteriEkle), @"mvc.1.0.view", @"/Views/Panel/MusteriEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7ac0854398a68a1f67276e6c91b7830c74a3a2", @"/Views/Panel/MusteriEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"783dacec858d9e8307b10a111e2d979dcfb2b464", @"/Views/_ViewImports.cshtml")]
    public class Views_Panel_MusteriEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\MusteriEkle.cshtml"
  
    ViewData["Title"] = "Yeni Musteri";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center;color:orange\">Yeni Müşteri Ekle</h1>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\MusteriEkle.cshtml"
 if (ViewBag.kayit != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 12 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\MusteriEkle.cshtml"
                                Write(ViewBag.kayit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <br />\r\n");
#nullable restore
#line 14 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\MusteriEkle.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\MusteriEkle.cshtml"
 using (Html.BeginForm("MusteriEkle", "Panel", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <label>Müşteri Bilgisi</label>
    <input class=""form-control"" name=""MusteriAd"" placeholder=""Müşteri Giriniz"" />
    <br />
    <label>Müşteri Email</label>
    <input class=""form-control"" name=""MusteriEmail"" placeholder=""Email Giriniz"" required />
    <br />
    <label>Müşteri Telefon</label>
    <input class=""form-control"" name=""MusteriTelefon"" placeholder=""Telefon Giriniz"" required />
    <br />
    <label>Müşteri Parola</label>
    <input class=""form-control"" name=""MusteriParola"" placeholder=""Parola Giriniz"" required />
    <br />
    <input type=""submit"" value=""Müşteriyi Kaydet"" class=""btn btn-secondary"" required />
");
#nullable restore
#line 30 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\MusteriEkle.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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