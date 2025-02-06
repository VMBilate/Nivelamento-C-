using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, Dif;

            Console.Write("Digite o primeiro número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out A));

                Console.Write("Digite o segundo número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out B));

            Console.Write("Digite o terceiro número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out C));

            Console.Write("Digite o quarto número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out D));

            Dif = A * B - C * D;

            Console.WriteLine($"Diferença = {Dif}");
        }
    }
}