using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuloCincoLinkedListStakQueue
{
    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine($"Página atual: {atual}");
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine($"Página atual: {atual}");
        }

        internal void Aterior()
        {
            if(historicoAnterior.Any()) // Any() vê se há elementos. Se true, executa o bloco
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop(); // POP pega o próximo elemento de uma pilha
                Console.WriteLine($"Página atual: {atual}");
            }
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
        }
    }
}