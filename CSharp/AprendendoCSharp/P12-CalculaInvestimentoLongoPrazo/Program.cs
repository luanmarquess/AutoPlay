using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12: Calcula Investimento a longo prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;
            int ano = 2000;
            int mes = 1;


            for (int contadorAno = 2000; contadorAno <= 2005; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("No mês " + mes + " do ano " + ano + " você terá: " + valorInvestido);
                    mes++;
                }
                ano++;
                mes = 1;
                fatorRendimento += 0.001;
            }



            Console.ReadLine();
        }
    }
}
