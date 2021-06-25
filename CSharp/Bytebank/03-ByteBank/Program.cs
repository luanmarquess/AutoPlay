using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // retorna False mesmo que os atributos sejam iguais, são instâncias diferentes;
            Console.WriteLine(contaDaGabriela.titular == contaDaGabrielaCosta.titular); // retorna True, pois compara o atributo;

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela); // retorna True, pois agora  ambas as variáveis referênciam o mesmo espaço de memória alocado;
            Console.ReadLine();
        }
    }
}
