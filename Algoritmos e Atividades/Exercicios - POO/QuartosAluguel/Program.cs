using System;

namespace QuartosAluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Qauntos alugueis serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Quartos[] vect = new Quartos[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}° aluguel:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("E-Mail: ");
                string eMail = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[quarto] = new Quartos(nome, eMail, quarto);
            }

            Console.WriteLine("Quartos Ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
