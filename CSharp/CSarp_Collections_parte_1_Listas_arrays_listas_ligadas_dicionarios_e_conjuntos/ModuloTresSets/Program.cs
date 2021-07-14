using A25OrdenandoETotalizandoLista;
using System;
using System.Collections.Generic;

namespace ModuloTresSets
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Entendendo Set:
            // declara o set
            ISet<string> alunos = new HashSet<string>();
            // adiciona no set
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian"); 
            // retorna o set
            Console.WriteLine(string.Join(", ", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            // adiciona sempre no final da fila;
            Console.WriteLine(string.Join(", ", alunos));


            //Quando algum item é excluido, o próximo adicionado, ocupa o seu indice;
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(", ", alunos));

            //Não adiciona items duplicados;
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(", ", alunos));


            //Sort - ISet não possui o método Sort. Copiar para lista e ordenar;
            //alunos.Sort();
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine($"Ordena Lista: {string.Join(", ", alunosEmLista)}");
            */

            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Lista", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            // instanciar três alunos
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            // matricular aluno no curso

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            // retornar alunos matriculados
            Console.WriteLine("Alunos matriculados: ");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            //Verificar se o aluno está matriculado
            Console.WriteLine($"O aluno a1, {a1.Nome} está matriculado?");
            // Método classe cursos verifica se está matriculado;
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));

            Console.WriteLine("A1 é equals a tonini?");
            Console.WriteLine(a1.Equals(tonini));
        }
    }
}
