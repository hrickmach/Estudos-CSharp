using System;
using System.Globalization;

namespace POOExe2
{
    class Program
    {
        static void Main(string[] args)
        // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
        // médio dos funcionários.
        {
            Console.Clear();
            Funcionary p1 = new Funcionary();
            Funcionary p2 = new Funcionary();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (p1.Salary + p2.Salary) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
