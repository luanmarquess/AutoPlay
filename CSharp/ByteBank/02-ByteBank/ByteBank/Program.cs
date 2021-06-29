using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        public static object SistemasInterno { get; private set; }

        static void Main(string[] args)
        {
            /*


            CalcularBonificacao();

               GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

               Funcionario carlos = new Funcionario(2000, "546.879.157-20");
               carlos.Nome = "Carlos";
               gerenciador.Registrar(carlos);

               carlos.AumentarSalario();
               Console.WriteLine("Novo salário de " + carlos.Nome + " é: " + carlos.Salario);

               Diretor roberta = new Diretor(5000,"454.658.148-3");
               roberta.Nome = "Roberta";
               gerenciador.Registrar(roberta);

               roberta.AumentarSalario();
               Console.WriteLine("Novo salário de " + roberta.Nome + " é: " + roberta.Salario);

               Console.WriteLine(carlos.Nome + ". Bonificacao: " + carlos.GetBonificacao());
               Console.WriteLine(roberta.Nome + ". Bonificacao: " + roberta.GetBonificacao());
               Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
    */
               UsarSistema();
               Console.ReadLine();

        }


       /* public static void CalcularBonificacao()
        {

            GerenciadorBonificacao gerenciadorBonidicacao = new GerenciadorBonificacao();
            Designer pedro = new Designer(3000,"833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor(4000,"159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar(1500,"981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta(4500,"326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonidicacao.Registrar(pedro);
            gerenciadorBonidicacao.Registrar(roberta);
            gerenciadorBonidicacao.Registrar(igor);
            gerenciadorBonidicacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonidicacao.GetTotalBonificacao());
        }*/

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(4000, "159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta(4500, "326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            Designer pedro = new Designer(3000, "833.222.048-39");
            pedro.Nome = "Pedro";

            Console.WriteLine("Resposta esperada, true: " + sistemaInterno.Logar(roberta, "123"));
            Console.WriteLine("Resposta esperada, false: " + sistemaInterno.Logar(roberta, "1232323232"));

            Console.WriteLine("Resposta esperada, true: " + sistemaInterno.Logar(camila, "abc"));
            Console.WriteLine("Resposta esperada, false: " + sistemaInterno.Logar(camila, "222222"));

            //Console.WriteLine("Resposta esperada: NAO COMPILAR, pois pedro é Designer, logo não tem acesso." + sistemaInterno.Logar(pedro, "222222"));

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";
            Console.WriteLine("Resposta esperada, true: " + sistemaInterno.Logar(parceiro, "123"));

            Console.ReadLine();

        }
    }
}
