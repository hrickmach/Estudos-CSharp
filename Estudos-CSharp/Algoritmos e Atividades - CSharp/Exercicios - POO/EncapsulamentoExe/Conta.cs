using System.Globalization;

namespace EncapsulamentoExe
{
    public class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int numConta)
        {
            Nome = nome;
            NumConta = numConta;
        }
        public Conta(string nome, int numConta, double saldo) : this(nome, numConta)
        {
            Saldo = saldo;
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }
        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}