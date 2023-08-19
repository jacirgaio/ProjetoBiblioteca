using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public List<Usuario> Listar() 
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.ToList(); 
            }
        }

        public void incluirUsuario (Usuario user) 
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Add(user);
                bc.SaveChanges();
            }
        }

        public void editarUsuario (Usuario userEditado) 
        {
             using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario u = bc.Usuarios.Find(userEditado.Id);

                u.Login = userEditado.Login;
                u.Nome = userEditado.Nome;
                u.Senha = userEditado.Senha;
                u.Tipo = userEditado.Tipo;

                bc.SaveChanges();
            }
        }

        public void excluirUsuario (int id) 
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
            }
        }

    }
}