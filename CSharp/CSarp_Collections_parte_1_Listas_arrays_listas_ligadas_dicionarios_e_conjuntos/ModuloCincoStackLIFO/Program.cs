using ModuloCincoLinkedListStakQueue;
using System;

namespace ModuloCincoStackLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();

            navegador.NavegarPara("Google.com");
            navegador.NavegarPara("Caelum.com.br");
            navegador.NavegarPara("Alura.com.br");

            navegador.Aterior();
            navegador.Aterior();
            navegador.Aterior();
            navegador.Aterior();

            navegador.Proximo();
        }
    }
}
