#pragma checksum "C:\Users\Bugrahan\source\repos\CV.WebApplication\WebUI\Views\Shared\Components\CertificationComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807fb9e10354388302ba78ae4072c95c575cc414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CertificationComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CertificationComponent/Default.cshtml")]
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
#line 1 "C:\Users\Bugrahan\source\repos\CV.WebApplication\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807fb9e10354388302ba78ae4072c95c575cc414", @"/Views/Shared/Components/CertificationComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1ff0851eae5c75daee8425e24ec616310a8cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CertificationComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CV.DTO.DTOs.CertificationDtos.CertificationListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"resume-section\" id=\"awards\">\n    <div class=\"resume-section-content\">\n        <h2 class=\"mb-5\">Awards & Certifications</h2>\n        <ul class=\"fa-ul mb-0\">\n");
#nullable restore
#line 6 "C:\Users\Bugrahan\source\repos\CV.WebApplication\WebUI\Views\Shared\Components\CertificationComponent\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\n                    <span class=\"fa-li\"><i class=\"fas fa-trophy text-warning\"></i></span>\n                    ");
#nullable restore
#line 10 "C:\Users\Bugrahan\source\repos\CV.WebApplication\WebUI\Views\Shared\Components\CertificationComponent\Default.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </li>\n");
#nullable restore
#line 12 "C:\Users\Bugrahan\source\repos\CV.WebApplication\WebUI\Views\Shared\Components\CertificationComponent\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </ul>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CV.DTO.DTOs.CertificationDtos.CertificationListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
