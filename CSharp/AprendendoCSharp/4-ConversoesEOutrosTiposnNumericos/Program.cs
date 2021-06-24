using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposnNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // conversao do double pra int. Esta conversao e chamada de casting;

            Console.WriteLine(salario + " e " + salarioEmInteiro);

            // int aceita numeros de -2^31 ate 2^31 Ou seja o limite e de +- 2 bilhoes == 2000000000. Ocupa 32bits na memoria
            //int idade = 2000000000;

            // Para declarar um numero maior que 2000000000, declara-se como long; Ocupa 64bits na memoria
            long idade = 3000000000;
            Console.WriteLine(idade);

            // Declarar numeros pequenos para ocupar pouca memoria; Ocupa 16bits memoria

            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            // Float possui uma precisao curta para casas decimais. Menor que a do Double
            // f == declara este valor nao e um erro de digitacao. Necessario para afirmar que o tipo e float
            float altura = 1.71f;
            Console.WriteLine(altura);




            Console.ReadLine();
        }
    }
}
