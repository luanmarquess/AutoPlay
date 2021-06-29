using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar:Funcionario
    {
        public Auxiliar(double salario, string cpf) : base(salario, cpf)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double GetBonificacao() // override sobreescreve o método da classe pai
        {
            return Salario *= 0.2;
            //return Salario + base.GetBonificacao(); // base == chama implemetação da classe base(pai)
        }
    }
}
