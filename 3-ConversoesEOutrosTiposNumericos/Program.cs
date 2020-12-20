using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3");

            //Usando CAST para converter o número
            double salario;
            salario = 1200.50;

            //Int possui 32 bits
            int salarioInteiro;
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);


            //Outras variaveis

            //Long 64 bits
            long idade = 999999999999999999;

            //Short 16 bits
            short quantidadeProdutos = 9999;

            //Float tem uma precisão menos após a virgula
            float altura = 1.80f; //Quando usar float é preciso colocar 'f' no final do valor


            Console.ReadLine();
        }
    }
}
