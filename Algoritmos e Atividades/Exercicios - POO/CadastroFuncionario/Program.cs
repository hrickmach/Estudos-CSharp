using System;
using System.Collections.Generic;
using System.Globalization;

namespace CadastroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}° funcionário:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Funcionario f = new Funcionario(id, nome, salario);
                lista.Add(f);
            }

            Console.Write("Digite o ID do funcionário que receberá aumento: ");
            int buscarId = int.Parse(Console.ReadLine());

            int pos = lista.FindIndex(x => x.ID == buscarId);
            if (pos == -1)
                Console.WriteLine("ID INESXISTENTE");
            else
            {
                Console.Write("Informe a porcentagem de aumeneto: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista[pos].AcrecimoSalario(porcent);
            }

            Console.WriteLine();
            Console.WriteLine("Listagem atualizada de funcionarios:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

        }
    }
}
