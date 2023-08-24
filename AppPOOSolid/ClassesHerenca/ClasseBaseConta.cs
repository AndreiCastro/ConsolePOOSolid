using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid.ClassesHerenca
{
    internal class ClasseBaseConta
    {
        #region Propriedades
        public int Numero { get; set; }
        public double Saldo { get; set; }
        #endregion Propriedades

        protected virtual string GetSaldo()
        {
            return $"A conta: {Numero}, tem o saldo de: {Saldo} e com jutos mensal de:";
        }
    }
}
