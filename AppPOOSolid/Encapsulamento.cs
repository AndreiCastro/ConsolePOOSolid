using System;
using System.Collections.Generic;
using System.Text;

namespace AppPOOSolid
{
    /*
        Essa classe usei para definir o Encapsulamento
        Pois defini que sua propriedades só podem ser lidas, não pode atribuir valores para elas.
    */
    internal class Encapsulamento
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public Encapsulamento(int id, string nome, string endereco)
        {
            //throw new serve para lançar um excpetion
            if (id < 1)
                Console.WriteLine("Erro, id inválido");
            else if (nome.Length == 0)
                Console.WriteLine("Nome, id inválido");
            else if (endereco.Length == 0)
                Console.WriteLine("Endereço inválido");
            else
            {
                this.Id = id;
                this.Nome = nome;
                this.Endereco = endereco;
            }
        }

        internal void ExibirCW()
        {
            if (Id != 0)
                Console.WriteLine($"Id: {Id}, com nome de: {Nome} e o seu endereço é: {Endereco}");
        }
    }
}
