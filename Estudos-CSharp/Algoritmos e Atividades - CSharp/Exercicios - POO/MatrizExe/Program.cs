using System;

namespace MatrizExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);

            int[,] mat = new int[m, n];

            for (int linhas = 0; linhas < m; linhas++)
            {
                s = Console.ReadLine().Split(' ');
                for (int colunas = 0; colunas < n; colunas++)
                {
                    mat[linhas, colunas] = int.Parse(s[colunas]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        if (j > 0)
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        if (i > 0)
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        if (j < n - 1)
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        if (i < m - 1)
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);

                        //Solução paliativa para parar a varredura da matriz
                        j = n;
                        i = m;
                    }
                }
            }
        }
    }
}
