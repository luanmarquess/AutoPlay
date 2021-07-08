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
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt"; // procura na pasta debug;

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {

                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); // byte + posição inicial + posição final
                    Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;
            var texto = utf8.GetString(buffer, 0, bytesLidos);// início, qtda bytes a processar

            Console.Write(texto);

            //foreach(var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}


        }
    }
}