using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de casos de teste: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Número inválido. Encerraando o programa.");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite os três números para o caso {i + 1}: ");
                string[] line = Console.ReadLine().Split(' ');

                if (line.Length != 3 ||
                    !double.TryParse(line[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double a) ||
                    !double.TryParse(line[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double b) ||
                    !double.TryParse(line[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double c))
                {
                    Console.WriteLine("Entrada inválida. Certifique-se de inserir três números separados por espaço.");
                    i--;
                    continue;
                }

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine($"Média ponderada: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}