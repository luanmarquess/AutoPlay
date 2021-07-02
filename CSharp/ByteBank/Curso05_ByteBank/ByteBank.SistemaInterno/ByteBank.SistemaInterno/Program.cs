using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(11, 111);
            //conta.Sacar(50);

            //Console.WriteLine(conta.Saldo);

            //string nome = "Luan";

            //ContaCorrente conta2 = new ContaCorrente(565, 55555);

            DateTime dataPagamento = new DateTime(2021, 8, 17);
            DateTime dataCorrente = DateTime.Now;

            Console.WriteLine(dataPagamento);
            Console.WriteLine(dataCorrente);


            TimeSpan diferenca = dataCorrente - dataPagamento;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
           // string mensagem = "Vencimento em " + GetIntervalDeTempoLegivel(diferenca);

            Console.WriteLine("Diferença entre duas datas: " + diferenca);
            Console.WriteLine("Diferença entre duas datas, trantando a saida com a Biblioteca Humanizen: " + mensagem);
            
            //Console.WriteLine("Diferença entre duas datas tratando o retorno com um método: " + mensagem);
           
            


            Console.ReadLine();
            
        }

       /* static string GetIntervalDeTempoLegivel(TimeSpan timeSpan)
        {
            if(timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if(quantidadeMeses == 1)
                {
                    return "Quantidade de meses = 1 mês";               }
                return quantidadeMeses + " meses";
            }
            return timeSpan.Days + " Dias.";
        }*/
    }
}
