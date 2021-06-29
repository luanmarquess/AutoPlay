using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }
        
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao() // override sobreescreve o método da classe pai
        {
            return Salario *= 1.5;
            //return Salario + base.GetBonificacao(); // base == chama implemetação da classe base(pai)
        }
    }
}
