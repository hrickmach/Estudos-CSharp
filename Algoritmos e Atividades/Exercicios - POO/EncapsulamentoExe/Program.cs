using System;
using System.Globalization;

namespace EncapsulamentoExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine().ToUpper());

            if (resp == 'S')
            {
                Console.Write("Entre o valor do depósito incial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(nome, numConta, depositoInicial);
            }
            else
            {
                conta = new Conta(nome, numConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
