#pragma checksum "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Pages\LandingPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411240b8c9895541e217931253c40715f7e2fb44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp1.Pages.Pages_LandingPage), @"mvc.1.0.razor-page", @"/Pages/LandingPage.cshtml")]
namespace WebApp1.Pages
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
#line 1 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Pages\_ViewImports.cshtml"
using WebApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Pages\_ViewImports.cshtml"
using WebApp1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Pages\_ViewImports.cshtml"
using WebApp1.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411240b8c9895541e217931253c40715f7e2fb44", @"/Pages/LandingPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872203287792e1deb746b43b979a55f6691f85dc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LandingPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Pages\LandingPage.cshtml"
  
    ViewData["Title"] = "Landing Page";
    Layout = "~/Pages/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""body"">
    <span id=""inicio""></span>
    <nav class=""landing-nav"">
        <a href=""https://www.usc.edu.co/""><img src=""images/icono-usc.png""></a>
        <div></div>
        <div class=""landing-navlist"">
            <ul>
                <li><a href=""#inicio"">Inicio</a></li>
                <li><a href=""#sabermas"">Saber más</a></li>
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411240b8c9895541e217931253c40715f7e2fb444890", async() => {
                WriteLiteral("Aplicación");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            </ul>
        </div>
    </nav>

    <div class=""principal"">
        <div class=""landing-centrar"">
            <div class=""landing-seccion1"">
                <div class=""overlay"">
                    .
                </div>
            </div>
        
            <div class=""landing-seccion2"">
                <div class=""landing-dtext"">
                    <h1>ÚNETE A UN GRUPO DE INVESTIGACIÓN</h1>
                    <a href=""#sabermas"">Leer más</a>
                </div>
            </div>
        </div>
    </div>

    <div class=""principal2"">
        <div class=""principal2-center"">
            <p>
                Los semilleros de investigación son espacios que buscan despertar y desarrollar 
                el espíritu investigativo de los estudiantes, fomentando la capacidad de indagación y 
                búsqueda hacia la comprensión crítica de los procesos comunicativos, potenciando el 
                pensamiento autónomo que le permita la formulación ");
            WriteLiteral(@"de problemas y alternativas de solución.</p>
        </div>
        <div class=""principal2-directores"">
            <div class=""directores"">
                <img src=""images/Luz_Caicedo_elipse.jpg"">
                <h5>Luz Dary Caicedo</h5>
                <p>Licenciada en Ciencias de la Educación y Especialista en Docencia para la Educación Superior (Universidad Santiago de Cali). 
                    Magister en Microbiología (Universidad del Valle) y estudiante de Maestría en Micología Médica (Universidad Nacional del Nordeste –UNNE-).
                </p>  
            </div>
            <div class=""directores"">
                <img src=""images/claudia-2-1.png"">
                <h5>Claudia Liliana Zuñiga Cañon</h5>
                <p>Directora de COMBA I+D, Profesora e investigadora con más de 10 años de experiencia en informática móvil. Estudios de pregrado en Ingeniería de sistemas y 
                    telemática (1997-2003) en la Universidad Santiago de Cali (Colombia), maestría en inge");
            WriteLiteral(@"niería Telemática (2006-2007) en la Universidad de Vigo (España). 
                    </p>
            </div>
            <div class=""directores"">
                <img src=""images/AlbaCorrales.jpg"">
                <h5>Alba Rocio Corrales Ducuara</h5>
                <p id=""sabermas"">Maestría en Biotecnología agroforestal, Universidad Politécnica de Madrid, España. Doctorado en Biotecnología y recursos 
                    genéticos de plantas y microorganismos asociados, Universidad Politécnica de Madrid, España. Actualmente es la líder del Grupo de Investigación en Microbiología, 
                    Industria y Ambiente (GIMIA).</p>
            </div>
        </div>
    </div>

    <script>
        document.querySelectorAll('a[href^=""#""]').forEach(anchor => {
            anchor.addEventListener('click', function (e) {
                e.preventDefault();

                document.querySelector(this.getAttribute('href')).scrollIntoView({
                    behavior: 'smooth'
           ");
            WriteLiteral("     });\r\n            });\r\n        });\r\n    </script>\r\n</div>>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_LandingPage> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_LandingPage> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_LandingPage>)PageContext?.ViewData;
        public Pages_LandingPage Model => ViewData.Model;
    }
}
#pragma warning restore 1591
