#pragma checksum "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Templates\BlankTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512a66f03f195eb645309a0a5cb522ba2361a180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Templates_BlankTemplate), @"mvc.1.0.view", @"/Views/Templates/BlankTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Templates/BlankTemplate.cshtml", typeof(AspNetCore.Views_Templates_BlankTemplate))]
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
#line 1 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\_ViewImports.cshtml"
using Website;

#line default
#line hidden
#line 2 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\_ViewImports.cshtml"
using Website.Models;

#line default
#line hidden
#line 1 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Templates\BlankTemplate.cshtml"
using Agility.Web;

#line default
#line hidden
#line 2 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Templates\BlankTemplate.cshtml"
using Agility.Web.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512a66f03f195eb645309a0a5cb522ba2361a180", @"/Views/Templates/BlankTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Templates_BlankTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 15, true);
            WriteLiteral("\r\n<section>\t\r\n\t");
            EndContext();
            BeginContext(62, 52, false);
#line 5 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Templates\BlankTemplate.cshtml"
Write(await Component.RenderContentZone("MainContentZone"));

#line default
#line hidden
            EndContext();
            BeginContext(114, 15, true);
            WriteLiteral("\t\t\t\r\n</section>");
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
