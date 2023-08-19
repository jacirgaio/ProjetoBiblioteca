using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Admin()
        {
            Autenticacao.CheckLogin(this);
            return View(/Home/Index);
        }

        public IActionResult RegistrarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
         public IActionResult RegistrarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View(/Usuarios/ListarUsuarios);
        }
        
        public IActionResult EditarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View(/Usuarios/ListarUsuarios);
        }
        
        public IActionResult ListarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
    }
}