using System;
using System.Globalization;

namespace POOExe3
{
    class Program
    {
        static void Main(string[] args)
        // Fazer um programa para ler os valores da largura e altura de um retângulo. Em
        // seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
        // como mostrado no projeto ao lado.
        {
            Console.Clear();
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Entre a largura e a altura do retãngulo:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
