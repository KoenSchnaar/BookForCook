#pragma checksum "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74741e1c17207a2fcd65c77a02fb75d81f216b60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_ReceptModel), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/ReceptModel.cshtml")]
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
using Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74741e1c17207a2fcd65c77a02fb75d81f216b60", @"/Views/Shared/EditorTemplates/ReceptModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66a2988a3956d69dcd157aa41c31afeb61376836", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_ReceptModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shared.Models.ReceptModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.LabelFor(m => m.Gerecht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 5 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.TextBoxFor(m => m.Gerecht));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 7 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.LabelFor(m => m.Bereidingstijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.TextBoxFor(m => m.Bereidingstijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.LabelFor(m => m.Beschrijving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 13 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.TextBoxFor(m => m.Beschrijving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 15 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.LabelFor(m => m.Vegetarisch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.CheckBoxFor(m => m.Vegetarisch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Koen\source\repos\BookForCook\BookForCook\Views\Shared\EditorTemplates\ReceptModel.cshtml"
Write(Html.EditorFor(m => Model.Ingrediënten));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shared.Models.ReceptModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
