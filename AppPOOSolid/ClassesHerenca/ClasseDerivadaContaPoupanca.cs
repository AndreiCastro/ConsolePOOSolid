using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid.ClassesHerenca
{
    internal class ClasseDerivadaContaPoupanca : ClasseBaseConta
    {
        #region Propriedades
        public double JurosMensais { get; set; }
        #endregion Propriedades

        public ClasseDerivadaContaPoupanca(int numero, double saldo, double jurosMensais)
        {
            Numero = numero;
            Saldo = saldo;
            JurosMensais = jurosMensais;
            Console.WriteLine($"{GetSaldo()} {JurosMensais}\n");
        }
    }
}
