namespace BancoVirtual
{
    internal class Conta
    {
        public double Saldo { get; private set; }
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }

        public Conta(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta(double depositoInicial, string nome, int numeroConta) : this(nome, numeroConta)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Número da conta: " +
                NumeroConta +
                "; \nNome: " +
                Nome +
                "; \nSaldo: R$" +
                Saldo.ToString("F2") +
                "." +
                "\n-----------------------------------------------";
        }
    }
}
