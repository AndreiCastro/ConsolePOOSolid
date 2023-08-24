using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid
{
    internal class ArgumentosNomeados
    {
        public string Email { get; private set; }
        public string Assunto { get; private set; }
        public string CorpoEmail { get; private set; }

        public ArgumentosNomeados(string email, string assunto, string corpoEmail)
        {
            Email = email;
            Assunto = assunto;
            CorpoEmail = corpoEmail;
        }

        internal void ExibirCW()
        {
            Console.WriteLine($"Email é: {Email}, com o assunto de: {Assunto} e o corpo de: {CorpoEmail}.");
        }
    }
}
