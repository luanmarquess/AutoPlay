using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "444, 78787, 4477.50, Luan Marques";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArqivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas_2.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("777, 7777777, 7777.77, Luan Marques");

            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using(var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (var i = 0; i < 900000; i++)
                {
                    escritor.WriteLine("Linha 0");
                    escritor.Flush();//Flush() despeja o buffer na stream, tornando a escrita no HD automática a cada linha; 
                    Console.WriteLine($"A linha {i} foi adicionada no arquivo, para adicionar a seguinte, tecle ENTER.");
                    Console.ReadLine();
                }
            }
        }
    } 
}