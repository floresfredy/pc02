#pragma checksum "/home/danny/Documentos/programacion 1/git/pc02/Views/Home/confirmacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e49efe1d1bde4846d7891c4cb3b10026088007d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_confirmacion), @"mvc.1.0.view", @"/Views/Home/confirmacion.cshtml")]
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
#line 1 "/home/danny/Documentos/programacion 1/git/pc02/Views/_ViewImports.cshtml"
using mvcpc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/danny/Documentos/programacion 1/git/pc02/Views/_ViewImports.cshtml"
using mvcpc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e49efe1d1bde4846d7891c4cb3b10026088007d", @"/Views/Home/confirmacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e4f3db6eb29147f7697ce101bf9f5855780e40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_confirmacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\n    body { background-color: #14B76E; color: #fff}\n    \n  </style>\n<h1>Formulario de contacto</h1>\n\n<div class=\"alert alert-success\">\n    Su mensaje ha sido recibido con éxito. Pronto estaremos en contacto.\n</div>\n\n<h1 class=\"display-4\">Hola ");
#nullable restore
#line 11 "/home/danny/Documentos/programacion 1/git/pc02/Views/Home/confirmacion.cshtml"
                      Write(ViewData["Mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "/home/danny/Documentos/programacion 1/git/pc02/Views/Home/confirmacion.cshtml"
                                           Write(ViewData["param1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
