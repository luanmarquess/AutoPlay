using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariavelDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis: Double");

            double salario = 17.45;
            Console.WriteLine(salario);

            double resultado = 15 / 2;
            Console.WriteLine(resultado); //Trunca o retorno, cortando as casas decimais. Retorna 7 ao inves de 7.5. Pois por mais que esta declarado como Double, ambos os valores sao inteiros, desta dorma ele reconhece como int;
          
            resultado = 15.0 / 2;
            Console.WriteLine(resultado); // Retorna o valor esperado (7.5), pois um dos valores e Double.


            Console.WriteLine("A execucao acabou. Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
