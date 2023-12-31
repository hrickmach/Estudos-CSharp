﻿using System;
using System.Globalization;

namespace POOExe5
{
    class Program
    {
        static void Main(string[] args)
        // Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
        // (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
        // ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
        // para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
        // este problema.
        {
            Console.Clear();
            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
            + student.Result().ToString("F2", CultureInfo.InvariantCulture));
            if (student.Aproved())
                Console.WriteLine("APROVADO");
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + student.RemainingNote().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

        }
    }
}
