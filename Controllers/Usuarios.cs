using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class Usuarios : Controller
    {
        public IActionResult RegistrarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
         public IActionResult RegistrarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
        
        public IActionResult EditarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
        
        public IActionResult ListarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
    }
}