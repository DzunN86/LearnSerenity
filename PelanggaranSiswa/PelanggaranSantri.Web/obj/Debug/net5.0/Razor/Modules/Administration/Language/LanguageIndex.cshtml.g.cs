#pragma checksum "/home/anyaspyx/Documents/SantriCode/PelanggaranSiswa/PelanggaranSantri.Web/Modules/Administration/Language/LanguageIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659cff5ff5afc80c8f42cff45be900f27284a383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Administration_Language_LanguageIndex), @"mvc.1.0.view", @"/Modules/Administration/Language/LanguageIndex.cshtml")]
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
#line 1 "/home/anyaspyx/Documents/SantriCode/PelanggaranSiswa/PelanggaranSantri.Web/Modules/_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/anyaspyx/Documents/SantriCode/PelanggaranSiswa/PelanggaranSantri.Web/Modules/_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/anyaspyx/Documents/SantriCode/PelanggaranSiswa/PelanggaranSantri.Web/Modules/_ViewImports.cshtml"
using PelanggaranSantri;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/anyaspyx/Documents/SantriCode/PelanggaranSiswa/PelanggaranSantri.Web/Modules/_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/anyaspyx/Documents/SantriCode/PelanggaranSiswa/PelanggaranSantri.Web/Modules/_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659cff5ff5afc80c8f42cff45be900f27284a383", @"/Modules/Administration/Language/LanguageIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65bba5b78bfb2142a4307b4af64a3f9de47a40d2", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Administration_Language_LanguageIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/anyaspyx/Documents/SantriCode/PelanggaranSiswa/PelanggaranSantri.Web/Modules/Administration/Language/LanguageIndex.cshtml"
  
    ViewData["Title"] = Localizer.Get("Db.Administration.Language.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new PelanggaranSantri.Administration.LanguageGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
