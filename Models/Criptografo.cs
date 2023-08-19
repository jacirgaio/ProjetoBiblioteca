using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Biblioteca.Models
{
    public static class Criptografo
    {
        public static string TextoCriptografado(string textoSemFormatacao)
        {
            MD5 md5Hasher = MD5.Create();
            
            byte[] By = Encoding.default.GetBytes(textoSemFormatacao);
            byte[] byteCriptografado = md5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in byteCriptografado)
            {
                string DebugB = b.ToList("x2");
                SB.Append(DebugB);
            }      

            return SB.ToString();
            
        }
    }
}