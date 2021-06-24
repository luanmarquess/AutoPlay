using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7: Condicionais");
            int idadeJoao = 19 ;
            string acompanhado = "no";

            if(idadeJoao >= 18 || acompanhado == "yes")
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
