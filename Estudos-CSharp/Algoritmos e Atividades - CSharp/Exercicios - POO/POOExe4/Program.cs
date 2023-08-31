using System;
using System.Globalization;

namespace POOExe4
{
    class Program
    {
        static void Main(string[] args)
        // Fazer um programa para ler os dados de um funcionário (nome,
        // salário bruto e imposto). Em seguida, mostrar os dados do
        // funcionário (nome e salário líquido). Em seguida, aumentar o salário
        // do funcionário com base em uma porcentagem dada (somente o
        // salário bruto é afetado pela porcentagem) e mostrar novamente os
        // dados do funcionário. Use a classe projetada abaixo.
        {
            Console.Clear();

            Funcionary funcionary = new Funcionary();

            Console.Write("Nome: ");
            funcionary.Name = Console.ReadLine();
            Console.Write("Salário: ");
            funcionary.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionary.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionary);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionary.IncreaseSalary(percent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionary);
        }
    }
}
