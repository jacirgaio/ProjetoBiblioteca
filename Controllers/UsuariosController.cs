using Biblioteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Admin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

         public IActionResult RegistrarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarUsuarios(Usuario u)
        {
            UsuarioService UsuarioService = new UsuarioService();

            if(u.Id == 0)
            {
                UsuarioService.incluirUsuario(u);
            }
            else
            {
                UsuarioService.editarUsuario(u);
            }

            return RedirectToAction("ListarUsuarios");
        }

        
        public IActionResult editarUsuarios()
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