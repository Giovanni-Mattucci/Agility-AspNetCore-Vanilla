#pragma checksum "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Modules\Callout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3de5b30f115d788e9f8342dfa720a8525f38fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Modules_Callout), @"mvc.1.0.view", @"/Views/Modules/Callout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Modules/Callout.cshtml", typeof(AspNetCore.Views_Modules_Callout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3de5b30f115d788e9f8342dfa720a8525f38fb3", @"/Views/Modules/Callout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Modules_Callout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Website.AgilityModels.Module_Callout>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Modules\Callout.cshtml"
 if(Model.Image != null)
{

#line default
#line hidden
            BeginContext(76, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 84, "\"", 112, 2);
#line 5 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Modules\Callout.cshtml"
WriteAttributeValue("", 90, Model.Image.URL, 90, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 106, "?w=200", 106, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 113, "\"", 137, 1);
#line 5 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Modules\Callout.cshtml"
WriteAttributeValue("", 119, Model.Image.Label, 119, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(138, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 6 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Modules\Callout.cshtml"
}

#line default
#line hidden
            BeginContext(146, 8, true);
            WriteLiteral("\r\n\r\n<h1>");
            EndContext();
            BeginContext(155, 11, false);
#line 9 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Modules\Callout.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(166, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            BeginContext(176, 24, false);
#line 11 "C:\Users\James Vidler\Source\Repos\Agility-AspNetCore-Vanilla\Agility-AspNetCore-Vanilla\Website\Views\Modules\Callout.cshtml"
Write(Html.Raw(Model.TextBlob));

#line default
#line hidden
            EndContext();
            BeginContext(200, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Website.AgilityModels.Module_Callout> Html { get; private set; }
    }
}
#pragma warning restore 1591
