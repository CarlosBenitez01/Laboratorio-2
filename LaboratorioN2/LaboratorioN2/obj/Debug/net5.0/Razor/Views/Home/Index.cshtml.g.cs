#pragma checksum "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e7685621c7c0d5da95ae17edbf0e41299ca466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\_ViewImports.cshtml"
using LaboratorioN2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\_ViewImports.cshtml"
using LaboratorioN2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e7685621c7c0d5da95ae17edbf0e41299ca466", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389c7316e4c9ccdee826f5e88203203cda672ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LaboratorioN2.Models.ViewModels.PersonaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/estilo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34e7685621c7c0d5da95ae17edbf0e41299ca4664117", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"" integrity=""sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" "">
<title>Registro</title>

<div class=""contenedor"">
");
#nullable restore
#line 13 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
     using (Html.BeginForm("Save", "Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form__header"">
            <div class=""form__ico__cont"">
                <i class=""animate__animated animate__backInDown fas fa-save form__ico ""></i>
                <!--<i class=""fas fa-user form__ico""></i>-->
            </div>
        </div>
");
#nullable restore
#line 22 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.NombrePersona, new { @class = "form__label" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(m => m.NombrePersona));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(m => m.NombrePersona, new { @class = "form__input", @placeholder = "Escriba su nombre" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.EdadPersona, new { @class = "form__label" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(m => m.EdadPersona));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(m => m.EdadPersona, new { Type = "number", @class = "form__input", @placeholder = "Escriba su edad" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.DescripcionPersona, new { @class = "form__label" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(m => m.DescripcionPersona));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(m => m.DescripcionPersona, new { @class = "form__input", @placeholder = "Escriba su descripcion" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-outline-secondary form__button\" value=\"Save\">\r\n");
#nullable restore
#line 37 "C:\Users\cb272\Documents\GitHub\Laboratorio-2\LaboratorioN2\LaboratorioN2\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LaboratorioN2.Models.ViewModels.PersonaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
