using A25OrdenandoETotalizandoLista;
using ModuloTresSets;
using System;

namespace ModuloQuatroDicionario
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // MODULO 4 COMEÇA AQUI!
            Console.Clear();

            // Método busca saber se número de matricula 5617 está matriculado
            Aluno aluno5617 =csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine($"Aluno 5617: {aluno5617}");
            
            // Procurando matricula inexistente
            Aluno aluno5620 =csharpColecoes.BuscaMatriculado(5620);
            Console.WriteLine($"Aluno 5620: {aluno5620}");

            // Teste adicionar com o mesmo número de matrícula
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            //csharpColecoes.Matricula(fabio);
            csharpColecoes.SubstituiAluno(fabio);
            //criando o método SubstituiAluno
            Console.WriteLine($"O Aluno que tem a matricula 5617 é: {csharpColecoes.BuscaMatriculado(5617)} ");





        }
    }
}
