using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}