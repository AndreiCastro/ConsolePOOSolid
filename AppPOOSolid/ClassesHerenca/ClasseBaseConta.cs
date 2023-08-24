using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid.ClassesHerenca
{
    internal class ClasseBaseConta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        protected virtual string GetSaldo()
        {
            return $"A conta: {Numero}, tem o saldo de: {Saldo} e com jutos mensal de:";
        }
    }
}
