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
            Console.WriteLine("Execucao finalizada. Tecle enter para sair");

            int idade = 32;
            Console.WriteLine(idade);

            int valor1 = 17;
            int valor2 = 49;
            int resultado = valor1 + valor2;

            Console.WriteLine("O resultado e: " + resultado);
            Console.ReadLine();
        }
    }
}
