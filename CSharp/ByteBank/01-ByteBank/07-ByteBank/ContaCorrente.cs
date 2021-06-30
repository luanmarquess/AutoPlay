//using _05_ByteBank;


using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {

        public static double TaxaOperacao { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set;}
        public static int TotalDeContasCriadas { get; private set; } // static == propriedade que condiz a classe;
        public Cliente Titular { get; set; }
        //private readonly int _numero; // readonly, torna o campo apenas de leitura e só pode ser setado no construtor;
        public int Numero { get; } // executa a mesma função do readonly, onde deixa apenas atribuir no constructor;

        //private readonly int _agencia;
        public int Agencia { get; }


        private double _saldo = 100; // Default é 100 pois foi atribuido direto na classe;

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this._saldo = value;
            }
        }


        public ContaCorrente(int NumeroAgencia, int NumeroConta)
        {
            if(NumeroAgencia <= 0)
            {
                throw new ArgumentException("A agencia deve ser maior que 0.", nameof(NumeroAgencia));
            }
            if(NumeroConta <= 0)
            {
                throw new ArgumentException("O numero deve ser maior que 0", nameof(NumeroConta));
            }

            Agencia = NumeroAgencia;
            Numero = NumeroConta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }
            if (this._saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this._saldo -= valor;
 
        }

        // void indica que não tem retorno
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
    }
}