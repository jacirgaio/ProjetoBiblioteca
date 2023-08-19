using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models


namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }
    }

    // Verificação de login no bD//
    public static bool verificaLoginSenha(string login, string senha, Controller controller)
    {
         using(BibliotecaContext bc = new BibliotecaContext())
        {
            usuarioInicial();
            senha = Criptografo.TextoCriptografado(senha)

            IQueryable<Usuario> usuarioEncontrado = bc.Usuarios.Where(u => u.Login == login && u.Senha == senha);

            List<Usuario> listaUsuarioEncontrado = usuarioEncontrado.ToList();

            if (listaUsuarioEncontrado.Count == 0)
            {
                return false;
            }
            else
            {
                controller.HttpContext.Session.SetString("login", listaUsuarioEncontrado[0].Login);
                controller.HttpContext.Session.SetString("nome", listaUsuarioEncontrado[0].Nome);
                controller.HttpContext.Session.SetInt32("tipo", listaUsuarioEncontrado[0].Tipo);

                return true;
                
            }

            bc.SaveChanges();
        }
    }

    public static void verificaUsuarioAdmin(Controller controller)
    {
        if (controller.HttpContext.Session.GetInt32("tipo") != Usuario.ADMIN);
        {
            controller.Request.HttpContext.Response.Redirect("/Usuarios/Admin")
        }
    }

    public static void usuarioInicial()
    {
         using(BibliotecaContext bc = new BibliotecaContext())
        {
        
            IQueryable<Usuario> usuarioEncontrado = bc.Usuarios.Where(u => u.Login == "admin");

            if (usuarioEncontrado.ToList().Count == 0)
            {
                Usuario admin = new Usuario();
                admin.Login = "admin";
                admin.Senha = Criptografo.TextoCriptografado("admin");
                admin.Tipo = Usuario.ADMIN;
                admin.Nome = "administrador";

                bc.Usuarios.Add(admin);
                bc.SaveChanges();
            }

        }
    }


    
}