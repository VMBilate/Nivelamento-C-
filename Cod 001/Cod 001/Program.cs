using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Soma;

            Console.Write("Digite o primeiro número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out A))
            {
                Console.Write("Entrada inválida! Digite um número inteiro: ");
            }

            Console.Write("Digite o segundo número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out B))
            {
                Console.Write("Entrada inválida! Digite um número inteiro: ");
            }

            Soma = A + B;

            Console.WriteLine($"Soma = {Soma}");
        }
    }
}
