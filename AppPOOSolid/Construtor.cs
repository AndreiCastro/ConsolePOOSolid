using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid
{
    internal class Construtor
    {
        #region Atributos
        public string nome;
        public int idade;
        public bool sexo;

        #endregion Atributos

        /*
         Por padrão toda classe tem um metodo construtor que não tem nenhum parametro, ele nem visivel fica no código
         Uma classe pode ter mais de construtor, isso é a sobrecarga
        */
        public Construtor()
        {

        }

        public Construtor(string _nome, int _idade, bool _sexo)
        {
            nome =  _nome;
            idade = _idade;
            sexo =  _sexo;
        }

        public void Identificar()
        {
            var sexoString = "Male";
            if (!sexo)
                sexoString = "Famale";

            Console.WriteLine($"Olá, prazer my name is: {nome}, I have {idade} years old, and my sexy is: {sexoString}\n");
        }
    }
}
