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
            
            Console.WriteLine("");
            Console.WriteLine("Inicio dos testes do tratamento de exceção para nome de agência e número >= a 0 ");
            try
            {
                ContaCorrente conta2 = new ContaCorrente(0, 10);
            }
            catch (ArgumentException ex)
            {
                // ParamName: nome do parâmetro que causou o erro;
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("");
            Console.WriteLine("Inicio dos testes do tratamento de exceção para método Sacar");
            ContaCorrente conta3 = new ContaCorrente(11,11);
            conta3.Depositar(50);
            conta3.Sacar(25);
            try
            {
                conta3.Sacar(200);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }

            Console.WriteLine(conta3.Saldo);



            Console.WriteLine("");
            Console.WriteLine("Inicio dos testes do tratamento de exceção para método Transferir");
            ContaCorrente conta4 = new ContaCorrente(22,22);
            try
            {
                conta4.Transferir(-10, conta3);
            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();



        }
    }
}
