using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AppPOOSolid.Utils
{
    internal static class MetodosExtensao
    {
        public static string FirstWordToUper(this string valor)
        {
            if(valor.Length > 0)
            {
                char[] array = valor.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return valor;
        }
    }
}
