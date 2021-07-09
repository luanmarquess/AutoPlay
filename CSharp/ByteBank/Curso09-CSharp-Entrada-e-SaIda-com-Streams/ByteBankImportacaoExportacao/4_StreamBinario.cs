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
        static void EscritaBinharia()
        {
            using(var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using(var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);
                escritor.Write(7777777);
                escritor.Write(7777.77);
                escritor.Write("Luan Marques");
            }
        }

        static void LeituraBinaria()
        {
            using(var fs = new FileStream("contaCorrente.txt", FileMode.Open))
                using(var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numero = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}, {numero}, {saldo}, {titular}");
            }
        }
    }
}

