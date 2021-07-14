using System;
using System.Collections.Generic;

namespace ModuloCincoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        { 
             //Teste LinkedList
                List<string> frutas = new List<string>
                {
                    "abacate", "banana", "caqui", "damasco", "figo"
                };
                //forma de varrer toda a lista
                //Console.WriteLine($"A lista de frunta é: {string.Join(", ", frutas)}");

                foreach (var fruta in frutas)
                {
                    Console.WriteLine(fruta);
                }


                // LinkedList
                // Elementos não precisam estar em sequência em memória  
                // cada elemento sabe quem é o anterior e o próximo 
                // cada elemento é um nó e contém um valor

                //instânciando uma linkedlist
                LinkedList<string> dias = new LinkedList<string>();
                //adicionar elementos a linkedlist: Add.First, Add.Last, Add.Befor, Add.After; 
                var d4 = dias.AddFirst("quarta"); // linkedlistnode

                // acessar o valor
                Console.WriteLine($"d4 Value: {d4.Value}");

                // adicionar antes:
                var d2 = dias.AddBefore(d4, "segunda");

                // acessar proximo e o anterior: d2.Next ou d2. previous 

                //adicionar depois
                var d3 = dias.AddAfter(d2, "terça");
                var d6 = dias.AddAfter(d4, "sexta");
                var d7 = dias.AddAfter(d6, "sábado");
                var d5 = dias.AddBefore(d6, "quinta");
                var d1 = dias.AddBefore(d2, "domingo");

                //consultar lista

                foreach (var dia in dias)
                {
                    Console.WriteLine(dia);
                };

                //ou

                Console.WriteLine($"Os dias da semana são: {string.Join(", ", dias)}");

                // LinkedList NÃO da suporte a índice, ex: dias[0]

                // Remover
                dias.Remove("quarta");
                Console.WriteLine($"Os dias da semana são: {string.Join(", ", dias)}");
             
        }
    }
}
