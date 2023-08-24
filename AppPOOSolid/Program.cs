using System;
using AppPOOSolid.Utils;
using AppPOOSolid.ClassesHerenca;

namespace AppPOOSolid
{
    internal class Program
    {
        /*Modificar de acesso:
        Pulbic -    Todos no projeto conseguem acessá-los
        Internal -  Somente as classe do projeto conseguem acessá-los
        Private -   Somente a classe consegue acessá-lo
        Protected - Classe derivada consegue acessar a clase base
        
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
            var pessoa = new Construtor()
            {
                _nome = "Andrei",
                _idade = 31,
                _sexo = true
            };
            pessoa.Identificar();

            //Já aqui eu instancie a classe e usei o construtor que criei com os parametros, e estou passando eles.             
            pessoa = new Construtor("Mayara", 30, false);
            pessoa.Identificar();
            #endregion Ctor

            #region Encapsulamento
            var exemplo = new Encapsulamento(-1, "", "");
            exemplo.ExibirCW();

            /*exemplo.Id = 10; 
                Esse cod está errado, pois defini que ele somente pode ser acessado para leitura, {get} já o {set} está privado
                Somente posso passar valores como parametro no construtor*/
            #endregion Encapsulamento

            #region ArgumentosNomeados
            /*ArgumentosNomeados serve para vc definir o parametro mesmo não estando na ordem declarados.
              a 1º chamada esta na ordem, ja a outras não e o resultado é o mesmo*/

            var arg1 = new ArgumentosNomeados("EmailTeste", "AssuntoTeste", "CorpoEmailTeste");
            var arg2 = new ArgumentosNomeados(assunto: "AssuntoTeste", corpoEmail: "CorpoEmailTeste", email: "EmailTeste");
            var arg3 = new ArgumentosNomeados(corpoEmail: "CorpoEmailTeste", email: "EmailTeste", assunto: "AssuntoTeste");
            arg1.ExibirCW();
            arg2.ExibirCW();
            arg3.ExibirCW();
            Console.WriteLine("\n");
            #endregion ArgumentosNomeados

            #region StaticMethod
            /*No method somar consigo chama-lo sem precisar instanciar a class MetodosStaticos pois o metodo é static, já no Subtrair tenho
             que instanciar a classe pra poder acessar o metodo porque ele não é static*/
            var requiredInstance = new MetodosStatico();

            Console.WriteLine($"A soma é: {MetodosStatico.Somar(2, 2)}");
            Console.WriteLine($"A subtração é: {requiredInstance.Subtrair(2, 2)}\n");            
            #endregion StaticMethod

            #region Metodo de extensão
            var nome = "andrei";
            var nome2 = "mayara";

            Console.WriteLine(string.Format("{0} \n{1}\n",nome.FirstWordToUper(), nome2.FirstWordToUper()));
            #endregion Metodo de extensão

            #region Heranca
            /*Na classe ClasseDerivadaContaPoupanca o metodo GetSaldo() é acessivel mesmo sendo protected pq essa classe
             herda da classe ClasseBaseConta
             Se o metodo de uma classe tiver virtual quer dizer que ele pode ser sobreescrito (override). igual está o metodo
             GetSaldo da class ClasseBaseConta

             PS: Sempre a clase base é executada 1º e depois a classe Derivada 
             */
            var contaPoupanca = new ClasseDerivadaContaPoupanca(1234, 99.99, 145.50);            
            #endregion Heranca
        }
    }
}
