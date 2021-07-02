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

            /*
            string url = "página?argumentos";

            int indeceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indeceInterrogacao);

            string argumentos = url.Substring(indeceInterrogacao+1);

            Console.WriteLine(argumentos);
            Console.ReadLine();
            */





            
            string urlParametros = "http://www.bytebank.com/cambios/?moedaDeOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);


            string valorMoedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de Moeda Destino: " + valorMoedaDestino);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaDeOrigem");
            Console.WriteLine("Valor de Moeda Origem: " + valorMoedaOrigem);

            string valor = extratorDeValores.GetValor("valor");
            Console.WriteLine(valor);

            Console.ReadLine();

            

           
            /*
            //Testando o metodo remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');

            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 5));
            Console.ReadLine();
            */







            /*
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";


            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();






            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
            */

            //--------------------------------------------------------------------
            /* TESTE INDEXOF
             String texto = "Gustavo_Silva";

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("String vazia");
            }

            Int32 indice = texto.IndexOf("Gustavo");
            String texto2 = texto.Substring(indice + 1);

            Console.WriteLine("Tamanho: " + texto.Length);
            Console.WriteLine("Indice: " + indice);
            Console.WriteLine(texto2);*/
        }
    }
}
