#pragma checksum "/Users/jackal/Projects/fans/Views/Idol/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a6773fd0e29f3176d58f47484534b63f249483c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idol_Index), @"mvc.1.0.view", @"/Views/Idol/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idol/Index.cshtml", typeof(AspNetCore.Views_Idol_Index))]
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
#line 1 "/Users/jackal/Projects/fans/Views/_ViewImports.cshtml"
using fans;

#line default
#line hidden
#line 2 "/Users/jackal/Projects/fans/Views/_ViewImports.cshtml"
using fans.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a6773fd0e29f3176d58f47484534b63f249483c", @"/Views/Idol/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59f5af1e23df866fd0786fb46cd36341589c404d", @"/Views/_ViewImports.cshtml")]
    public class Views_Idol_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fans.Models.Idol.IdolIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 333, true);
            WriteLiteral(@"
<div class=""title"">
    <i class=""fas fa-child""></i> all idols
</div>

<div class=""content"">

    <table class=""table table-hover"" id=""userIndexTable"">
        <thead>
            <tr>
                <th>團體</th>
                <th>Name</th>
                <th>English Name</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "/Users/jackal/Projects/fans/Views/Idol/Index.cshtml"
             foreach(var Idol in Model.IdolList)
            {

#line default
#line hidden
            BeginContext(439, 86, true);
            WriteLiteral("                <tr class=\"userRow\">\n                    <td>\n                        ");
            EndContext();
            BeginContext(526, 11, false);
#line 22 "/Users/jackal/Projects/fans/Views/Idol/Index.cshtml"
                   Write(Idol.ClubId);

#line default
#line hidden
            EndContext();
            BeginContext(537, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(614, 9, false);
#line 25 "/Users/jackal/Projects/fans/Views/Idol/Index.cshtml"
                   Write(Idol.Name);

#line default
#line hidden
            EndContext();
            BeginContext(623, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(700, 16, false);
#line 28 "/Users/jackal/Projects/fans/Views/Idol/Index.cshtml"
                   Write(Idol.EnglishName);

#line default
#line hidden
            EndContext();
            BeginContext(716, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 31 "/Users/jackal/Projects/fans/Views/Idol/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(779, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fans.Models.Idol.IdolIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
