#pragma checksum "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ff62b8435484ac5e4123af284995bd626b9f17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(COVID.App.Frontend.Pages.Listas.Pages_Listas_Estudiantes), @"mvc.1.0.razor-page", @"/Pages/Listas/Estudiantes.cshtml")]
namespace COVID.App.Frontend.Pages.Listas
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
#line 1 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\_ViewImports.cshtml"
using COVID.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ff62b8435484ac5e4123af284995bd626b9f17", @"/Pages/Listas/Estudiantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1847fd124ede0cd5ef7fffed400519f7c69d7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_Estudiantes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/listas/Estudiantes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Listas/DetallesEstudiantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br>\r\n<h1>Gestor de Estudiantes</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85ff62b8435484ac5e4123af284995bd626b9f174604", async() => {
                WriteLiteral(@"
    <fieldset>

        <legend>Estudiante</legend>

        <div class=""row g-3"">
            <div class=""col"">
                <input name=""jform[nombre_persona]"" id=""jform_nombre"" for=""Nombre_persona"" type=""text"" class=""form-control required invalid"" placeholder=""Nombre"" aria-label=""Nombre"" required aria-required=""true"" aria-invalid=""true"">
            </div>
            <div class=""col"">
                <input name=""jform[apellidos_persona]"" id=""jform_apellido"" type=""text"" class=""form-control required invalid"" placeholder=""Apellido"" aria-label=""Apellido"" required aria-required=""true"" aria-invalid=""true"">
            </div>
        </div>
        <br>
        <div class=""row g-3"">
            <div class=""col"">
                <input name=""jform[edad_persona]"" id=""jform_edad"" type=""text"" class=""form-control"" placeholder=""Edad"" aria-label=""Edad"">
            </div>
            <div class=""col"">
                <input name=""jform[carrera_profesor]"" id=""jform_carrera"" type=""text"" class=""for");
                WriteLiteral(@"m-control"" placeholder=""Carrera"" aria-label=""Carrera"" required=""required"" aria-required=""true"" aria-invalid=""true"">
            </div>
        </div>
        <br>
        <div class=""row g-3"">
            <div class=""col"">
                <input name=""jform[semestre_profesor]"" id=""jform_semestre"" type=""text"" class=""form-control"" placeholder=""Semestre"" aria-label=""Semestre"" required=""required"" aria-required=""true"" aria-invalid=""true"">
            </div>
            <div class=""col"">
                
            </div>
        </div>
        <br>

        <div class=""content"">
            <div class=""row"">
            <div class=""col-sm-12""> <input class=""btn btn-primary"" type=""button"" class= ""btn"" value=""Crear""> 
              </div>
            </div>
	    </div>
        <br>     




        
               
    </fieldset>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<h2>Lista de Estudiantes</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n            <td><b>Nombre</b></td>\r\n            <td><b>Apellidos</b></td>\r\n            <td><b>Edad</b></td>\r\n            <td><b>Estado COVID</b></td>\r\n    </tr>\r\n");
#nullable restore
#line 76 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml"
         foreach(var estudiante in Model.Estudiantes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 79 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml"
           Write(estudiante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 80 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml"
           Write(estudiante.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 81 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml"
           Write(estudiante.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 82 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml"
           Write(estudiante.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85ff62b8435484ac5e4123af284995bd626b9f179725", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle fa-lg\" aria-hidden=\"true\"></i>\r\n                    Detalle\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idestudiante", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml"
                                                                                                         WriteLiteral(estudiante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idestudiante"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idestudiante", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idestudiante"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            \r\n            \r\n        </tr>\r\n");
#nullable restore
#line 92 "D:\COVIDV2\Covid19_V2.App\COVID.App.Frontend\Pages\Listas\Estudiantes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COVID.App.Frontend.Pages.EstudiantesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<COVID.App.Frontend.Pages.EstudiantesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<COVID.App.Frontend.Pages.EstudiantesModel>)PageContext?.ViewData;
        public COVID.App.Frontend.Pages.EstudiantesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
