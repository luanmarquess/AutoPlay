//using _05_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular{get; set;}
        public int Agencia { get; set; }
        public int Numero { get; set; }

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

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        // void indica que não tem retorno
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }


    }
}