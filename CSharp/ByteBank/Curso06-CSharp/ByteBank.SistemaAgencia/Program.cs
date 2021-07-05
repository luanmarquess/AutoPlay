using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            object desenvolvedor = new Desenvolvedor("454545454");

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado " + contaToString);


            Cliente carlos1 = new Cliente();
            carlos1.Nome = "Carlos";
            carlos1.CPF = "111.111.111-11";
            carlos1.Profissao = "Jogador";

            Cliente carlos2 = new Cliente();
            carlos2.Nome = "Carlos";
            carlos2.CPF = "111.111.111-11";
            carlos2.Profissao = "Jogador";

            ContaCorrente conta3 = new ContaCorrente(111, 1111);

            if (carlos1.Equals(conta3))
            {
                // Feito o override do método Equals para comparar os atribustos de cada objeto na Classe Cliente;
                Console.WriteLine("Objetos Iguais");
            }
            else
            {
                Console.WriteLine("Não são Iguais");
            }

            Console.ReadLine();



        /*
            // Teste filtar digitos (celular), em string, independente dos caracretes antecessores;

            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}"; // {4,5} == aceita 4 ou 5 caracteres
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}"; // [] == não necessita [] para um único caracter ex: "-"
            string padrao = "[0-9]{4,5}-?[0-9]{4}"; // ? substitui {0,1} tem ou não;
            string textoTeste = "Olá meu nome é Luan, entre em contato comigo pelo número 1234-0987";
            string textoTeste2 = "Olá meu nome é Luan, entre em contato comigo pelo número 912340987";

            Match resultado = Regex.Match(textoTeste, padrao);
            Match resultado2 = Regex.Match(textoTeste2, padrao);
            Console.WriteLine("Retorna o número de telefone: " + resultado.Value);
            Console.WriteLine("Retona telefone: " + resultado);
            Console.WriteLine("Retona telefone com 5 digitos iniciais: " + resultado2);
            Console.ReadLine();
        */



            /*
            //teste StartsWith e EndsWith
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine("Deve retornar True, pois string começa identica: " + urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine("Deve retornar False pois não há / no fim da string: " + urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("ByteBank"));
            Console.ReadLine();
            /*
            /*
           // Teste exibir apenas a porção da string desejada
            string url = "página?argumentos";

            int indeceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indeceInterrogacao);

            string argumentos = url.Substring(indeceInterrogacao+1);

            Console.WriteLine(argumentos);
            Console.ReadLine();
            */





            /*
            string urlParametros = "http://www.bytebank.com/cambios/?moedaDeOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);


            string valorMoedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de Moeda Destino: " + valorMoedaDestino);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaDeOrigem");
            Console.WriteLine("Valor de Moeda Origem: " + valorMoedaOrigem);

            string valor = extratorDeValores.GetValor("valor");
            Console.WriteLine(valor);

            Console.ReadLine();
            */



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
