using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program // partial == separar uma mesma classe em diferentes arquivos;
    {
        static void UsarStreamReader() //UsarStreamReader change to main
        {

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))  // StreamReader : tem um buffer e verifica quando chega em um caracter de quebra de linha;
            {
                while (!leitor.EndOfStream)// enquanto não chegou no fim da stream
                {
                    var linha = leitor.ReadLine();
                    //var linha = leitor.ReadToEnd();// le o arquivo todo e retorna uma string. Tomar cuidado ao utilizar com arquivos muito grandes;
                    //var linha = leitor.Read(); // retorna um int;

                    var contaCorrente = ConverterStringParaContaCorrente(linha);
                    Console.WriteLine($"Nome:{contaCorrente.Titular.Nome}. Conta número:{contaCorrente.Numero}. Ag:{contaCorrente.Agencia}. Saldo:{contaCorrente.Saldo}");
                }

            }

            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');// CSV == Separados por vírgula; // indica em qual caractere deve quebrar linha;

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];


            var agenciaComoInt = int.Parse(agencia);//transforma uma string para um int;
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);
            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}