using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupancaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            int meses = 12;

            for(int i = 1; i <= meses; i++)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("No mês " + i + " você terá: " + valorInvestido);
            }
            Console.ReadLine();
        }
    }
}
