using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            bool resultadoSaque = contaDoBruno.Sacar(1500);
            Console.WriteLine("Saldo conta: " + contaDoBruno.saldo); 
            Console.WriteLine("Retorna false caso saldo insuficiente: " + resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine("Valor depositado: " + contaDoBruno.saldo);




            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Tranferência entre aconta do Bruno e Gabriela");
            bool resultadoTranferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado da Transferencia: " + resultadoTranferencia); // Retorna True se saldo da conta que efetuar a operação > valor desejado;





            Console.ReadLine();
        }
    }
}
