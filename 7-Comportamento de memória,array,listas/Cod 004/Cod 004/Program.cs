using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows and columns of the matrix: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            Console.WriteLine("Enter the numbers in the matrix, row by row: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Line {i + 1}: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Enter a number X to search in the array: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"\nPosition {i},{j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Rigth: {mat[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
