using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine("Aumenta 1 a cada conta criada: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Retorna agência pelo get: " + conta.Agencia);
            Console.WriteLine("Retorna número pelo get: " + conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86712540);
            Console.WriteLine("Aumenta 1 a cada conta criada: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();

        }
    }
}
