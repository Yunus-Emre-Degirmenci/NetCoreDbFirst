#pragma checksum "C:\Users\Hp\OneDrive\Masaüstü\Dersler\CinemaDbFirst\CinemaDbFirst\Views\Movies\MoviesLists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7979d86168c60a834be706719411e298390786ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MoviesLists), @"mvc.1.0.view", @"/Views/Movies/MoviesLists.cshtml")]
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
#line 1 "C:\Users\Hp\OneDrive\Masaüstü\Dersler\CinemaDbFirst\CinemaDbFirst\Views\_ViewImports.cshtml"
using CinemaDbFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7979d86168c60a834be706719411e298390786ac", @"/Views/Movies/MoviesLists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcbb4466bbf99f89b85d80a4acdcb6e588ae86a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_MoviesLists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TblMovie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3\" crossorigin=\"anonymous\">\r\n\r\n");
            WriteLiteral(@"
<h3>Filmler</h3>
        <table class=""table table-striped table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Film Adı</th>
                    <th scope=""col"">Kategori</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 15 "C:\Users\Hp\OneDrive\Masaüstü\Dersler\CinemaDbFirst\CinemaDbFirst\Views\Movies\MoviesLists.cshtml"
                 foreach (TblMovie item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 18 "C:\Users\Hp\OneDrive\Masaüstü\Dersler\CinemaDbFirst\CinemaDbFirst\Views\Movies\MoviesLists.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 19 "C:\Users\Hp\OneDrive\Masaüstü\Dersler\CinemaDbFirst\CinemaDbFirst\Views\Movies\MoviesLists.cshtml"
                       Write(item.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\Hp\OneDrive\Masaüstü\Dersler\CinemaDbFirst\CinemaDbFirst\Views\Movies\MoviesLists.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Hp\OneDrive\Masaüstü\Dersler\CinemaDbFirst\CinemaDbFirst\Views\Movies\MoviesLists.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TblMovie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
