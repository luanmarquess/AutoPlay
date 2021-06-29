using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(salario, cpf)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
        public override double GetBonificacao() // override sobreescreve o método da classe pai
        {
            return Salario *= 0.17;        
        }
    }
}
