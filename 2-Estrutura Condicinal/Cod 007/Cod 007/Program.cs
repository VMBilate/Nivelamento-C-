using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite dois números dando espaço entre eles: ");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            const double TOLERANCIA = 0.0001;

            if (Math.Abs(x) < TOLERANCIA && Math.Abs(y) < TOLERANCIA)
            {
                Console.WriteLine("Origem");
            }
            else if (Math.Abs(x) < TOLERANCIA)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Math.Abs(y) < TOLERANCIA)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
