using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid
{
    internal class Construtor
    {
        public string _nome;
        public int _idade;
        public bool _sexo;

        /*
         Por padrão toda classe tem um metodo construtor que não tem nenhum parametro, ele nem visivel fica no código
         Uma classe pode ter mais de construtor, isso é a sobrecarga
        */
        public Construtor()
        {

        }

        public Construtor(string nome, int idade, bool sexo)
        {
            _nome = nome;
            _idade = idade;
            _sexo = sexo;
        }

        public void Identificar()
        {
            var sexoString = "Male";
            if (!_sexo)
                sexoString = "Famale";

            Console.WriteLine($"Olá, prazer my name is: {_nome}, I have {_idade} years old, and my sexy is: {sexoString}\n");
        }
    }
}
