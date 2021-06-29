//using _05_ByteBank;


namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia; // recebe como Default 0;
        public int numero;  // recebe como Default 0;
        public double saldo = 100; // Default é 100 pois foi atribuido direto na classe;


        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;

        }

        // void indica que não tem retorno
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }


    }
}