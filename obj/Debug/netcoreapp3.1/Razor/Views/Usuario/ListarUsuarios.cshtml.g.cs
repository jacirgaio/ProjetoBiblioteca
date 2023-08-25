#pragma checksum "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b43f0d88d0df4be91ef1a56e712dd609bbd071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuarios.cshtml")]
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
#line 1 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b43f0d88d0df4be91ef1a56e712dd609bbd071", @"/Views/Usuario/ListarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Biblioteca.Models.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\"> ");
#nullable restore
#line 5 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                   Write(ViewData["mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                 if (u.Tipo == Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 24 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 29 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 736, "\"", 765, 2);
            WriteAttributeValue("", 743, "EditarUsuario?id=", 743, 17, true);
#nullable restore
#line 30 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 760, u.Id, 760, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 806, "\"", 836, 2);
            WriteAttributeValue("", 813, "ExcluirUsuario?id=", 813, 18, true);
#nullable restore
#line 31 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 831, u.Id, 831, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\josiane\OneDrive\tii-jacir\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Biblioteca.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
