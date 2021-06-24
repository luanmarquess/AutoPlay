using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8: Bool");
            int idadeJoao = 17;
            bool entradaAcompanhado = true;

            if (idadeJoao >= 18 || entradaAcompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João é menor de idade.");
            }


            Console.ReadLine();
        }
    }
}
