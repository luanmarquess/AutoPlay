using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10: Calcula Poupança");

            double valorInvestido = 1000;
            int meses = 0;


            while(meses <= 12)
            {
            valorInvestido += valorInvestido * 0.0036;
            Console.WriteLine("No mês " + meses + " você terá: " + valorInvestido );
                meses++;

            }




            Console.ReadLine();
        }
    }
}
