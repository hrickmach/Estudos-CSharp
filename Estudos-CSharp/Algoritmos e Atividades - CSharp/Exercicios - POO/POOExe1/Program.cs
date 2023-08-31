using System;
using POOExe1;

namespace POOExe
{
    class Program
    {
        static void Main(string[] args)
        // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
        // velha.
        {
            PersonData p1 = new PersonData();
            PersonData p2 = new PersonData();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
                Console.WriteLine("Pessoa mais velha: " + p1.Name);
            else
                Console.WriteLine("Pesoa mais velha: " + p2.Name);
        }
    }
}
