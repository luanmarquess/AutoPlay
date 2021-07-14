using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuloCincoQueue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            Enfileirar("van");
            Enfileirar("Kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

            // testar tratamendo de erro caso não haja mais fila
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if(pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("Guincho está fazendo o pagamento");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);

            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("Fila: ");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
