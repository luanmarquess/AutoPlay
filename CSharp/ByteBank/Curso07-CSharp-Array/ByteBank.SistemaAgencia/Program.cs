using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();
            //idades.Adicionar("não irá compilar por tipo genérico é int");
            idades.AdicionarVarios(1, 33, 22);


            int somaIdades = 0;
            for (int i = 0; i <= idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
                somaIdades += idadeAtual;
            }

                Console.ReadLine();
        }
        static void TestaListaDeObject()
        {
            /*
            static void Main(string[] args)
            {
                ListaDeObject listaDeIdades = new ListaDeObject();
                listaDeIdades.Adicionar(10);
                listaDeIdades.Adicionar(20);
                listaDeIdades.Adicionar(30);
                listaDeIdades.AdicionarVarios(21, 23, 43, 54, 65, 45);

                for (int i = 0; i < listaDeIdades.Tamanho; i++)
                {
                    int idade = (int)listaDeIdades[i];
                    Console.WriteLine($"Idade no indice {i}: {idade}");
                }
                Console.ReadLine();
            */
            }

        public static void TestaAdicaoListaComMaisDeUmParam()
        {
            /*
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoLuan = new ContaCorrente(777999, 7777999);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoLuan,
                new ContaCorrente(111, 1111111),
                new ContaCorrente(222, 2222222),
                new ContaCorrente(333, 3333333),
                new ContaCorrente(444, 4444444),
            };
            //lista.AdicionarVarios(contas);
            lista.AdicionarVarios (new ContaCorrente(555, 5555555),
            new ContaCorrente(666, 6666666), new ContaCorrente(777, 7777777));
            Console.ReadLine();
            */

        }
        public static void TestaAdicionaERemoveItemArray()
        {
            /*
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoLuan = new ContaCorrente(777999, 7777999);

            lista.Adicionar(contaDoLuan);

            lista.Adicionar(new ContaCorrente(111, 1111111));
            lista.Adicionar(new ContaCorrente(222, 2222222));
            lista.Adicionar(new ContaCorrente(333, 3333333));
            lista.Adicionar(new ContaCorrente(444, 4444444));
            lista.Adicionar(new ContaCorrente(555, 5555555));
            lista.Adicionar(new ContaCorrente(666, 6666666));
            lista.Adicionar(new ContaCorrente(777, 7777777));
            lista.Adicionar(new ContaCorrente(888, 8888888));

            Console.WriteLine("------------Testando o Get da Lista------------");

            for (int i = 0; i < lista.Tamanho; i++)
            {

                ContaCorrente itemAtual = lista.GetItemIndice(i);
                Console.WriteLine($"Item na posicao {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            /*
            lista.EscreverListaNaTela();
            lista.Remover(contaDoLuan);
            Console.WriteLine("--------------------Removendo--------------");
            lista.EscreverListaNaTela();
            */

            //Console.ReadLine();
            
        }

        static void testaArrayDinamico()
        {
            /*
            ContaCorrente[] contas = new ContaCorrente[] {

               new ContaCorrente(111, 1111111),
               new ContaCorrente(222, 2222222),
               new ContaCorrente(333, 3333333),

            };
            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta do indice {i}, possui o numero: {contas[i].Numero}");
            }
            Console.ReadLine();
            */
        }


        static void testaArray()
        {
            /*
            int[] idades = new int[5];
            idades[0] = 10;
            idades[1] = 20;
            idades[2] = 30;
            idades[3] = 40;
            idades[4] = 50;

            Console.WriteLine(idades[3]);

            int[] idadesOutro = new int[5];
            idadesOutro = idades;
            Console.WriteLine("Exibir 30: " + idadesOutro[2]);

            bool[] arrayBool = new bool[5];
            arrayBool[0] = true;
            arrayBool[1] = false;
            arrayBool[2] = false;
            arrayBool[3] = false;
            arrayBool[4] = true;
            Console.WriteLine("Exibir false: " + arrayBool[3]);

            //media array:
            int somatoriaIdades = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                somatoriaIdades += idades[i];
            }
            double media = somatoriaIdades / idades.Length;
            Console.WriteLine($"Média das idades é {media}");



            Console.ReadLine();
            */
        }
    }
}
