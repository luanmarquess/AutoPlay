using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Executando o projeto 5 - Caracteres e textos?");

			//char == representação de caractere;
			char primeiraLetra = 'a';
			Console.WriteLine(primeiraLetra);

			char segundaLetra = ' ';
			Console.WriteLine(segundaLetra);

			primeiraLetra = (char)65;
			Console.WriteLine(primeiraLetra);// retorna A, pois C# Respeita o ASCTable. 65 == A, 66 == B..

			Console.WriteLine((char)(primeiraLetra + 1));// retorna B;

			//string == representação de texto;
			string titulo = "Alura cursos de teconologia" + 2020 ;
			string cursosDeProgramacao = 
@"- .NET +
- JAVA +
- JAVASCRIPT";	// @ faz o compilador considerar tudo entre as aspas e o texto;

			Console.WriteLine(titulo);
			Console.WriteLine(cursosDeProgramacao);
				

			Console.ReadLine();

		}
    }
}
