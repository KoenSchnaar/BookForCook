#pragma checksum "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "507f2019464db98ab7284b3105f79c42c0f91512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recept_GoToRecept), @"mvc.1.0.view", @"/Views/Recept/GoToRecept.cshtml")]
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
#line 1 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\_ViewImports.cshtml"
using BookForCook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\_ViewImports.cshtml"
using BookForCook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"507f2019464db98ab7284b3105f79c42c0f91512", @"/Views/Recept/GoToRecept.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ee13874ba71c1456b32c0c272df9bd0c08e352", @"/Views/_ViewImports.cshtml")]
    public class Views_Recept_GoToRecept : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookForCook.Models.ReceptModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml"
Write(Model.Gerecht);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"flexbox\">\r\n\r\n    <div class=\"box1\">\r\n        <h4>Ingrediënten</h4>\r\n");
#nullable restore
#line 9 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml"
         foreach(var ingr in Model.Ingrediënten)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 11 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml"
            Write(ingr.Ingrediënt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml"
                             Write(ingr.Hoeveelheid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml"
                                               Write(ingr.Eenheid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n    <div class=\"box2\">\r\n        <h4>Bereidingswijze</h4>\r\n        ");
#nullable restore
#line 19 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Recept\GoToRecept.cshtml"
   Write(Model.Beschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookForCook.Models.ReceptModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
