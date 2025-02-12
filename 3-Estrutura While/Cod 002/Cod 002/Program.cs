using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas X e Y (separadas por espaço). O programa encerra se X ou Y for 0.");

            while (true)
            {
                Console.Write("Digite X e Y: ");
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (x == 0 || y == 0)
                {
                    break; 
                }

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante: primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Quadrante: segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante: terceiro");
                }
                else
                {
                    Console.WriteLine("Quadrante: quarto");
                }
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}