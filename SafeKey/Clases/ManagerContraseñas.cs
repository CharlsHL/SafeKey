using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeKey.Clases
{
    internal class ManagerContraseñas
    {
        public string GenerarContrasña()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789¡?!'=)(/&%$#}{+´";
            var Charsarr = new char[15];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }
            var resultString = new String(Charsarr);
            return resultString;
        }
    }
}
