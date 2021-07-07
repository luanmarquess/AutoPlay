using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var idades = new List<int>();
            //ListExtensoes.AdicionarVarios(idades, 33, 44, 55, 66, 77);
            idades.AdicionarVarios(33, 44, 55, 66, 77);

            idades.Add(1);
            idades.Add(32);
            idades.Add(41);
            idades.Add(44);
            idades.Add(22);
            idades.Add(11);

            idades.Remove(5);

            idades.Sort();

            for(int i = 0; i<idades.Count; i++)
            {
                Console.WriteLine(idades[i]);

            }

            //List<string> nomes = new List<string>();
            //nomes.AdicionarVarios("Luan", "Lucas", "Beto");

            var nomes = new List<string>
            {
                "Luan",
                "Ana",
                "Zico",
                "Ronaldinho Gaúcho",
                "Dida"
            };

            nomes.Sort();
            for(int i = 0; i<nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            };


            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(444, 4444444),
                new ContaCorrente(222, 2222222),
                new ContaCorrente(111, 1111111),
                new ContaCorrente(333, 3333333),
                null,
                null
            };

            //contas.Sort();
            //contas.Sort(new ComparadorContaCorrentePorAgencia());
            //foreach(var conta in contas)
            //{
            //    Console.WriteLine($"Agência número: {conta.Agencia}, conta número: {conta.Numero}.");
            //}

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => conta.Numero);




            /*
            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => {
                if(conta == null)
                {
                    return int.MaxValue; //Maior valor possível para int32
                }

                return conta.Numero;
                });
            
            foreach(var conta in contasOrdenadas)
            {
                if(conta != null)
                {
                    Console.WriteLine($"Agência número: {conta.Agencia}, conta número: {conta.Numero}.");
                }
            }
            */
  


            var contasNaoNulas = contas.Where(conta => conta != null); //armazena apenas os valores não nulos


            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Agência número: {conta.Agencia}, conta número: {conta.Numero}.");
            }
            
                
            Console.ReadLine();
        }

    }
}
