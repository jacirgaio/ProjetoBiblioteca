using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public TipoUsuario Tipo { get; set; }
    }

    public enum TipoUsuario
    {
        ADMIN,
        PADRAO
    }


}