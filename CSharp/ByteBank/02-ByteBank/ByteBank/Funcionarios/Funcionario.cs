using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //protecte == permite alteração apenas na classe pai e herdieras;
     
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao(); // abstract == exige que as classes que herdam, sobrescrevam o método;
        
        
        // virtual permite sobrescrever um metódo em class herdeiras;
     
    }
}
