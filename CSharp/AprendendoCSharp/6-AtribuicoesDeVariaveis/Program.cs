using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6:");

            int idade = 23;
            int idadeLuan = idade;

            idade = 90;

            Console.WriteLine(idade);
            Console.WriteLine(idadeLuan);
            Console.ReadLine();

        }
    }
}
