using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            //Char só aceita um caracter com aspas simples
            char umCaracter = 's';
            Console.WriteLine(umCaracter);

            //ASCII Table
            umCaracter = (char)65;
            Console.WriteLine(umCaracter);

            umCaracter = (char)(65 + 1);
            Console.WriteLine(umCaracter);


            //String usado para palavras
            string titulo = "Inicinado em C# em " + 2020;
            Console.WriteLine(titulo);


            //Usando '@' ele mostra o texto no console considerando as linhas
            string minhasLinguagens =
@"- Java
- JavaScript
- .NET";
            Console.WriteLine(minhasLinguagens);

            Console.ReadLine();
        }
    }
}
