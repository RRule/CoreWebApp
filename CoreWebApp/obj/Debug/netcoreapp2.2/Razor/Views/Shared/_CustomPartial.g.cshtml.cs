#pragma checksum "C:\Users\verschui\source\repos\CoreWebApp\CoreWebApp\Views\Shared\_CustomPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "926044eeb0d1f741c3c9e3e14770728723f1b7be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CustomPartial), @"mvc.1.0.view", @"/Views/Shared/_CustomPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CustomPartial.cshtml", typeof(AspNetCore.Views_Shared__CustomPartial))]
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
#line 1 "C:\Users\verschui\source\repos\CoreWebApp\CoreWebApp\Views\_ViewImports.cshtml"
using CoreWebApp;

#line default
#line hidden
#line 2 "C:\Users\verschui\source\repos\CoreWebApp\CoreWebApp\Views\_ViewImports.cshtml"
using CoreWebApp.Models;

#line default
#line hidden
#line 1 "C:\Users\verschui\source\repos\CoreWebApp\CoreWebApp\Views\Shared\_CustomPartial.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926044eeb0d1f741c3c9e3e14770728723f1b7be", @"/Views/Shared/_CustomPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce38d043670142d3eeab9e7775e3d99906b8a926", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CustomPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 120, true);
            WriteLiteral("\r\n<div id=\"customPartial\" class=\"alert alert-success fade show\" role=\"alert\">\r\n    This is more custom content\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
