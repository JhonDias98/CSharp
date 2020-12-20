using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            //Inteiro
            int idade;
            idade = 22;
            Console.WriteLine("Idade: " + idade);


            //Real(Ponto Flutuante)
            //Double pode receber número inteiro, porém inteiro não recebe double
            double salario;
            salario = 3200.99;
            Console.WriteLine("Salario: " + salario);

            double novaIdade;
            novaIdade = 15 / 2; //2 números inteiros retorna outro inteiro
            Console.WriteLine("15 / 2 = " + novaIdade);
            novaIdade = 15.0 / 2;
            Console.WriteLine("15.0 / 2 = " + novaIdade);

            Console.WriteLine("Clique ENTER para finalizar");
            Console.ReadLine();
        }
    }
}
