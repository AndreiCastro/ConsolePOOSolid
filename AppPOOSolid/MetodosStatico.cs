using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid
{
    internal class MetodosStatico
    {
        public int Valor1 { get; private set; }
        public int Valor2 { get; private set; }

        public MetodosStatico()
        {
        }

        internal static int Somar(int valor1, int valor2)
        {
            return valor1 += valor2;
        }

        internal int Subtrair(int valor1, int valor2)
        {
            return valor1 -= valor2;
        }
    }
}
