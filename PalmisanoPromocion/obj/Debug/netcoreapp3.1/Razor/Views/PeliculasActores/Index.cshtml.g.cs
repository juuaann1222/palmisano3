#pragma checksum "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10e6ead6b286b744eff5b362db55babe1235b7ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PeliculasActores_Index), @"mvc.1.0.view", @"/Views/PeliculasActores/Index.cshtml")]
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
#line 1 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\_ViewImports.cshtml"
using PalmisanoPromocion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\_ViewImports.cshtml"
using PalmisanoPromocion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e6ead6b286b744eff5b362db55babe1235b7ec", @"/Views/PeliculasActores/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d98147e7ab9ec0bb211ba1ab190d544ad40b39", @"/Views/_ViewImports.cshtml")]
    public class Views_PeliculasActores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PalmisanoPromocion.Models.PeliculaActor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Indice Peliculas Actores</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10e6ead6b286b744eff5b362db55babe1235b7ec4158", async() => {
                WriteLiteral("Crear nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pelicula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Persona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pelicula.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Persona.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 35 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
           Write(Html.ActionLink("Detalles", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 36 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Guillermo\Documents\Guille\Tecnicatura en programacion\Segundo Año\2 cuatrimestre\Laboratorio 4\Final\PalmisanoPromocion\PalmisanoPromocion\Views\PeliculasActores\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PalmisanoPromocion.Models.PeliculaActor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
