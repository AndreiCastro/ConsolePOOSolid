using System;

namespace AppPOOSolid
{
    internal class Program
    {
        /*Modificar de acesso:
        Pulbic - Todos no projeto conseguem acessá-los
        Internal - Somente as classe do projeto conseguem acessá-los
        Private - Somente a classe consegue acessá-lo
        
        Isso vale para classe, atributos, pripriedades e etc..
        PS: Por default se não for especificado o modificar de acesso, ele é internal*/
        static void Main(string[] args)
        {
            #region Ctor
            /*
             Toda vez que uma classe é instanciada (var Class = new Class()) ela chama o metodo contrutor da classe.
             Nesse exemplo, usei o metodo construtor padrao e tive que informar os seus atributos pois estou usando 
             metodo sem paraemtros
             */
            var pessoa = new Pessoa()
            {
                _nome = "Andrei",
                _idade = 31,
                _sexo = true
            };
            pessoa.Identificar();

            //Já aqui eu instancie a classe e usei o construtor que criei com os parametros, e estou passando eles.             
            pessoa = new Pessoa("Mayara", 30, false);
            pessoa.Identificar();
            Console.WriteLine("\n");
            #endregion Ctor

            #region Encapsulamento
            var exemplo = new Encapsulamento(-1, "", "");
            exemplo.ExibirCW();

            /*exemplo.Id = 10; 
                Esse cod está errado, pois defini que ele somente pode ser acessado para leitura, {get} já o {set} está privado
                Somente posso passar valores como parametro no construtor*/
            Console.WriteLine("\n");
            #endregion Encapsulamento
        }
    }
}
