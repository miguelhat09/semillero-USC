#pragma checksum "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f66cfb034633131a31e4080d4b7c43f5903e37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\_ViewImports.cshtml"
using WebApp1.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\_ViewImports.cshtml"
using WebApp1.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using WebApp1.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f66cfb034633131a31e4080d4b7c43f5903e37a", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf1869e3b23ec30df0de1da69a04d9435e7a1b2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bbdfa9d416decbea554eec34698177e01680d6", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Confirmacion de registro";
    Layout = "~/Pages/Shared/_LayoutRegistro.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"main-register\">\r\n    <div class=\"row justify-content-center w-100 mb-4\" style=\"height: 90vh;\">\r\n        <div class=\"col-sm-4 d-flex flex-column align-items-center justify-content-center\" style=\"height: 100vh;\">\r\n");
#nullable restore
#line 11 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
              
                if (@Model.DisplayConfirmAccountLink)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>\r\n                <a class=\"registroconfirm-enlace\" id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 558, "\"", 592, 1);
#nullable restore
#line 15 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 565, Model.EmailConfirmationUrl, 565, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click aquí para confirmar tu cuenta.</a>\r\n            </h2>\r\n");
#nullable restore
#line 17 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                    Please check your email to confirm your account.\r\n            </p>\r\n");
#nullable restore
#line 23 "C:\Users\migue\OneDrive\Documents\USC\Quinto Semestre\web.NET\proyectoFinal\WebApp1\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
