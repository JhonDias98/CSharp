using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            int idade = 17;
            Boolean acompanhanteAduto = true;

            if(idade >= 18)
            {
                Console.WriteLine("Pode entrar!");
            } else if(idade < 18 && acompanhanteAduto)
            {
                Console.WriteLine("Pode entrar acompanhado!");
            } else
            {
                Console.WriteLine("Não pode entrar")
            }
            

            Console.ReadLine();
        }
    }
}
