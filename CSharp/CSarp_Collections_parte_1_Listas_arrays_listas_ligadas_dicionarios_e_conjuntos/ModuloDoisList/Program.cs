using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuloDoisList
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // Declaração na Inicialização da Lista
            //List<string> aulas = new List<string>
            //    {
            //        aulaIntro,
            //        aulaModelando,
            //        aulaSets
            //    };

            // Declarando a Lista vazia e adicionando indices com o .Add()
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            //Retorno do primeiro item da lista
            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A primeira aula é " + aulas.First());

            // Retorno do último item da lista
            Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
            Console.WriteLine("A última aula é " + aulas.Last());
             
            //Contains() encontrar a primeira ocorrência .First() caso não encontre, retornará um erro
            Console.WriteLine($"A primeira aula 'Trabalhando' é: {aulas.First(aula => aula.Contains("Trabalhando"))}");
            //.FirstOrDefault() caso não encontre valor, retorna um valor default
            Console.WriteLine($"A primeira aula 'Trabalhando' é: {aulas.FirstOrDefault(aula => aula.Contains("batata"))}");

            // Inverte a ordem da lista;
            aulas.Reverse();
            Imprimir(aulas);

            //remove o indice indicado
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            //revome por parâmetro encontrado
            aulas.Remove("Conclusão");
            Imprimir(aulas);

            // ordena a lista
            aulas.Sort();
            Imprimir(aulas);

            //copia a lista (penúltimo e último index)
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);
        }

        private static void Imprimir(List<string> aulas)
        {
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
        
        /*
       //Outra maneira de criar um metodo para retornar os valores da list;
        private static void Imprimir(List<string> aulas)
        {
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
            Console.WriteLine();
        }
        */
    }
}
