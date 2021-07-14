using System;

namespace ModuloUmArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";


            //string[] aulas = new string[]
            //{
            //aulaIntro,
            //aulaModelando,
            //aulaSets
            //};

            //string[] aulas =
            //{
            //aulaIntro,
            //aulaModelando,
            //aulaSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }

            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, "Modelando a Classe Aula"));// retorna o indice do filtro informado

            Array.Reverse(aulas); // inverte o array
            imprimir(aulas);

            Array.Resize(ref aulas, 2); // redimensiona o array
            imprimir(aulas);

            Array.Sort(aulas);// ordena
            imprimir(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 1); // Copia o array idicado. Origem, início origem, destino, início do destino e tamanho;
            imprimir(copia);

            string[] clone = aulas.Clone() as string[]; // Clona o array de forma íntegra;
            imprimir(clone);

            Array.Clear(clone, 1, 1); // 
            imprimir(clone);
        }

        private static void imprimir(string[] aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
