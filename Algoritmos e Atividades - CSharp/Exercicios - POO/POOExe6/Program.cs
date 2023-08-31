﻿using System;
using System.Globalization;

namespace POOExe6
{
    class Program
    {
        static void Main(string[] args)
        // Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
        // uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
        // que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
        // para ser responsável pelos cálculos.
        {
            Console.Clear();

            Console.Write("Qual a cotação do dólar? ");
            double quote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CurrencyConversion.DolarToReal(quote, qtn);
            Console.WriteLine("Valor a ser pago em reais = "
                              + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
